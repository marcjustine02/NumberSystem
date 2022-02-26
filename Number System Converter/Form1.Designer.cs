
namespace Number_System_Converter
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBTD = new System.Windows.Forms.Button();
            this.btnOTD = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "CONVERSION CALCULATOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "WELCOME TO";
            // 
            // btnBTD
            // 
            this.btnBTD.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBTD.Location = new System.Drawing.Point(156, 135);
            this.btnBTD.Name = "btnBTD";
            this.btnBTD.Size = new System.Drawing.Size(254, 25);
            this.btnBTD.TabIndex = 16;
            this.btnBTD.Text = "DECIMAL ↔ BINARY ";
            this.btnBTD.UseVisualStyleBackColor = true;
            this.btnBTD.Click += new System.EventHandler(this.btnBTD_Click);
            // 
            // btnOTD
            // 
            this.btnOTD.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOTD.Location = new System.Drawing.Point(156, 166);
            this.btnOTD.Name = "btnOTD";
            this.btnOTD.Size = new System.Drawing.Size(254, 25);
            this.btnOTD.TabIndex = 17;
            this.btnOTD.Text = "DECIMAL ↔ OCTAL ";
            this.btnOTD.UseVisualStyleBackColor = true;
            this.btnOTD.Click += new System.EventHandler(this.btnOTD_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(156, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(254, 25);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "NUMBER SYSTEM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 309);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOTD);
            this.Controls.Add(this.btnBTD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Number System Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBTD;
        private System.Windows.Forms.Button btnOTD;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
    }
}

