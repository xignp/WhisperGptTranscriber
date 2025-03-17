![image](https://github.com/user-attachments/assets/57e21e47-5858-484a-b613-06de87422e35)
# WhisperGptTranscriber

A C# example project demonstrating how to interact with OpenAI's **Whisper API** for transcription and **GPT API** for summarization of MP3 audio files.

This project is intended to show how to use OpenAI's APIs (Whisper for speech-to-text and GPT for text summarization) from a C# application.

## Features

- **Whisper API Integration**: Transcribe audio (MP3 format) to text.
- **GPT API Integration**: Summarize the transcribed text.
- **C# Implementation**: A simple, clean C# example demonstrating API interaction.

- ## How to use
  1.git clone
  
  2.Open Project
  
  3.Edit the following code:
  
```csharp
// File: MainForm.cs
private readonly string audioFilePath = @"";
private readonly string apiKey = "";
```

Note: Since this example does not consider security best practices, please be careful with how you store and manage your API key. Do not hardcode sensitive information like the API key in the code in production environments.
