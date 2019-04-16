namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PortOpen = new System.Windows.Forms.Button();
            this.SendCommand = new System.Windows.Forms.Button();
            this.StopSend = new System.Windows.Forms.Button();
            this.PortSearch = new System.Windows.Forms.Button();
            this.DataSave = new System.Windows.Forms.Button();
            this.PortcomboBox = new System.Windows.Forms.ComboBox();
            this.richTextBox1_valnue = new System.Windows.Forms.RichTextBox();
            this.richTextBox2_valnue = new System.Windows.Forms.RichTextBox();
            this.dBm_valnue_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PortOpen
            // 
            this.PortOpen.Location = new System.Drawing.Point(540, 81);
            this.PortOpen.Name = "PortOpen";
            this.PortOpen.Size = new System.Drawing.Size(75, 23);
            this.PortOpen.TabIndex = 0;
            this.PortOpen.Text = "Open";
            this.PortOpen.UseVisualStyleBackColor = true;
            this.PortOpen.Click += new System.EventHandler(this.PortOpen_Click);
            // 
            // SendCommand
            // 
            this.SendCommand.Location = new System.Drawing.Point(540, 110);
            this.SendCommand.Name = "SendCommand";
            this.SendCommand.Size = new System.Drawing.Size(75, 23);
            this.SendCommand.TabIndex = 1;
            this.SendCommand.Text = "Read";
            this.SendCommand.UseVisualStyleBackColor = true;
            this.SendCommand.Click += new System.EventHandler(this.SendCommand_Click);
            // 
            // StopSend
            // 
            this.StopSend.Location = new System.Drawing.Point(435, 139);
            this.StopSend.Name = "StopSend";
            this.StopSend.Size = new System.Drawing.Size(75, 23);
            this.StopSend.TabIndex = 2;
            this.StopSend.Text = "Exit";
            this.StopSend.UseVisualStyleBackColor = true;
            this.StopSend.Click += new System.EventHandler(this.StopSend_Click);
            // 
            // PortSearch
            // 
            this.PortSearch.Location = new System.Drawing.Point(435, 81);
            this.PortSearch.Name = "PortSearch";
            this.PortSearch.Size = new System.Drawing.Size(75, 23);
            this.PortSearch.TabIndex = 3;
            this.PortSearch.Text = "Search";
            this.PortSearch.UseVisualStyleBackColor = true;
            this.PortSearch.Click += new System.EventHandler(this.PortSearch_Click);
            // 
            // DataSave
            // 
            this.DataSave.Location = new System.Drawing.Point(435, 110);
            this.DataSave.Name = "DataSave";
            this.DataSave.Size = new System.Drawing.Size(75, 23);
            this.DataSave.TabIndex = 4;
            this.DataSave.Text = "Save as";
            this.DataSave.UseVisualStyleBackColor = true;
            this.DataSave.Click += new System.EventHandler(this.DataSave_Click);
            // 
            // PortcomboBox
            // 
            this.PortcomboBox.FormattingEnabled = true;
            this.PortcomboBox.Location = new System.Drawing.Point(435, 28);
            this.PortcomboBox.Name = "PortcomboBox";
            this.PortcomboBox.Size = new System.Drawing.Size(180, 20);
            this.PortcomboBox.TabIndex = 5;
            // 
            // richTextBox1_valnue
            // 
            this.richTextBox1_valnue.Location = new System.Drawing.Point(12, 28);
            this.richTextBox1_valnue.Name = "richTextBox1_valnue";
            this.richTextBox1_valnue.Size = new System.Drawing.Size(100, 160);
            this.richTextBox1_valnue.TabIndex = 8;
            this.richTextBox1_valnue.Text = "";
            // 
            // richTextBox2_valnue
            // 
            this.richTextBox2_valnue.Location = new System.Drawing.Point(133, 28);
            this.richTextBox2_valnue.Name = "richTextBox2_valnue";
            this.richTextBox2_valnue.Size = new System.Drawing.Size(135, 160);
            this.richTextBox2_valnue.TabIndex = 9;
            this.richTextBox2_valnue.Text = "";
            // 
            // dBm_valnue_save
            // 
            this.dBm_valnue_save.Location = new System.Drawing.Point(540, 139);
            this.dBm_valnue_save.Name = "dBm_valnue_save";
            this.dBm_valnue_save.Size = new System.Drawing.Size(75, 23);
            this.dBm_valnue_save.TabIndex = 10;
            this.dBm_valnue_save.Text = "Save";
            this.dBm_valnue_save.UseVisualStyleBackColor = true;
            this.dBm_valnue_save.Click += new System.EventHandler(this.dBm_valnue_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dBm_valnue_save);
            this.Controls.Add(this.richTextBox2_valnue);
            this.Controls.Add(this.richTextBox1_valnue);
            this.Controls.Add(this.PortcomboBox);
            this.Controls.Add(this.DataSave);
            this.Controls.Add(this.PortSearch);
            this.Controls.Add(this.StopSend);
            this.Controls.Add(this.SendCommand);
            this.Controls.Add(this.PortOpen);
            this.Name = "Form1";
            this.Text = "FHP2A04 Optical Power Value V1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PortOpen;
        private System.Windows.Forms.Button SendCommand;
        private System.Windows.Forms.Button StopSend;
        private System.Windows.Forms.Button PortSearch;
        private System.Windows.Forms.Button DataSave;
        private System.Windows.Forms.ComboBox PortcomboBox;
        private System.Windows.Forms.RichTextBox richTextBox1_valnue;
        private System.Windows.Forms.RichTextBox richTextBox2_valnue;
        private System.Windows.Forms.Button dBm_valnue_save;
    }
}

