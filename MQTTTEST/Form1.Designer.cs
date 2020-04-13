namespace MQTTTEST
{
    partial class Form_MQTTTEST
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
            this.button_Press = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_Listen = new System.Windows.Forms.Button();
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Press
            // 
            this.button_Press.Location = new System.Drawing.Point(0, 0);
            this.button_Press.Name = "button_Press";
            this.button_Press.Size = new System.Drawing.Size(94, 61);
            this.button_Press.TabIndex = 0;
            this.button_Press.Text = "Press";
            this.button_Press.UseVisualStyleBackColor = true;
            this.button_Press.Click += new System.EventHandler(this.button_Press_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(124, 0);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(95, 61);
            this.button_Stop.TabIndex = 1;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(160, 174);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(240, 106);
            this.button_Send.TabIndex = 3;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_Listen
            // 
            this.button_Listen.Location = new System.Drawing.Point(160, 286);
            this.button_Listen.Name = "button_Listen";
            this.button_Listen.Size = new System.Drawing.Size(240, 75);
            this.button_Listen.TabIndex = 4;
            this.button_Listen.Text = "Listen";
            this.button_Listen.UseVisualStyleBackColor = true;
            this.button_Listen.Click += new System.EventHandler(this.button_Listen_Click);
            // 
            // textBox_Message
            // 
            this.textBox_Message.Location = new System.Drawing.Point(160, 146);
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(240, 22);
            this.textBox_Message.TabIndex = 5;
            // 
            // Form_MQTTTEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 383);
            this.Controls.Add(this.textBox_Message);
            this.Controls.Add(this.button_Listen);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Stop);
            this.Controls.Add(this.button_Press);
            this.Name = "Form_MQTTTEST";
            this.Text = "MQTT Test";
            this.Load += new System.EventHandler(this.Form_MQTTTEST_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Press;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_Listen;
        private System.Windows.Forms.TextBox textBox_Message;
    }
}

