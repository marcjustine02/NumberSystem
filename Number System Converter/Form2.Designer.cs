
namespace Number_System_Converter
{
    partial class Form2
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
            this.btnConvertBinary = new System.Windows.Forms.Button();
            this.btnConvertDecimal = new System.Windows.Forms.Button();
            this.txtBinary = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(246, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 25);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnConvertBinary
            // 
            this.btnConvertBinary.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertBinary.Location = new System.Drawing.Point(444, 173);
            this.btnConvertBinary.Name = "btnConvertBinary";
            this.btnConvertBinary.Size = new System.Drawing.Size(89, 25);
            this.btnConvertBinary.TabIndex = 16;
            this.btnConvertBinary.Text = "Convert";
            this.btnConvertBinary.UseVisualStyleBackColor = true;
            this.btnConvertBinary.Click += new System.EventHandler(this.btnConvertBinary_Click);
            // 
            // btnConvertDecimal
            // 
            this.btnConvertDecimal.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertDecimal.Location = new System.Drawing.Point(444, 122);
            this.btnConvertDecimal.Name = "btnConvertDecimal";
            this.btnConvertDecimal.Size = new System.Drawing.Size(89, 25);
            this.btnConvertDecimal.TabIndex = 15;
            this.btnConvertDecimal.Text = "Convert";
            this.btnConvertDecimal.UseVisualStyleBackColor = true;
            this.btnConvertDecimal.Click += new System.EventHandler(this.btnConvertDecimal_Click);
            // 
            // txtBinary
            // 
            this.txtBinary.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinary.Location = new System.Drawing.Point(182, 172);
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.Size = new System.Drawing.Size(225, 26);
            this.txtBinary.TabIndex = 14;
            this.txtBinary.TextChanged += new System.EventHandler(this.txtBinary_TextChanged);
            this.txtBinary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBinary_KeyPress);
            // 
            // txtDecimal
            // 
            this.txtDecimal.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecimal.Location = new System.Drawing.Point(182, 121);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(225, 26);
            this.txtDecimal.TabIndex = 13;
            this.txtDecimal.TextChanged += new System.EventHandler(this.txtDecimal_TextChanged);
            this.txtDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDecimal_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Binary Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Decimal Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "CONVERSION CALCULATOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "DECIMAL ↔ BINARY ";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(318, 260);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 25);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(182, 260);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 25);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 309);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnConvertBinary);
            this.Controls.Add(this.btnConvertDecimal);
            this.Controls.Add(this.txtBinary);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "DECIMAL ↔ BINARY CONVERTER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnConvertBinary;
        private System.Windows.Forms.Button btnConvertDecimal;
        private System.Windows.Forms.TextBox txtBinary;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
    }
}