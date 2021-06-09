
namespace Schach2
{
    partial class PromotionForm
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
            this.queenButton = new System.Windows.Forms.Button();
            this.rookButton = new System.Windows.Forms.Button();
            this.bishopButton = new System.Windows.Forms.Button();
            this.knightButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // queenButton
            // 
            this.queenButton.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.queenButton.Location = new System.Drawing.Point(12, 35);
            this.queenButton.Name = "queenButton";
            this.queenButton.Size = new System.Drawing.Size(64, 61);
            this.queenButton.TabIndex = 0;
            this.queenButton.UseVisualStyleBackColor = true;
            this.queenButton.Click += new System.EventHandler(this.queenButton_Click);
            // 
            // rookButton
            // 
            this.rookButton.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rookButton.Location = new System.Drawing.Point(82, 35);
            this.rookButton.Name = "rookButton";
            this.rookButton.Size = new System.Drawing.Size(64, 61);
            this.rookButton.TabIndex = 1;
            this.rookButton.UseVisualStyleBackColor = true;
            this.rookButton.Click += new System.EventHandler(this.rookButton_Click);
            // 
            // bishopButton
            // 
            this.bishopButton.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bishopButton.Location = new System.Drawing.Point(152, 35);
            this.bishopButton.Name = "bishopButton";
            this.bishopButton.Size = new System.Drawing.Size(64, 61);
            this.bishopButton.TabIndex = 2;
            this.bishopButton.UseVisualStyleBackColor = true;
            this.bishopButton.Click += new System.EventHandler(this.bishopButton_Click);
            // 
            // knightButton
            // 
            this.knightButton.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.knightButton.Location = new System.Drawing.Point(222, 35);
            this.knightButton.Name = "knightButton";
            this.knightButton.Size = new System.Drawing.Size(64, 61);
            this.knightButton.TabIndex = 3;
            this.knightButton.UseVisualStyleBackColor = true;
            this.knightButton.Click += new System.EventHandler(this.knightButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(110, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(73, 15);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "Choose one:";
            // 
            // PromotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 108);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.knightButton);
            this.Controls.Add(this.bishopButton);
            this.Controls.Add(this.rookButton);
            this.Controls.Add(this.queenButton);
            this.Name = "PromotionForm";
            this.Text = "PromotionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button queenButton;
        private System.Windows.Forms.Button rookButton;
        private System.Windows.Forms.Button bishopButton;
        private System.Windows.Forms.Button knightButton;
        private System.Windows.Forms.Label headerLabel;
    }
}