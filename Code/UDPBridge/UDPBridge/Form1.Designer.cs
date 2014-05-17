namespace UDPBridge
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonUDPON = new System.Windows.Forms.Button();
            this.buttonCOMON = new System.Windows.Forms.Button();
            this.buttonUDPOFF = new System.Windows.Forms.Button();
            this.buttonCOMOFF = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 236);
            this.textBox1.TabIndex = 0;
            // 
            // buttonUDPON
            // 
            this.buttonUDPON.Location = new System.Drawing.Point(179, 13);
            this.buttonUDPON.Name = "buttonUDPON";
            this.buttonUDPON.Size = new System.Drawing.Size(75, 23);
            this.buttonUDPON.TabIndex = 1;
            this.buttonUDPON.Text = "UDP ON";
            this.buttonUDPON.UseVisualStyleBackColor = true;
            this.buttonUDPON.Click += new System.EventHandler(this.buttonUDPON_Click);
            // 
            // buttonCOMON
            // 
            this.buttonCOMON.Location = new System.Drawing.Point(300, 13);
            this.buttonCOMON.Name = "buttonCOMON";
            this.buttonCOMON.Size = new System.Drawing.Size(75, 23);
            this.buttonCOMON.TabIndex = 2;
            this.buttonCOMON.Text = "COM OFF";
            this.buttonCOMON.UseVisualStyleBackColor = true;
            this.buttonCOMON.Click += new System.EventHandler(this.buttonCOMON_Click);
            // 
            // buttonUDPOFF
            // 
            this.buttonUDPOFF.Location = new System.Drawing.Point(179, 43);
            this.buttonUDPOFF.Name = "buttonUDPOFF";
            this.buttonUDPOFF.Size = new System.Drawing.Size(75, 23);
            this.buttonUDPOFF.TabIndex = 3;
            this.buttonUDPOFF.Text = "UDP OFF";
            this.buttonUDPOFF.UseVisualStyleBackColor = true;
            this.buttonUDPOFF.Click += new System.EventHandler(this.buttonUDPOFF_Click);
            // 
            // buttonCOMOFF
            // 
            this.buttonCOMOFF.Location = new System.Drawing.Point(300, 43);
            this.buttonCOMOFF.Name = "buttonCOMOFF";
            this.buttonCOMOFF.Size = new System.Drawing.Size(75, 23);
            this.buttonCOMOFF.TabIndex = 4;
            this.buttonCOMOFF.Text = "COM OFF";
            this.buttonCOMOFF.UseVisualStyleBackColor = true;
            this.buttonCOMOFF.Click += new System.EventHandler(this.buttonCOMOFF_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(179, 73);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 176);
            this.textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 261);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonCOMOFF);
            this.Controls.Add(this.buttonUDPOFF);
            this.Controls.Add(this.buttonCOMON);
            this.Controls.Add(this.buttonUDPON);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonUDPON;
        private System.Windows.Forms.Button buttonCOMON;
        private System.Windows.Forms.Button buttonUDPOFF;
        private System.Windows.Forms.Button buttonCOMOFF;
        private System.Windows.Forms.TextBox textBox2;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

