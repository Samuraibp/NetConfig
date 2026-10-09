namespace NETConfigAndTrafficWin
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            buttonShow = new Button();
            listBoxTotal = new ListBox();
            listBoxTCPConnection = new ListBox();
            listBoxDevices = new ListBox();
            labelTCPConnections = new Label();
            labelDevices = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonShow);
            groupBox1.Controls.Add(listBoxTotal);
            groupBox1.Controls.Add(listBoxTCPConnection);
            groupBox1.Controls.Add(listBoxDevices);
            groupBox1.Controls.Add(labelTCPConnections);
            groupBox1.Controls.Add(labelDevices);
            groupBox1.Location = new Point(89, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(921, 505);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 242);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 6;
            label1.Text = "Total";
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(236, 435);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(451, 60);
            buttonShow.TabIndex = 5;
            buttonShow.Text = "Show";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // listBoxTotal
            // 
            listBoxTotal.FormattingEnabled = true;
            listBoxTotal.Location = new Point(22, 260);
            listBoxTotal.Name = "listBoxTotal";
            listBoxTotal.Size = new Size(434, 169);
            listBoxTotal.TabIndex = 4;
            // 
            // listBoxTCPConnection
            // 
            listBoxTCPConnection.FormattingEnabled = true;
            listBoxTCPConnection.Location = new Point(462, 50);
            listBoxTCPConnection.Name = "listBoxTCPConnection";
            listBoxTCPConnection.Size = new Size(435, 379);
            listBoxTCPConnection.TabIndex = 3;
            // 
            // listBoxDevices
            // 
            listBoxDevices.FormattingEnabled = true;
            listBoxDevices.Location = new Point(22, 50);
            listBoxDevices.Name = "listBoxDevices";
            listBoxDevices.Size = new Size(434, 184);
            listBoxDevices.TabIndex = 2;
            // 
            // labelTCPConnections
            // 
            labelTCPConnections.AutoSize = true;
            labelTCPConnections.Location = new Point(462, 26);
            labelTCPConnections.Name = "labelTCPConnections";
            labelTCPConnections.Size = new Size(95, 15);
            labelTCPConnections.TabIndex = 1;
            labelTCPConnections.Text = "TCPConnections";
            // 
            // labelDevices
            // 
            labelDevices.AutoSize = true;
            labelDevices.Location = new Point(22, 26);
            labelDevices.Name = "labelDevices";
            labelDevices.Size = new Size(47, 15);
            labelDevices.TabIndex = 0;
            labelDevices.Text = "Devices";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 597);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelDevices;
        private ListBox listBoxTotal;
        private ListBox listBoxTCPConnection;
        private ListBox listBoxDevices;
        private Label labelTCPConnections;
        private Button buttonShow;
        private Label label1;
    }
}
