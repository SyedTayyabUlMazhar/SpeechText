using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;

namespace SpeechToText
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine speechRecognitionEngine = new SpeechRecognitionEngine();

        public Form1()
        {
            InitializeComponent();

            this.radioButtonSpeechToText.CheckedChanged += RadioButtonCheckedChanged;
            this.radioButtonTextToSpeech.CheckedChanged += RadioButtonCheckedChanged;
            this.radioButtonTextToSpeech.Checked = true;
            this.buttonSpeak.Click += ButtonSpeak_Click;

            try
            {
                speechRecognitionEngine.RequestRecognizerUpdate();
                speechRecognitionEngine.LoadGrammar(new DictationGrammar());
                speechRecognitionEngine.SetInputToDefaultAudioDevice();
                speechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "error");
            }
        }

        private void ButtonSpeak_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Volume = 100;
            speechSynthesizer.Speak(this.richTextBoxText.Text);
        }

        private void RadioButtonCheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            
            if(/*radioButton==this.radioButtonTextToSpeech*/ this.radioButtonTextToSpeech.Checked)
            {
                EnableTextToSpeech(true);
                EnableSpeechToText(false);
            }
            else if(/*radioButton==this.radioButtonSpeechToText*/ this.radioButtonSpeechToText.Checked)
            {
                EnableTextToSpeech(false);
                EnableSpeechToText(true);
            }

        }
        private void SpeechRecognitionEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            this.richTextBoxText.Text += e.Result.Text+'\n';
        }

        private void EnableTextToSpeech(bool enable)
        {
            this.buttonSpeak.Enabled = this.richTextBoxText.Enabled = enable;
        }

        private void EnableSpeechToText(bool enable)
        {
            if(enable)
                speechRecognitionEngine.SpeechRecognized += SpeechRecognitionEngine_SpeechRecognized;
            else
                speechRecognitionEngine.SpeechRecognized -= SpeechRecognitionEngine_SpeechRecognized;

        }
    }
}
