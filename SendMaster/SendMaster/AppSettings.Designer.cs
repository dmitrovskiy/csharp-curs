namespace SendMaster
{
    partial class AppSettings
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.DefaultSenders = new System.Windows.Forms.ListBox();
            this.AllSenders = new System.Windows.Forms.ListBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.ForwardBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DistTypeCom = new System.Windows.Forms.ComboBox();
            this.TimeSendIntervalN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CountPerSendN = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.IsSIMPLYBodyR = new System.Windows.Forms.RadioButton();
            this.IsHTMLBodyR = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TimeSendIntervalN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountPerSendN)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(517, 478);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(99, 41);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Отменить";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(622, 478);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(99, 41);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DefaultSenders
            // 
            this.DefaultSenders.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DefaultSenders.FormattingEnabled = true;
            this.DefaultSenders.ItemHeight = 21;
            this.DefaultSenders.Location = new System.Drawing.Point(403, 53);
            this.DefaultSenders.Name = "DefaultSenders";
            this.DefaultSenders.Size = new System.Drawing.Size(300, 193);
            this.DefaultSenders.TabIndex = 11;
            this.DefaultSenders.DoubleClick += new System.EventHandler(this.DefaultSenders_DoubleClick);
            // 
            // AllSenders
            // 
            this.AllSenders.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllSenders.FormattingEnabled = true;
            this.AllSenders.ItemHeight = 21;
            this.AllSenders.Location = new System.Drawing.Point(6, 53);
            this.AllSenders.Name = "AllSenders";
            this.AllSenders.Size = new System.Drawing.Size(300, 193);
            this.AllSenders.TabIndex = 10;
            this.AllSenders.DoubleClick += new System.EventHandler(this.AllSenders_DoubleClick);
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(312, 170);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(85, 34);
            this.BackBtn.TabIndex = 13;
            this.BackBtn.Text = "< - Сюда";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // ForwardBtn
            // 
            this.ForwardBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForwardBtn.Location = new System.Drawing.Point(312, 91);
            this.ForwardBtn.Name = "ForwardBtn";
            this.ForwardBtn.Size = new System.Drawing.Size(85, 34);
            this.ForwardBtn.TabIndex = 12;
            this.ForwardBtn.Text = "Туда - >";
            this.ForwardBtn.UseVisualStyleBackColor = true;
            this.ForwardBtn.Click += new System.EventHandler(this.ForwardBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Логика отправки сообщений";
            // 
            // DistTypeCom
            // 
            this.DistTypeCom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistTypeCom.FormattingEnabled = true;
            this.DistTypeCom.Items.AddRange(new object[] {
            "Последовательность",
            "Случайный"});
            this.DistTypeCom.Location = new System.Drawing.Point(310, 175);
            this.DistTypeCom.Name = "DistTypeCom";
            this.DistTypeCom.Size = new System.Drawing.Size(192, 29);
            this.DistTypeCom.TabIndex = 3;
            // 
            // TimeSendIntervalN
            // 
            this.TimeSendIntervalN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeSendIntervalN.Location = new System.Drawing.Point(310, 71);
            this.TimeSendIntervalN.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.TimeSendIntervalN.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TimeSendIntervalN.Name = "TimeSendIntervalN";
            this.TimeSendIntervalN.Size = new System.Drawing.Size(192, 29);
            this.TimeSendIntervalN.TabIndex = 0;
            this.TimeSendIntervalN.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Интервал отправки сообщений";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сколько отправителей за 1 раз";
            // 
            // CountPerSendN
            // 
            this.CountPerSendN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountPerSendN.Location = new System.Drawing.Point(310, 110);
            this.CountPerSendN.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.CountPerSendN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountPerSendN.Name = "CountPerSendN";
            this.CountPerSendN.Size = new System.Drawing.Size(192, 29);
            this.CountPerSendN.TabIndex = 1;
            this.CountPerSendN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Формат сообщения";
            // 
            // IsSIMPLYBodyR
            // 
            this.IsSIMPLYBodyR.AutoSize = true;
            this.IsSIMPLYBodyR.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsSIMPLYBodyR.Location = new System.Drawing.Point(415, 145);
            this.IsSIMPLYBodyR.Name = "IsSIMPLYBodyR";
            this.IsSIMPLYBodyR.Size = new System.Drawing.Size(77, 22);
            this.IsSIMPLYBodyR.TabIndex = 1;
            this.IsSIMPLYBodyR.TabStop = true;
            this.IsSIMPLYBodyR.Text = "Простое";
            this.IsSIMPLYBodyR.UseVisualStyleBackColor = true;
            // 
            // IsHTMLBodyR
            // 
            this.IsHTMLBodyR.AutoSize = true;
            this.IsHTMLBodyR.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsHTMLBodyR.Location = new System.Drawing.Point(324, 145);
            this.IsHTMLBodyR.Name = "IsHTMLBodyR";
            this.IsHTMLBodyR.Size = new System.Drawing.Size(67, 22);
            this.IsHTMLBodyR.TabIndex = 0;
            this.IsHTMLBodyR.TabStop = true;
            this.IsHTMLBodyR.Text = "HTML";
            this.IsHTMLBodyR.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(103, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(627, 54);
            this.label6.TabIndex = 1;
            this.label6.Text = "Настройки";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Image = global::SendMaster.Properties.Resources.small;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 54);
            this.label5.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(733, 54);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DefaultSenders);
            this.groupBox1.Controls.Add(this.AllSenders);
            this.groupBox1.Controls.Add(this.ForwardBtn);
            this.groupBox1.Controls.Add(this.BackBtn);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 262);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ящики по умолчанию";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(403, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Ящики по умолчанию";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Все Ваши ящики";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.IsSIMPLYBodyR);
            this.Controls.Add(this.IsHTMLBodyR);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DistTypeCom);
            this.Controls.Add(this.CountPerSendN);
            this.Controls.Add(this.TimeSendIntervalN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AppSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.TimeSendIntervalN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountPerSendN)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ListBox DefaultSenders;
        private System.Windows.Forms.ListBox AllSenders;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button ForwardBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DistTypeCom;
        private System.Windows.Forms.NumericUpDown TimeSendIntervalN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown CountPerSendN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton IsSIMPLYBodyR;
        private System.Windows.Forms.RadioButton IsHTMLBodyR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;

    }
}