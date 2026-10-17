namespace final_project_win_forms
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
            this.clockLabel = new System.Windows.Forms.Label();
            this.alarmPicker = new System.Windows.Forms.DateTimePicker();
            this.setAlarmButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.Location = new System.Drawing.Point(123, 94);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(70, 25);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "label1";
            // 
            // alarmPicker
            // 
            this.alarmPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.alarmPicker.Location = new System.Drawing.Point(307, 94);
            this.alarmPicker.Name = "alarmPicker";
            this.alarmPicker.ShowUpDown = true;
            this.alarmPicker.Size = new System.Drawing.Size(280, 31);
            this.alarmPicker.TabIndex = 1;
            // 
            // setAlarmButton
            // 
            this.setAlarmButton.Location = new System.Drawing.Point(307, 178);
            this.setAlarmButton.Name = "setAlarmButton";
            this.setAlarmButton.Size = new System.Drawing.Size(159, 67);
            this.setAlarmButton.TabIndex = 2;
            this.setAlarmButton.Text = "Set Alarm";
            this.setAlarmButton.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(123, 368);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(70, 25);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.setAlarmButton);
            this.Controls.Add(this.alarmPicker);
            this.Controls.Add(this.clockLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.DateTimePicker alarmPicker;
        private System.Windows.Forms.Button setAlarmButton;
        private System.Windows.Forms.Label statusLabel;
    }
}

