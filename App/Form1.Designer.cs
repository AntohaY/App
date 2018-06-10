namespace App
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.button_file = new System.Windows.Forms.Button();
            this.button_send = new System.Windows.Forms.Button();
            this.DialogSave = new System.Windows.Forms.SaveFileDialog();
            this.label_file_name = new System.Windows.Forms.Label();
            // this.label_send_result = new System.Windows.Forms.Label();
            label_send_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите IP";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(93, 243);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(100, 20);
            this.textBox_IP.TabIndex = 1;
            // 
            // button_file
            // 
            this.button_file.Location = new System.Drawing.Point(93, 289);
            this.button_file.Name = "button_file";
            this.button_file.Size = new System.Drawing.Size(82, 40);
            this.button_file.TabIndex = 4;
            this.button_file.Text = "Выбрать файл";
            this.button_file.UseVisualStyleBackColor = true;
            this.button_file.Click += new System.EventHandler(this.button_file_Click);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(480, 289);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 5;
            this.button_send.Text = "Отправить";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // label_file_name
            // 
            this.label_file_name.AutoSize = true;
            this.label_file_name.BackColor = System.Drawing.Color.White;
            this.label_file_name.Location = new System.Drawing.Point(462, 315);
            this.label_file_name.Name = "label_file_name";
            this.label_file_name.Size = new System.Drawing.Size(74, 13);
            this.label_file_name.TabIndex = 6;
            this.label_file_name.Text = "Selected file...";
            this.label_file_name.Visible = false;
            // 
            // label_send_result
            // 
           label_send_result.AutoSize = true;
            label_send_result.Location = new System.Drawing.Point(502, 345);
            label_send_result.Name = "label_send_result";
            label_send_result.Size = new System.Drawing.Size(34, 13);
            label_send_result.TabIndex = 7;
            label_send_result.Text = "Blank";
            this.Controls.Add(label_send_result);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::App.Properties.Resources.ok;
            this.ClientSize = new System.Drawing.Size(689, 505);
            this.Controls.Add(label_send_result);
            this.Controls.Add(this.label_file_name);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.button_file);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_IP;
        public System.Windows.Forms.Button button_file;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.SaveFileDialog DialogSave;
        private System.Windows.Forms.Label label_file_name;
        public static System.Windows.Forms.Label label_send_result;
    }
}

