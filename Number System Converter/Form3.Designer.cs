
namespace Number_System_Converter
{
    partial class Form3
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnConvertDecimal = new System.Windows.Forms.Button();
            this.txtOctal = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConvertOctal = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(254, 226);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 25);
            this.btnReset.TabIndex = 26;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnConvertDecimal
            // 
            this.btnConvertDecimal.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertDecimal.Location = new System.Drawing.Point(451, 130);
            this.btnConvertDecimal.Name = "btnConvertDecimal";
            this.btnConvertDecimal.Size = new System.Drawing.Size(89, 25);
            this.btnConvertDecimal.TabIndex = 24;
            this.btnConvertDecimal.Text = "Convert";
            this.btnConvertDecimal.UseVisualStyleBackColor = true;
            this.btnConvertDecimal.Click += new System.EventHandler(this.btnConvertDecimal_Click);
            // 
            // txtOctal
            // 
            this.txtOctal.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOctal.Location = new System.Drawing.Point(189, 180);
            this.txtOctal.Name = "txtOctal";
            this.txtOctal.Size = new System.Drawing.Size(225, 26);
            this.txtOctal.TabIndex = 23;
            this.txtOctal.TextChanged += new System.EventHandler(this.txtOctal_TextChanged);
            this.txtOctal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOctal_KeyPress);
            // 
            // txtDecimal
            // 
            this.txtDecimal.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimal.Location = new System.Drawing.Point(189, 129);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(225, 26);
            this.txtDecimal.TabIndex = 22;
            this.txtDecimal.TextChanged += new System.EventHandler(this.txtDecimal_TextChanged);
            this.txtDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimal_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Octal Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Decimal Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "CONVERSION CALCULATOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "DECIMAL ↔ OCTAL ";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(325, 267);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 25);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConvertOctal
            // 
            this.btnConvertOctal.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertOctal.Location = new System.Drawing.Point(451, 180);
            this.btnConvertOctal.Name = "btnConvertOctal";
            this.btnConvertOctal.Size = new System.Drawing.Size(89, 25);
            this.btnConvertOctal.TabIndex = 28;
            this.btnConvertOctal.Text = "Convert";
            this.btnConvertOctal.UseVisualStyleBackColor = true;
            this.btnConvertOctal.Click += new System.EventHandler(this.btnConvertOctal_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(189, 267);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 25);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 309);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConvertOctal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConvertDecimal);
            this.Controls.Add(this.txtOctal);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "DECIMAL ↔ OCTAL CONVERTER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnConvertDecimal;
        private System.Windows.Forms.TextBox txtOctal;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConvertOctal;
        private System.Windows.Forms.Button btnBack;
    }
}