namespace SpeechToText
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSpeechToText = new System.Windows.Forms.RadioButton();
            this.radioButtonTextToSpeech = new System.Windows.Forms.RadioButton();
            this.buttonSpeak = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Location = new System.Drawing.Point(12, 2);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(786, 324);
            this.richTextBoxText.TabIndex = 2;
            this.richTextBoxText.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSpeechToText);
            this.groupBox1.Controls.Add(this.radioButtonTextToSpeech);
            this.groupBox1.Location = new System.Drawing.Point(27, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // radioButtonSpeechToText
            // 
            this.radioButtonSpeechToText.AutoSize = true;
            this.radioButtonSpeechToText.Location = new System.Drawing.Point(19, 62);
            this.radioButtonSpeechToText.Name = "radioButtonSpeechToText";
            this.radioButtonSpeechToText.Size = new System.Drawing.Size(98, 17);
            this.radioButtonSpeechToText.TabIndex = 5;
            this.radioButtonSpeechToText.TabStop = true;
            this.radioButtonSpeechToText.Text = "Speech to Text";
            this.radioButtonSpeechToText.UseVisualStyleBackColor = true;
            // 
            // radioButtonTextToSpeech
            // 
            this.radioButtonTextToSpeech.AutoSize = true;
            this.radioButtonTextToSpeech.Location = new System.Drawing.Point(19, 23);
            this.radioButtonTextToSpeech.Name = "radioButtonTextToSpeech";
            this.radioButtonTextToSpeech.Size = new System.Drawing.Size(98, 17);
            this.radioButtonTextToSpeech.TabIndex = 4;
            this.radioButtonTextToSpeech.TabStop = true;
            this.radioButtonTextToSpeech.Text = "Text to Speech";
            this.radioButtonTextToSpeech.UseVisualStyleBackColor = true;
            // 
            // buttonSpeak
            // 
            this.buttonSpeak.Location = new System.Drawing.Point(248, 346);
            this.buttonSpeak.Name = "buttonSpeak";
            this.buttonSpeak.Size = new System.Drawing.Size(75, 23);
            this.buttonSpeak.TabIndex = 4;
            this.buttonSpeak.Text = "Speak";
            this.buttonSpeak.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSpeak);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBoxText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSpeechToText;
        private System.Windows.Forms.RadioButton radioButtonTextToSpeech;
        private System.Windows.Forms.Button buttonSpeak;
    }
}

