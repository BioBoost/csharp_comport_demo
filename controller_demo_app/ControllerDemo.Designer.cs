namespace controller_demo_app
{
    partial class ControllerDemo
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
            this.btnSendByteValue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSerialPorts = new System.Windows.Forms.ComboBox();
            this.numByte = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenComPort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numByte)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendByteValue
            // 
            this.btnSendByteValue.Location = new System.Drawing.Point(106, 51);
            this.btnSendByteValue.Name = "btnSendByteValue";
            this.btnSendByteValue.Size = new System.Drawing.Size(121, 37);
            this.btnSendByteValue.TabIndex = 0;
            this.btnSendByteValue.Text = "Send Byte Value";
            this.btnSendByteValue.UseVisualStyleBackColor = true;
            this.btnSendByteValue.Click += new System.EventHandler(this.btnSendByteValue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select serial port:";
            // 
            // cmbSerialPorts
            // 
            this.cmbSerialPorts.FormattingEnabled = true;
            this.cmbSerialPorts.Location = new System.Drawing.Point(106, 6);
            this.cmbSerialPorts.Name = "cmbSerialPorts";
            this.cmbSerialPorts.Size = new System.Drawing.Size(121, 21);
            this.cmbSerialPorts.TabIndex = 2;
            // 
            // numByte
            // 
            this.numByte.Hexadecimal = true;
            this.numByte.Location = new System.Drawing.Point(34, 51);
            this.numByte.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numByte.Name = "numByte";
            this.numByte.Size = new System.Drawing.Size(66, 20);
            this.numByte.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "0x";
            // 
            // btnOpenComPort
            // 
            this.btnOpenComPort.Location = new System.Drawing.Point(233, 2);
            this.btnOpenComPort.Name = "btnOpenComPort";
            this.btnOpenComPort.Size = new System.Drawing.Size(107, 26);
            this.btnOpenComPort.TabIndex = 5;
            this.btnOpenComPort.Text = "Open COM port";
            this.btnOpenComPort.UseVisualStyleBackColor = true;
            this.btnOpenComPort.Click += new System.EventHandler(this.btnOpenComPort_Click);
            // 
            // ControllerDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 122);
            this.Controls.Add(this.btnOpenComPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numByte);
            this.Controls.Add(this.cmbSerialPorts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendByteValue);
            this.Name = "ControllerDemo";
            this.Text = "Controller Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numByte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendByteValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSerialPorts;
        private System.Windows.Forms.NumericUpDown numByte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenComPort;
    }
}

