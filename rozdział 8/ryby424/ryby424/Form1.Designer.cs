﻿namespace ryby424
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textName = new TextBox();
            buttonStart = new Button();
            buttonAsk = new Button();
            textProgress = new TextBox();
            textBooks = new TextBox();
            listHand = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(508, 9);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 1;
            label2.Text = "Ręka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 69);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Postęp gry";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 498);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Grupy";
            // 
            // textName
            // 
            textName.Location = new Point(12, 27);
            textName.Name = "textName";
            textName.Size = new Size(264, 23);
            textName.TabIndex = 4;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(282, 27);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(220, 23);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "Rozpocznij grę!";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonAsk
            // 
            buttonAsk.Location = new Point(508, 604);
            buttonAsk.Name = "buttonAsk";
            buttonAsk.Size = new Size(198, 23);
            buttonAsk.TabIndex = 6;
            buttonAsk.Text = "Zażądaj karty";
            buttonAsk.UseVisualStyleBackColor = true;
            buttonAsk.Click += buttonAsk_Click;
            // 
            // textProgress
            // 
            textProgress.Location = new Point(12, 87);
            textProgress.Multiline = true;
            textProgress.Name = "textProgress";
            textProgress.ReadOnly = true;
            textProgress.Size = new Size(490, 408);
            textProgress.TabIndex = 7;
            // 
            // textBooks
            // 
            textBooks.Location = new Point(12, 516);
            textBooks.Multiline = true;
            textBooks.Name = "textBooks";
            textBooks.ReadOnly = true;
            textBooks.Size = new Size(490, 111);
            textBooks.TabIndex = 8;
            // 
            // listHand
            // 
            listHand.FormattingEnabled = true;
            listHand.ItemHeight = 15;
            listHand.Location = new Point(508, 27);
            listHand.Name = "listHand";
            listHand.Size = new Size(198, 574);
            listHand.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 639);
            Controls.Add(listHand);
            Controls.Add(textBooks);
            Controls.Add(textProgress);
            Controls.Add(buttonAsk);
            Controls.Add(buttonStart);
            Controls.Add(textName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textName;
        private Button buttonStart;
        private Button buttonAsk;
        private TextBox textProgress;
        private TextBox textBooks;
        private ListBox listHand;
    }
}