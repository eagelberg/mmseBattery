namespace mmseBattery
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
            this.timePanel = new System.Windows.Forms.Panel();
            this.season = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.month = new System.Windows.Forms.DateTimePicker();
            this.today = new System.Windows.Forms.DateTimePicker();
            this.dayOfTheWeek = new System.Windows.Forms.ComboBox();
            this.loactionPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.timePanel.SuspendLayout();
            this.loactionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timePanel
            // 
            this.timePanel.Controls.Add(this.loactionPanel);
            this.timePanel.Controls.Add(this.dayOfTheWeek);
            this.timePanel.Controls.Add(this.today);
            this.timePanel.Controls.Add(this.month);
            this.timePanel.Controls.Add(this.season);
            this.timePanel.Controls.Add(this.year);
            this.timePanel.Controls.Add(this.label6);
            this.timePanel.Controls.Add(this.label5);
            this.timePanel.Controls.Add(this.label4);
            this.timePanel.Controls.Add(this.label3);
            this.timePanel.Controls.Add(this.label2);
            this.timePanel.Controls.Add(this.label1);
            this.timePanel.Location = new System.Drawing.Point(29, 29);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(807, 384);
            this.timePanel.TabIndex = 0;
            // 
            // season
            // 
            this.season.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.season.FormattingEnabled = true;
            this.season.Items.AddRange(new object[] {
            "winter",
            "fall",
            "spring",
            "summer"});
            this.season.Location = new System.Drawing.Point(300, 142);
            this.season.Name = "season";
            this.season.Size = new System.Drawing.Size(105, 28);
            this.season.TabIndex = 52;
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.year.Location = new System.Drawing.Point(300, 97);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(105, 30);
            this.year.TabIndex = 51;
            this.year.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 25.8F);
            this.label6.Location = new System.Drawing.Point(249, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 48);
            this.label6.TabIndex = 50;
            this.label6.Text = "time questions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "what day of the week is it?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "what is today date?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "what month is it?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(42, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "what season is it?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(42, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "what year is it?";
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(371, 438);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(141, 35);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = "next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // month
            // 
            this.month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.month.Location = new System.Drawing.Point(300, 189);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(105, 30);
            this.month.TabIndex = 53;
            this.month.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // today
            // 
            this.today.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.today.Location = new System.Drawing.Point(300, 232);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(105, 30);
            this.today.TabIndex = 54;
            this.today.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // dayOfTheWeek
            // 
            this.dayOfTheWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dayOfTheWeek.FormattingEnabled = true;
            this.dayOfTheWeek.Items.AddRange(new object[] {
            "sunday",
            "monday",
            "tusday",
            "wednesday",
            "thursday",
            "friday",
            "saturday"});
            this.dayOfTheWeek.Location = new System.Drawing.Point(300, 277);
            this.dayOfTheWeek.Name = "dayOfTheWeek";
            this.dayOfTheWeek.Size = new System.Drawing.Size(105, 28);
            this.dayOfTheWeek.TabIndex = 55;
            // 
            // loactionPanel
            // 
            this.loactionPanel.Controls.Add(this.label7);
            this.loactionPanel.Location = new System.Drawing.Point(0, 0);
            this.loactionPanel.Name = "loactionPanel";
            this.loactionPanel.Size = new System.Drawing.Size(807, 384);
            this.loactionPanel.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(228, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(376, 48);
            this.label7.TabIndex = 0;
            this.label7.Text = "location questions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 511);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.timePanel);
            this.Name = "Form1";
            this.Text = "mmse battery";
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.loactionPanel.ResumeLayout(false);
            this.loactionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.DateTimePicker year;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.ComboBox season;
        private System.Windows.Forms.ComboBox dayOfTheWeek;
        private System.Windows.Forms.DateTimePicker today;
        private System.Windows.Forms.DateTimePicker month;
        private System.Windows.Forms.Panel loactionPanel;
        private System.Windows.Forms.Label label7;
    }
}

