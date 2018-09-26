namespace GADE6112_TASK3_KYRINNAICKER
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
            this.lblMapDisplay = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.rchUnitInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblMapDisplay
            // 
            this.lblMapDisplay.AutoSize = true;
            this.lblMapDisplay.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapDisplay.Location = new System.Drawing.Point(122, 112);
            this.lblMapDisplay.Name = "lblMapDisplay";
            this.lblMapDisplay.Size = new System.Drawing.Size(76, 22);
            this.lblMapDisplay.TabIndex = 0;
            this.lblMapDisplay.Text = "label1";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(416, 96);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "StartGame";
            this.btnStartGame.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(555, 96);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(401, 151);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(241, 20);
            this.txtInfo.TabIndex = 3;
            // 
            // rchUnitInfo
            // 
            this.rchUnitInfo.Location = new System.Drawing.Point(401, 201);
            this.rchUnitInfo.Name = "rchUnitInfo";
            this.rchUnitInfo.Size = new System.Drawing.Size(241, 170);
            this.rchUnitInfo.TabIndex = 4;
            this.rchUnitInfo.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rchUnitInfo);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.lblMapDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMapDisplay;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.RichTextBox rchUnitInfo;
    }
}

