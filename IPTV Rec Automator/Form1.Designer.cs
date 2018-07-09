namespace IPTV_Rec_Automator
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextAddr = new System.Windows.Forms.TextBox();
            this.ButtonTest = new System.Windows.Forms.Button();
            this.LabelConnState = new System.Windows.Forms.Label();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelRecState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адреса :";
            // 
            // TextAddr
            // 
            this.TextAddr.Location = new System.Drawing.Point(69, 10);
            this.TextAddr.Name = "TextAddr";
            this.TextAddr.Size = new System.Drawing.Size(216, 20);
            this.TextAddr.TabIndex = 1;
            // 
            // ButtonTest
            // 
            this.ButtonTest.Location = new System.Drawing.Point(16, 36);
            this.ButtonTest.Name = "ButtonTest";
            this.ButtonTest.Size = new System.Drawing.Size(75, 23);
            this.ButtonTest.TabIndex = 2;
            this.ButtonTest.Text = "Тест";
            this.ButtonTest.UseVisualStyleBackColor = true;
            this.ButtonTest.Click += new System.EventHandler(this.ButtonTest_Click);
            // 
            // LabelConnState
            // 
            this.LabelConnState.AutoSize = true;
            this.LabelConnState.BackColor = System.Drawing.Color.Red;
            this.LabelConnState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelConnState.ForeColor = System.Drawing.Color.White;
            this.LabelConnState.Location = new System.Drawing.Point(98, 37);
            this.LabelConnState.Name = "LabelConnState";
            this.LabelConnState.Size = new System.Drawing.Size(98, 18);
            this.LabelConnState.TabIndex = 3;
            this.LabelConnState.Text = "Роз\'єднано";
            this.LabelConnState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CustomFormat = "hh:mm";
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimePicker.Location = new System.Drawing.Point(16, 98);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(75, 20);
            this.StartTimePicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Старт запису";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Стоп запису";
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimePicker.Location = new System.Drawing.Point(97, 98);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(75, 20);
            this.EndTimePicker.TabIndex = 7;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(187, 68);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(104, 23);
            this.ButtonStart.TabIndex = 8;
            this.ButtonStart.Text = "Старт";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonInit_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(187, 95);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(104, 23);
            this.ButtonStop.TabIndex = 9;
            this.ButtonStop.Text = "Стоп";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonDeInit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Стан запису :";
            // 
            // LabelRecState
            // 
            this.LabelRecState.AutoSize = true;
            this.LabelRecState.BackColor = System.Drawing.Color.Yellow;
            this.LabelRecState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRecState.Location = new System.Drawing.Point(94, 126);
            this.LabelRecState.Name = "LabelRecState";
            this.LabelRecState.Size = new System.Drawing.Size(100, 18);
            this.LabelRecState.TabIndex = 11;
            this.LabelRecState.Text = "Неактивний";
            this.LabelRecState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 165);
            this.Controls.Add(this.LabelRecState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.LabelConnState);
            this.Controls.Add(this.ButtonTest);
            this.Controls.Add(this.TextAddr);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "IPTV Rec Automator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextAddr;
        private System.Windows.Forms.Button ButtonTest;
        private System.Windows.Forms.Label LabelConnState;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelRecState;
    }
}

