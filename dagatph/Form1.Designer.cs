namespace dagatph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connectButton = new System.Windows.Forms.Button();
            this.connectionStatus = new System.Windows.Forms.Label();
            this.statusText = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yAxis = new System.Windows.Forms.Label();
            this.xAxis = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.phClassify = new System.Windows.Forms.Label();
            this.show_map = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.logsButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(79, 639);
            this.connectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(227, 34);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.Connect);
            // 
            // connectionStatus
            // 
            this.connectionStatus.AutoSize = true;
            this.connectionStatus.BackColor = System.Drawing.Color.Red;
            this.connectionStatus.Location = new System.Drawing.Point(87, 687);
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(16, 16);
            this.connectionStatus.TabIndex = 4;
            this.connectionStatus.Text = "   ";
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Location = new System.Drawing.Point(115, 687);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(166, 16);
            this.statusText.TabIndex = 5;
            this.statusText.Text = "Connection Status: Inactive";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(3, 36);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(324, 56);
            this.trackBar1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 75);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yAxis);
            this.groupBox1.Controls.Add(this.xAxis);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(31, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(340, 118);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GPS Data";
            // 
            // yAxis
            // 
            this.yAxis.AutoSize = true;
            this.yAxis.Location = new System.Drawing.Point(23, 73);
            this.yAxis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yAxis.Name = "yAxis";
            this.yAxis.Size = new System.Drawing.Size(57, 16);
            this.yAxis.TabIndex = 1;
            this.yAxis.Text = "Y - Axis: ";
            // 
            // xAxis
            // 
            this.xAxis.AutoSize = true;
            this.xAxis.Location = new System.Drawing.Point(23, 32);
            this.xAxis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xAxis.Name = "xAxis";
            this.xAxis.Size = new System.Drawing.Size(56, 16);
            this.xAxis.TabIndex = 0;
            this.xAxis.Text = "X - Axis: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.phClassify);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Location = new System.Drawing.Point(31, 185);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(340, 182);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "pH Scale";
            // 
            // phClassify
            // 
            this.phClassify.AutoSize = true;
            this.phClassify.Location = new System.Drawing.Point(17, 145);
            this.phClassify.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phClassify.Name = "phClassify";
            this.phClassify.Size = new System.Drawing.Size(110, 16);
            this.phClassify.TabIndex = 8;
            this.phClassify.Text = "pH Classification:";
            // 
            // show_map
            // 
            this.show_map.Location = new System.Drawing.Point(675, 36);
            this.show_map.Margin = new System.Windows.Forms.Padding(4);
            this.show_map.Name = "show_map";
            this.show_map.Size = new System.Drawing.Size(143, 48);
            this.show_map.TabIndex = 10;
            this.show_map.Text = "Show GPS Map";
            this.show_map.UseVisualStyleBackColor = true;
            this.show_map.Click += new System.EventHandler(this.button1_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(401, 105);
            this.webView21.Margin = new System.Windows.Forms.Padding(4);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(703, 598);
            this.webView21.TabIndex = 11;
            this.webView21.ZoomFactor = 1D;
            // 
            // logsButton
            // 
            this.logsButton.Location = new System.Drawing.Point(79, 384);
            this.logsButton.Name = "logsButton";
            this.logsButton.Size = new System.Drawing.Size(227, 34);
            this.logsButton.TabIndex = 12;
            this.logsButton.Text = "Show Logs";
            this.logsButton.UseVisualStyleBackColor = true;
            this.logsButton.Click += new System.EventHandler(this.logsButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 439);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(340, 178);
            this.dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1133, 736);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logsButton);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.show_map);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.connectionStatus);
            this.Controls.Add(this.connectButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "dagat.ph";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label connectionStatus;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label yAxis;
        private System.Windows.Forms.Label xAxis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label phClassify;
        private System.Windows.Forms.Button show_map;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button logsButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

