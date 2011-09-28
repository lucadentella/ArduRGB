namespace ArduRGB
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btColor = new System.Windows.Forms.Button();
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // btColor
            // 
            this.btColor.Location = new System.Drawing.Point(11, 48);
            this.btColor.Name = "btColor";
            this.btColor.Size = new System.Drawing.Size(147, 23);
            this.btColor.TabIndex = 0;
            this.btColor.Text = "Choose color";
            this.btColor.UseVisualStyleBackColor = true;
            this.btColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.Location = new System.Drawing.Point(12, 12);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(146, 21);
            this.cbSerialPort.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 82);
            this.Controls.Add(this.cbSerialPort);
            this.Controls.Add(this.btColor);
            this.Name = "Form1";
            this.Text = "ArduRGB 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btColor;
        private System.Windows.Forms.ComboBox cbSerialPort;
    }
}

