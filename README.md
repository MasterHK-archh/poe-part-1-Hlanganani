# POE-Part1-Hlanganani
This is a CyberSecurity Awareness ChatBot
<img width="817" height="160" alt="github_Actions_CI_Success" src="https://github.com/user-attachments/assets/6a0b908e-571b-4877-acb8-598f40792347" />

NANI_CYBERSECURITY Chatbot

A console-based cybersecurity awareness chatbot with voice greeting and ASCII art logo.

The Features
- Voice greeting on startup
- ASCII art logo from image
- Typewriter text effect
-  Name validation (letters only)
- Cybersecurity Q&A responses

 The Requirements
- Windows OS
- .NET Framework 4.5+
- Visual Studio or C# compiler

 Files Needed
Place these files in your project folder (same level as `.cs` files):

| File | Purpose |
|------|---------|
| `logo.png` | Image for ASCII art |
| `greet_voice.wav` | Voice greeting audio |

How to Compile

 Visual Studio
1. Create Console App (.NET Framework) project
2. Add all `.cs` files
3. Add References: `System.Windows.Forms` and `System.Drawing`
4. Build → Build Solution (Ctrl+Shift+B)

 Command Line
```bash
csc /target:exe /out:NANI_Chatbot.exe /reference:System.Windows.Forms.dll /reference:System.Drawing.dll *.cs
