namespace quizapp
{
    partial class server
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ip_Textbox = new System.Windows.Forms.TextBox();
            this.port_Textbox = new System.Windows.Forms.TextBox();
            this.server_Richtextbox = new System.Windows.Forms.RichTextBox();
            this.start_Button = new System.Windows.Forms.Button();
            this.stop_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Actions";
            // 
            // ip_Textbox
            // 
            this.ip_Textbox.Location = new System.Drawing.Point(76, 6);
            this.ip_Textbox.Name = "ip_Textbox";
            this.ip_Textbox.Size = new System.Drawing.Size(201, 20);
            this.ip_Textbox.TabIndex = 3;
            // 
            // port_Textbox
            // 
            this.port_Textbox.Location = new System.Drawing.Point(76, 35);
            this.port_Textbox.Name = "port_Textbox";
            this.port_Textbox.Size = new System.Drawing.Size(201, 20);
            this.port_Textbox.TabIndex = 4;
            // 
            // server_Richtextbox
            // 
            this.server_Richtextbox.Location = new System.Drawing.Point(12, 85);
            this.server_Richtextbox.Name = "server_Richtextbox";
            this.server_Richtextbox.Size = new System.Drawing.Size(645, 312);
            this.server_Richtextbox.TabIndex = 5;
            this.server_Richtextbox.Text = "";
            // 
            // start_Button
            // 
            this.start_Button.Location = new System.Drawing.Point(328, 32);
            this.start_Button.Name = "start_Button";
            this.start_Button.Size = new System.Drawing.Size(75, 23);
            this.start_Button.TabIndex = 6;
            this.start_Button.Text = "Start";
            this.start_Button.UseVisualStyleBackColor = true;
            this.start_Button.Click += new System.EventHandler(this.start_Button_Click);
            // 
            // stop_Button
            // 
            this.stop_Button.Location = new System.Drawing.Point(452, 32);
            this.stop_Button.Name = "stop_Button";
            this.stop_Button.Size = new System.Drawing.Size(75, 23);
            this.stop_Button.TabIndex = 7;
            this.stop_Button.Text = "Stop";
            this.stop_Button.UseVisualStyleBackColor = true;
            this.stop_Button.Click += new System.EventHandler(this.stop_Button_Click);
            // 
            // server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stop_Button);
            this.Controls.Add(this.start_Button);
            this.Controls.Add(this.server_Richtextbox);
            this.Controls.Add(this.port_Textbox);
            this.Controls.Add(this.ip_Textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "server";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ip_Textbox;
        private System.Windows.Forms.TextBox port_Textbox;
        private System.Windows.Forms.RichTextBox server_Richtextbox;
        private System.Windows.Forms.Button start_Button;
        private System.Windows.Forms.Button stop_Button;
    }
}

