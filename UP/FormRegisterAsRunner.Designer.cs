namespace UP
{
    partial class FormRegisterAsRunner
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNewRunner = new System.Windows.Forms.Button();
            this.buttonRunner = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 70);
            this.panel1.TabIndex = 8;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(13, 17);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 35);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(112, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marathon skills 2021";
            // 
            // buttonNewRunner
            // 
            this.buttonNewRunner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewRunner.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonNewRunner.Location = new System.Drawing.Point(224, 280);
            this.buttonNewRunner.Name = "buttonNewRunner";
            this.buttonNewRunner.Size = new System.Drawing.Size(303, 65);
            this.buttonNewRunner.TabIndex = 10;
            this.buttonNewRunner.Text = "Я новый участник";
            this.buttonNewRunner.UseVisualStyleBackColor = true;
            this.buttonNewRunner.Click += new System.EventHandler(this.buttonNewRunner_Click);
            // 
            // buttonRunner
            // 
            this.buttonRunner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRunner.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRunner.Location = new System.Drawing.Point(224, 209);
            this.buttonRunner.Name = "buttonRunner";
            this.buttonRunner.Size = new System.Drawing.Size(303, 65);
            this.buttonRunner.TabIndex = 9;
            this.buttonRunner.Text = "Я участвовал ранее";
            this.buttonRunner.UseVisualStyleBackColor = true;
            this.buttonRunner.Click += new System.EventHandler(this.buttonRunner_Click);
            // 
            // FormRegisterAsRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNewRunner);
            this.Controls.Add(this.buttonRunner);
            this.Controls.Add(this.panel1);
            this.Name = "FormRegisterAsRunner";
            this.Text = "FormRegisterAsRunner";
            this.Load += new System.EventHandler(this.FormRegisterAsRunner_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNewRunner;
        private System.Windows.Forms.Button buttonRunner;
    }
}