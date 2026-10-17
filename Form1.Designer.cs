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
            this.titleLabel = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.guessInput = new System.Windows.Forms.NumericUpDown();
            this.newGameButton = new System.Windows.Forms.Button();
            this.attemptsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guessInput)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(123, 94);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(424, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Guess the Number (1–100)";
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(128, 248);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(159, 67);
            this.guessButton.TabIndex = 2;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(351, 184);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(324, 25);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Enter a number and click Guess.";
            // 
            // guessInput
            // 
            this.guessInput.Location = new System.Drawing.Point(128, 178);
            this.guessInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.guessInput.Name = "guessInput";
            this.guessInput.Size = new System.Drawing.Size(120, 31);
            this.guessInput.TabIndex = 4;
            this.guessInput.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(388, 375);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(159, 67);
            this.newGameButton.TabIndex = 5;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            // 
            // attemptsLabel
            // 
            this.attemptsLabel.AutoSize = true;
            this.attemptsLabel.Location = new System.Drawing.Point(383, 269);
            this.attemptsLabel.Name = "attemptsLabel";
            this.attemptsLabel.Size = new System.Drawing.Size(192, 40);
            this.attemptsLabel.TabIndex = 6;
            this.attemptsLabel.Text = "Attempts: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.attemptsLabel);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.guessInput);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.guessInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.NumericUpDown guessInput;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label attemptsLabel;
    }
}

