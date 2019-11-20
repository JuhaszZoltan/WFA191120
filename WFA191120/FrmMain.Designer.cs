namespace WFA191120
{
    partial class FrmMain
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
            this.tbS = new System.Windows.Forms.TextBox();
            this.btnDoIt = new System.Windows.Forms.Button();
            this.tbO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "sor:";
            // 
            // tbS
            // 
            this.tbS.Location = new System.Drawing.Point(79, 12);
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(100, 22);
            this.tbS.TabIndex = 1;
            this.tbS.Text = "3";
            // 
            // btnDoIt
            // 
            this.btnDoIt.Location = new System.Drawing.Point(15, 84);
            this.btnDoIt.Name = "btnDoIt";
            this.btnDoIt.Size = new System.Drawing.Size(164, 25);
            this.btnDoIt.TabIndex = 2;
            this.btnDoIt.Text = "Do It!";
            this.btnDoIt.UseVisualStyleBackColor = true;
            this.btnDoIt.Click += new System.EventHandler(this.btnDoIt_Click);
            // 
            // tbO
            // 
            this.tbO.Location = new System.Drawing.Point(79, 45);
            this.tbO.Name = "tbO";
            this.tbO.Size = new System.Drawing.Size(100, 22);
            this.tbO.TabIndex = 4;
            this.tbO.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "oszlop:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 121);
            this.Controls.Add(this.tbO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDoIt);
            this.Controls.Add(this.tbS);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Gombos bisz-basz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbS;
        private System.Windows.Forms.Button btnDoIt;
        private System.Windows.Forms.TextBox tbO;
        private System.Windows.Forms.Label label2;
    }
}

