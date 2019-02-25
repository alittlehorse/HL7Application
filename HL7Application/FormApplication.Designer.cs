namespace HL7Application
{
    partial class FormApplication
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
            this.MessagePage = new System.Windows.Forms.TabControl();
            this.tpMessage = new System.Windows.Forms.TabPage();
            this.txMessage = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.btnSample = new System.Windows.Forms.Button();
            this.tpSend = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rtx_ReceiveMessage = new System.Windows.Forms.RichTextBox();
            this.btnConnectionStop = new System.Windows.Forms.Button();
            this.btnConnectionStart = new System.Windows.Forms.Button();
            this.tpReceivingConnection = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelShowingListening = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MessagePage.SuspendLayout();
            this.tpMessage.SuspendLayout();
            this.tpSend.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tpReceivingConnection.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessagePage
            // 
            this.MessagePage.Controls.Add(this.tpMessage);
            this.MessagePage.Controls.Add(this.tpSend);
            this.MessagePage.Controls.Add(this.tpReceivingConnection);
            this.MessagePage.Location = new System.Drawing.Point(14, 7);
            this.MessagePage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MessagePage.Name = "MessagePage";
            this.MessagePage.SelectedIndex = 0;
            this.MessagePage.Size = new System.Drawing.Size(989, 737);
            this.MessagePage.TabIndex = 0;
            this.MessagePage.Tag = "";
            // 
            // tpMessage
            // 
            this.tpMessage.Controls.Add(this.txMessage);
            this.tpMessage.Controls.Add(this.btSend);
            this.tpMessage.Controls.Add(this.btnSample);
            this.tpMessage.Location = new System.Drawing.Point(4, 28);
            this.tpMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpMessage.Name = "tpMessage";
            this.tpMessage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpMessage.Size = new System.Drawing.Size(981, 705);
            this.tpMessage.TabIndex = 0;
            this.tpMessage.Text = "Message";
            this.tpMessage.UseVisualStyleBackColor = true;
            // 
            // txMessage
            // 
            this.txMessage.Location = new System.Drawing.Point(88, 74);
            this.txMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txMessage.Multiline = true;
            this.txMessage.Name = "txMessage";
            this.txMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txMessage.Size = new System.Drawing.Size(806, 460);
            this.txMessage.TabIndex = 3;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(580, 628);
            this.btSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(84, 28);
            this.btSend.TabIndex = 1;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSample
            // 
            this.btnSample.Location = new System.Drawing.Point(240, 628);
            this.btnSample.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(183, 28);
            this.btnSample.TabIndex = 0;
            this.btnSample.Text = "Create a Sample";
            this.btnSample.UseVisualStyleBackColor = true;
            this.btnSample.Click += new System.EventHandler(this.btnSample_Click);
            // 
            // tpSend
            // 
            this.tpSend.Controls.Add(this.textBox3);
            this.tpSend.Controls.Add(this.label5);
            this.tpSend.Controls.Add(this.label4);
            this.tpSend.Controls.Add(this.tabControl2);
            this.tpSend.Controls.Add(this.btnConnectionStop);
            this.tpSend.Controls.Add(this.btnConnectionStart);
            this.tpSend.Location = new System.Drawing.Point(4, 28);
            this.tpSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpSend.Name = "tpSend";
            this.tpSend.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpSend.Size = new System.Drawing.Size(981, 705);
            this.tpSend.TabIndex = 1;
            this.tpSend.Text = " Sending Connection";
            this.tpSend.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 38);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(112, 28);
            this.textBox3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 7;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(7, 97);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(966, 598);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(958, 566);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Simgle Port MLLP";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(219, 61);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 28);
            this.textBox2.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rtx_ReceiveMessage);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Size = new System.Drawing.Size(958, 566);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rtx_ReceiveMessage
            // 
            this.rtx_ReceiveMessage.Location = new System.Drawing.Point(7, 7);
            this.rtx_ReceiveMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtx_ReceiveMessage.Name = "rtx_ReceiveMessage";
            this.rtx_ReceiveMessage.Size = new System.Drawing.Size(943, 548);
            this.rtx_ReceiveMessage.TabIndex = 0;
            this.rtx_ReceiveMessage.Text = "";
            // 
            // btnConnectionStop
            // 
            this.btnConnectionStop.Location = new System.Drawing.Point(496, 41);
            this.btnConnectionStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnectionStop.Name = "btnConnectionStop";
            this.btnConnectionStop.Size = new System.Drawing.Size(84, 28);
            this.btnConnectionStop.TabIndex = 6;
            this.btnConnectionStop.Text = "Stop";
            this.btnConnectionStop.UseVisualStyleBackColor = true;
            this.btnConnectionStop.Click += new System.EventHandler(this.btnConnectionStop_Click);
            // 
            // btnConnectionStart
            // 
            this.btnConnectionStart.Location = new System.Drawing.Point(348, 38);
            this.btnConnectionStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnectionStart.Name = "btnConnectionStart";
            this.btnConnectionStart.Size = new System.Drawing.Size(84, 28);
            this.btnConnectionStart.TabIndex = 5;
            this.btnConnectionStart.Text = "Start";
            this.btnConnectionStart.UseVisualStyleBackColor = true;
            this.btnConnectionStart.Click += new System.EventHandler(this.btnConnectionStart_Click);
            // 
            // tpReceivingConnection
            // 
            this.tpReceivingConnection.Controls.Add(this.tabControl1);
            this.tpReceivingConnection.Controls.Add(this.panel1);
            this.tpReceivingConnection.Location = new System.Drawing.Point(4, 28);
            this.tpReceivingConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpReceivingConnection.Name = "tpReceivingConnection";
            this.tpReceivingConnection.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpReceivingConnection.Size = new System.Drawing.Size(981, 705);
            this.tpReceivingConnection.TabIndex = 2;
            this.tpReceivingConnection.Text = "Receiving Connection";
            this.tpReceivingConnection.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 151);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(950, 544);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txPort);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(942, 512);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txPort
            // 
            this.txPort.Location = new System.Drawing.Point(81, 94);
            this.txPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txPort.Name = "txPort";
            this.txPort.Size = new System.Drawing.Size(180, 28);
            this.txPort.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(942, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Activity";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(39, 10);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(919, 494);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelShowingListening);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 122);
            this.panel1.TabIndex = 2;
            // 
            // labelShowingListening
            // 
            this.labelShowingListening.AutoSize = true;
            this.labelShowingListening.Location = new System.Drawing.Point(356, 76);
            this.labelShowingListening.Name = "labelShowingListening";
            this.labelShowingListening.Size = new System.Drawing.Size(0, 18);
            this.labelShowingListening.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(215, 71);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(84, 28);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(86, 71);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 28);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btStart_ClickAsync);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 19);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(469, 28);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            // 
            // FormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 758);
            this.Controls.Add(this.MessagePage);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormApplication";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormApplication_Load);
            this.MessagePage.ResumeLayout(false);
            this.tpMessage.ResumeLayout(false);
            this.tpMessage.PerformLayout();
            this.tpSend.ResumeLayout(false);
            this.tpSend.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tpReceivingConnection.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MessagePage;
        private System.Windows.Forms.TabPage tpMessage;
        private System.Windows.Forms.TabPage tpSend;
        private System.Windows.Forms.TabPage tpReceivingConnection;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btnSample;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelShowingListening;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnConnectionStop;
        private System.Windows.Forms.Button btnConnectionStart;
        private System.Windows.Forms.RichTextBox rtx_ReceiveMessage;
        private System.Windows.Forms.TextBox txMessage;
    }
}

