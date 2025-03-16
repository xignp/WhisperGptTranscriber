using System.Diagnostics;

namespace OpenAI_API_Example
{
    public partial class MainForm : Form
    {
        // edit to your mp3 file path. example: @"C:\Users\develop\Desktop\example.mp3"
        private readonly string audioFilePath = @"";
        // edit to your OpenAI API key. example: "sk-proj-ABC1234567890"
        private readonly string apiKey = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private async void GetTranscriptionsButton_Click(object sender, EventArgs e)
        {
            transcribeButton.Enabled = false;

            try
            {
                var transcription = await OpenAIAPI.TranscribeAudio(audioFilePath, apiKey);
                transcriptionsTextBox.Text = transcription;

                if(string.IsNullOrEmpty(transcription))
                {
                    transcriptionsTextBox.Text = "Transcription failed.";
                    transcribeButton.Enabled = true;
                    return;
                }

                var summary = await OpenAIAPI.SummarizeText(transcription, apiKey);
                summaryTextBox.Text = summary;

                if (string.IsNullOrEmpty(summary))
                {
                    summaryTextBox.Text = "Summary failed.";
                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }

            transcribeButton.Enabled = true;
        }
    }
}
