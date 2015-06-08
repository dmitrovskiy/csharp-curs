namespace SendMaster
{
    partial class DistServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DistServices));
            this.AllSenders = new System.Windows.Forms.ListBox();
            this.SendSenders = new System.Windows.Forms.ListBox();
            this.ForwardBtn = new System.Windows.Forms.Button();
            this.BackwardBtn = new System.Windows.Forms.Button();
            this.CalcelBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllSenders
            // 
            this.AllSenders.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllSenders.FormattingEnabled = true;
            this.AllSenders.ItemHeight = 21;
            this.AllSenders.Location = new System.Drawing.Point(12, 94);
            this.AllSenders.Name = "AllSenders";
            this.AllSenders.Size = new System.Drawing.Size(291, 340);
            this.AllSenders.TabIndex = 0;
            this.AllSenders.DoubleClick += new System.EventHandler(this.AllSenders_DoubleClick);
            // 
            // SendSenders
            // 
            this.SendSenders.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendSenders.FormattingEnabled = true;
            this.SendSenders.ItemHeight = 21;
            this.SendSenders.Location = new System.Drawing.Point(393, 94);
            this.SendSenders.Name = "SendSenders";
            this.SendSenders.Size = new System.Drawing.Size(291, 340);
            this.SendSenders.TabIndex = 1;
            this.SendSenders.DoubleClick += new System.EventHandler(this.SendSenders_DoubleClick);
            // 
            // ForwardBtn
            // 
            this.ForwardBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForwardBtn.Location = new System.Drawing.Point(309, 194);
            this.ForwardBtn.Name = "ForwardBtn";
            this.ForwardBtn.Size = new System.Drawing.Size(78, 44);
            this.ForwardBtn.TabIndex = 2;
            this.ForwardBtn.Text = "Туда - >";
            this.ForwardBtn.UseVisualStyleBackColor = true;
            this.ForwardBtn.Click += new System.EventHandler(this.ForwardBtn_Click);
            // 
            // BackwardBtn
            // 
            this.BackwardBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackwardBtn.Location = new System.Drawing.Point(309, 279);
            this.BackwardBtn.Name = "BackwardBtn";
            this.BackwardBtn.Size = new System.Drawing.Size(78, 44);
            this.BackwardBtn.TabIndex = 3;
            this.BackwardBtn.Text = "< - Сюда";
            this.BackwardBtn.UseVisualStyleBackColor = true;
            this.BackwardBtn.Click += new System.EventHandler(this.BackwardBtn_Click);
            // 
            // CalcelBtn
            // 
            this.CalcelBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalcelBtn.Location = new System.Drawing.Point(527, 442);
            this.CalcelBtn.Name = "CalcelBtn";
            this.CalcelBtn.Size = new System.Drawing.Size(75, 37);
            this.CalcelBtn.TabIndex = 4;
            this.CalcelBtn.Text = "Отмена";
            this.CalcelBtn.UseVisualStyleBackColor = true;
            this.CalcelBtn.Click += new System.EventHandler(this.CalcelBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextBtn.Location = new System.Drawing.Point(609, 441);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(75, 37);
            this.NextBtn.TabIndex = 5;
            this.NextBtn.Text = "Дальше";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(699, 54);
            this.tableLayoutPanel2.TabIndex = 19;
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
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(103, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(593, 54);
            this.label6.TabIndex = 1;
            this.label6.Text = "Шаг 1. Выберите ящики, с которых отправлять";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Выбранные ящики";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Все Ваши ящики";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DistServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.CalcelBtn);
            this.Controls.Add(this.BackwardBtn);
            this.Controls.Add(this.ForwardBtn);
            this.Controls.Add(this.SendSenders);
            this.Controls.Add(this.AllSenders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DistServices";
            this.Text = "Ящики";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox AllSenders;
        private System.Windows.Forms.ListBox SendSenders;
        private System.Windows.Forms.Button ForwardBtn;
        private System.Windows.Forms.Button BackwardBtn;
        private System.Windows.Forms.Button CalcelBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}