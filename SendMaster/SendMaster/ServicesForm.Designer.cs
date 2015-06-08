namespace SendMaster
{
    partial class ServicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesForm));
            this.Services = new System.Windows.Forms.ListBox();
            this.Senders = new System.Windows.Forms.ListBox();
            this.AddServiceBtn = new System.Windows.Forms.Button();
            this.DeleteServiceBtn = new System.Windows.Forms.Button();
            this.AddSenderBtn = new System.Windows.Forms.Button();
            this.DeleteSenderBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Services
            // 
            this.Services.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Services.FormattingEnabled = true;
            this.Services.ItemHeight = 21;
            this.Services.Location = new System.Drawing.Point(12, 140);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(291, 172);
            this.Services.TabIndex = 0;
            this.Services.SelectedIndexChanged += new System.EventHandler(this.Services_SelectedIndexChanged);
            this.Services.DoubleClick += new System.EventHandler(this.Services_DoubleClick);
            // 
            // Senders
            // 
            this.Senders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Senders.FormattingEnabled = true;
            this.Senders.ItemHeight = 21;
            this.Senders.Location = new System.Drawing.Point(320, 140);
            this.Senders.Name = "Senders";
            this.Senders.Size = new System.Drawing.Size(288, 172);
            this.Senders.TabIndex = 1;
            this.Senders.DoubleClick += new System.EventHandler(this.Senders_DoubleClick);
            // 
            // AddServiceBtn
            // 
            this.AddServiceBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddServiceBtn.Location = new System.Drawing.Point(12, 319);
            this.AddServiceBtn.Name = "AddServiceBtn";
            this.AddServiceBtn.Size = new System.Drawing.Size(92, 36);
            this.AddServiceBtn.TabIndex = 2;
            this.AddServiceBtn.Text = "Добавить";
            this.AddServiceBtn.UseVisualStyleBackColor = true;
            this.AddServiceBtn.Click += new System.EventHandler(this.AddServiceBtn_Click);
            // 
            // DeleteServiceBtn
            // 
            this.DeleteServiceBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteServiceBtn.Location = new System.Drawing.Point(110, 319);
            this.DeleteServiceBtn.Name = "DeleteServiceBtn";
            this.DeleteServiceBtn.Size = new System.Drawing.Size(92, 36);
            this.DeleteServiceBtn.TabIndex = 3;
            this.DeleteServiceBtn.Text = "Удалить";
            this.DeleteServiceBtn.UseVisualStyleBackColor = true;
            this.DeleteServiceBtn.Click += new System.EventHandler(this.DeleteServiceBtn_Click);
            // 
            // AddSenderBtn
            // 
            this.AddSenderBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSenderBtn.Location = new System.Drawing.Point(320, 319);
            this.AddSenderBtn.Name = "AddSenderBtn";
            this.AddSenderBtn.Size = new System.Drawing.Size(92, 36);
            this.AddSenderBtn.TabIndex = 4;
            this.AddSenderBtn.Text = "Добавить";
            this.AddSenderBtn.UseVisualStyleBackColor = true;
            this.AddSenderBtn.Click += new System.EventHandler(this.AddSenderBtn_Click);
            // 
            // DeleteSenderBtn
            // 
            this.DeleteSenderBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteSenderBtn.Location = new System.Drawing.Point(418, 319);
            this.DeleteSenderBtn.Name = "DeleteSenderBtn";
            this.DeleteSenderBtn.Size = new System.Drawing.Size(92, 36);
            this.DeleteSenderBtn.TabIndex = 5;
            this.DeleteSenderBtn.Text = "Удалить";
            this.DeleteSenderBtn.UseVisualStyleBackColor = true;
            this.DeleteSenderBtn.Click += new System.EventHandler(this.DeleteSenderBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.Location = new System.Drawing.Point(418, 385);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(92, 36);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Отменить";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.Location = new System.Drawing.Point(516, 385);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(92, 36);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(620, 54);
            this.tableLayoutPanel2.TabIndex = 20;
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
            this.label6.Size = new System.Drawing.Size(514, 54);
            this.label6.TabIndex = 1;
            this.label6.Text = "Сервисы и ящики";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 46);
            this.label1.TabIndex = 23;
            this.label1.Text = "Добавляйте и удаляйте ваши персональные ящики, от которых будет происходить отпра" +
    "вка сообщений.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ваши ящики";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Почтовые сервисы";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 433);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.DeleteSenderBtn);
            this.Controls.Add(this.AddSenderBtn);
            this.Controls.Add(this.DeleteServiceBtn);
            this.Controls.Add(this.AddServiceBtn);
            this.Controls.Add(this.Senders);
            this.Controls.Add(this.Services);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServicesForm";
            this.Text = "Сервисы и ящики";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Services;
        private System.Windows.Forms.ListBox Senders;
        private System.Windows.Forms.Button AddServiceBtn;
        private System.Windows.Forms.Button DeleteServiceBtn;
        private System.Windows.Forms.Button AddSenderBtn;
        private System.Windows.Forms.Button DeleteSenderBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}