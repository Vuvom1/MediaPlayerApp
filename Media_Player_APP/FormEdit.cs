using NAudio.Wave.SampleProviders;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player_APP
{
    public partial class FormEdit : Form
    {
        string inputFilePath1 = "";
        string inputFilePath2 = "";
        string outputFilePath = "";
        public FormEdit()
        {
            InitializeComponent();
        }

        private int getTotalDuration(string inputFilePath)
        {
            TimeSpan totalDuration = TimeSpan.Zero;
            // Create an instance of AudioFileReader
            using (var audioFileReader = new AudioFileReader(inputFilePath))
            {
                // Retrieve the total duration of the audio file
                totalDuration = audioFileReader.TotalTime;

            }
            return (int)totalDuration.TotalSeconds;
        }

        private bool isValidTimeInputs(int starTime1, int endTime1, int duration1, int starTime2, int endTime2, int duration2)
        {
            if (starTime1 < 0 && starTime2 < 0)
            {
                MessageBox.Show("Invalid start time, start time must be greater than 0!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (endTime1 < 0 || endTime2 < 0)
            {
                MessageBox.Show("Invalid end time, end time must be greater than 0!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (endTime1 > duration1 || endTime2 > duration2)
            {
                MessageBox.Show("Invalid end time, end time must be smaller than duration!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Audio Files|*.mp3;*.wav";
                openFileDialog.Title = "Select Audio Files";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Thêm các đường dẫn đã chọn vào danh sách
                    inputFilePath2 = openFileDialog.FileName;
                    lbAudio2.Text = Path.GetFileName(openFileDialog.FileName);

                    lbDuration2.Text = Convert.ToString(getTotalDuration(inputFilePath2));

                }
            }
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Audio Files|*.mp3;*.wav";
                openFileDialog.Title = "Select Audio Files";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Thêm các đường dẫn đã chọn vào danh sách
                    inputFilePath1 = openFileDialog.FileName;
                    lbAudio1.Text = Path.GetFileName(openFileDialog.FileName);

                    lbDuration1.Text = Convert.ToString(getTotalDuration(inputFilePath1));
                }
            }
        }

        private void tBAudio2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBAudio1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "MP3 Files|*.mp3";
                saveFileDialog.Title = "Save as";
                saveFileDialog.FileName = "output.mp3"; // Tên mặc định

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    outputFilePath = saveFileDialog.FileName;

                    if (inputFilePath1 == null || inputFilePath2 == null)
                    {
                        MessageBox.Show("Choose audio file for both.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int startTime1 = int.Parse(tBStartTime1.Text);
                    int endTime1 = int.Parse(tBEndTime1.Text);

                    int startTime2 = int.Parse(tBStartTime2.Text);
                    int endTime2 = int.Parse(tBEndTime2.Text);

                    int playTime1 = int.Parse(tBPlayTime1.Text);
                    int playTime2 = int.Parse(tBPlayTime2.Text);

                    int duration1 = getTotalDuration(inputFilePath1);
                    int duration2 = getTotalDuration(inputFilePath2);

                    if (isValidTimeInputs(startTime1, endTime1, duration1, startTime2, endTime2, duration2))
                    {
                        try
                        {
                            var cutAudio1 = new AudioFileReader(inputFilePath1)
                            .Skip(TimeSpan.FromSeconds(startTime1))
                            .Take(TimeSpan.FromSeconds(endTime1));


                            var cutAudio2 = new AudioFileReader(inputFilePath2)
                            .Skip(TimeSpan.FromSeconds(startTime2))
                            .Take(TimeSpan.FromSeconds(endTime2));

                            var offsetSampleProvider1 = new OffsetSampleProvider(cutAudio1)
                            {
                                DelayBy = TimeSpan.FromSeconds(playTime1) // Adjust the delay as needed
                            };


                            var offsetSampleProvider2 = new OffsetSampleProvider(cutAudio2)
                            {
                                DelayBy = TimeSpan.FromSeconds(playTime2) // Adjust the delay as needed
                            };

                            var mergedWaveProvider = new MixingSampleProvider(new[] { offsetSampleProvider1, offsetSampleProvider2 });

                            WaveFileWriter.CreateWaveFile(outputFilePath, mergedWaveProvider.ToWaveProvider16());

                            MessageBox.Show("Cut and merge completed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Invalid: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }


                }
            }
        }

      
    }
}
