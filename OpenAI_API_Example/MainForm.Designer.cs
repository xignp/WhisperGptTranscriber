namespace OpenAI_API_Example
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            transcribeButton = new Button();
            transcriptionsTextBox = new TextBox();
            summaryTextBox = new TextBox();
            TranscriptionsLabel = new Label();
            summaryLabel = new Label();
            SuspendLayout();
            // 
            // transcribeButton
            // 
            transcribeButton.Location = new Point(12, 325);
            transcribeButton.Name = "transcribeButton";
            transcribeButton.Size = new Size(630, 44);
            transcribeButton.TabIndex = 0;
            transcribeButton.Text = "Get Transcription and Summary";
            transcribeButton.UseVisualStyleBackColor = true;
            transcribeButton.Click += GetTranscriptionsButton_Click;
            // 
            // transcriptionsTextBox
            // 
            transcriptionsTextBox.Location = new Point(12, 42);
            transcriptionsTextBox.Multiline = true;
            transcriptionsTextBox.Name = "transcriptionsTextBox";
            transcriptionsTextBox.Size = new Size(307, 266);
            transcriptionsTextBox.TabIndex = 1;
            // 
            // summaryTextBox
            // 
            summaryTextBox.Location = new Point(335, 42);
            summaryTextBox.Multiline = true;
            summaryTextBox.Name = "summaryTextBox";
            summaryTextBox.Size = new Size(307, 266);
            summaryTextBox.TabIndex = 2;
            // 
            // TranscriptionsLabel
            // 
            TranscriptionsLabel.AutoSize = true;
            TranscriptionsLabel.Location = new Point(12, 24);
            TranscriptionsLabel.Name = "TranscriptionsLabel";
            TranscriptionsLabel.Size = new Size(80, 15);
            TranscriptionsLabel.TabIndex = 3;
            TranscriptionsLabel.Text = "Transcriptions";
            // 
            // summaryLabel
            // 
            summaryLabel.AutoSize = true;
            summaryLabel.Location = new Point(335, 24);
            summaryLabel.Name = "summaryLabel";
            summaryLabel.Size = new Size(56, 15);
            summaryLabel.TabIndex = 4;
            summaryLabel.Text = "Summary";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 387);
            Controls.Add(summaryLabel);
            Controls.Add(TranscriptionsLabel);
            Controls.Add(summaryTextBox);
            Controls.Add(transcriptionsTextBox);
            Controls.Add(transcribeButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "SpeechToText(Whisper)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button transcribeButton;
        private TextBox transcriptionsTextBox;
        private TextBox summaryTextBox;
        private Label TranscriptionsLabel;
        private Label summaryLabel;
    }
}
