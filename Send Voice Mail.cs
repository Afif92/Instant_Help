using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Instant_Help
{
    public partial class Send_Voice_Mail : Form
    {
        private int duration;

        private NAudio.Wave.WaveFileReader wave = null;
        private NAudio.Wave.DirectSoundOut output = null;
        NAudio.Wave.WaveIn sourceStream = null;
        NAudio.Wave.WaveFileWriter waveWriter = null;

        public Send_Voice_Mail()
        {
            InitializeComponent();
        }

        private void btnStartRecording_Click(object sender, EventArgs e)
        {
            duration = 120;

            if (sourceList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select a Input Media From The Device Available Section ");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Wave File (*.wav)|*.wav;";
            if (save.ShowDialog() != DialogResult.OK) return;

            int deviceNumber = sourceList.SelectedItems[0].Index;

            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = deviceNumber;
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(deviceNumber).Channels);

            sourceStream.DataAvailable += new EventHandler<NAudio.Wave.WaveInEventArgs>(sourceStream_DataAvailable);
            waveWriter = new NAudio.Wave.WaveFileWriter(save.FileName, sourceStream.WaveFormat);

            sourceStream.StartRecording();
            timer1.Start();
        }
        private void sourceStream_DataAvailable(object sender, NAudio.Wave.WaveInEventArgs e)
        {
            if (waveWriter == null) return;

            waveWriter.WriteData(e.Buffer, 0, e.BytesRecorded);
            waveWriter.Flush();
        }

        private void DisposeWave()
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Stop();
                output.Dispose();
                output = null;
            }
            if (wave != null)
            {
                wave.Dispose();
                wave = null;
            }
        }

        private void btnPlayRecording_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Wave File (*.wav)|*.wav;";
            if (open.ShowDialog() != DialogResult.OK) return;

            DisposeWave();

            wave = new NAudio.Wave.WaveFileReader(open.FileName);
            output = new NAudio.Wave.DirectSoundOut();
            output.Init(new NAudio.Wave.WaveChannel32(wave));
            output.Play();
        }

        private void btnStopRecording_Click(object sender, EventArgs e)
        {
            stopRecording();
        }
        private void stopRecording()
        {
            if (sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.Dispose();
                sourceStream = null;
            }
            if (waveWriter != null)
            {
                waveWriter.Dispose();
                waveWriter = null;
            }
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (duration == 0) { stopRecording(); }
            else
            {
                duration--;
                txtTimerBox.Text = duration.ToString();
            }
        }

        private void Send_Voice_Mail_Load(object sender, EventArgs e)
        {
            List<NAudio.Wave.WaveInCapabilities> sources = new List<NAudio.Wave.WaveInCapabilities>();

            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));
            }

            sourceList.Items.Clear();

            foreach (var source in sources)
            {
                ListViewItem item = new ListViewItem(source.ProductName);
                sourceList.Items.Add(item);
            }
            txtTimerBox.Text = "120";
        }

        private void Send_Voice_Mail_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeWave();
        }
    }
}
