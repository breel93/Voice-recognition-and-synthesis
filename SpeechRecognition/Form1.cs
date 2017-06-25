using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace SpeechRecognition
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer syn = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }

        private void enableVoiceBtn_Click(object sender, EventArgs e)
        {
             
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            disabledVoiceBtn.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "hello there", " say my name","Whats good?" });
            GrammarBuilder gramBuilder = new GrammarBuilder();
            gramBuilder.Append(commands);
            Grammar gram = new Grammar(gramBuilder);

            recEngine.LoadGrammarAsync(gram);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += RecEngine_SpeechRecognized;

        }

        void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch(e.Result.Text)
            {
                case "hello there":
                    PromptBuilder pBuilder = new PromptBuilder();

                    pBuilder.StartSentence();
                    pBuilder.AppendText("Hello Kola");
                    pBuilder.EndSentence();
                    pBuilder.AppendBreak(PromptBreak.Small);
                    pBuilder.StartSentence();
                    pBuilder.AppendText("Hey Whats Up?",PromptEmphasis.Strong);
                    pBuilder.EndSentence();

                    syn.SpeakAsync(pBuilder);
                    richTextBox1.Text += "Hey Whats Up";
                    break;
                case "say my name":
                    syn.SpeakAsync("Your name is Kola");
                    richTextBox1.Text += "\nYour name is kola";
                    break;
                case "Whats good?":
                    syn.SpeakAsync("Not alot man, just here chilling!");
                    richTextBox1.Text += "\nNot alot man, just here chilling1";
                    break;
                case "say text":
                    syn.SpeakAsync(richTextBox1.Text);
                    break;
            }
            //throw new NotImplementedException();
        }

        private void disabledVoiceBtn_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            enableVoiceBtn.Enabled = true;
        }
    }
}
