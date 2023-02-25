namespace KarenGómez
{
    partial class segundoform
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SegundoTextBox = new System.Windows.Forms.TextBox();
            this.PrimerTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CalTotalButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.Producto1TextBox = new System.Windows.Forms.TextBox();
            this.Producto2TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Cantidad1textBox = new System.Windows.Forms.TextBox();
            this.Cantidad2textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio primer producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio segundo producto:";
            // 
            // SegundoTextBox
            // 
            this.SegundoTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SegundoTextBox.Location = new System.Drawing.Point(222, 217);
            this.SegundoTextBox.Name = "SegundoTextBox";
            this.SegundoTextBox.Size = new System.Drawing.Size(89, 26);
            this.SegundoTextBox.TabIndex = 7;
            // 
            // PrimerTextBox
            // 
            this.PrimerTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PrimerTextBox.Location = new System.Drawing.Point(222, 170);
            this.PrimerTextBox.Name = "PrimerTextBox";
            this.PrimerTextBox.Size = new System.Drawing.Size(89, 26);
            this.PrimerTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Su total a pagar es de";
            // 
            // CalTotalButton
            // 
            this.CalTotalButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.CalTotalButton.Location = new System.Drawing.Point(396, 270);
            this.CalTotalButton.Name = "CalTotalButton";
            this.CalTotalButton.Size = new System.Drawing.Size(157, 41);
            this.CalTotalButton.TabIndex = 10;
            this.CalTotalButton.Text = "Calcular total a pagar";
            this.CalTotalButton.UseVisualStyleBackColor = false;
            this.CalTotalButton.Click += new System.EventHandler(this.CalTotalButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 11;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(230, 338);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(15, 22);
            this.TotalLabel.TabIndex = 12;
            this.TotalLabel.Text = ":";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Producto1TextBox
            // 
            this.Producto1TextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Producto1TextBox.Location = new System.Drawing.Point(269, 77);
            this.Producto1TextBox.Name = "Producto1TextBox";
            this.Producto1TextBox.Size = new System.Drawing.Size(284, 26);
            this.Producto1TextBox.TabIndex = 18;
            // 
            // Producto2TextBox
            // 
            this.Producto2TextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Producto2TextBox.Location = new System.Drawing.Point(269, 124);
            this.Producto2TextBox.Name = "Producto2TextBox";
            this.Producto2TextBox.Size = new System.Drawing.Size(284, 26);
            this.Producto2TextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nombre del segundo producto: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nombre del primer producto:";
            // 
            // Cantidad1textBox
            // 
            this.Cantidad1textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Cantidad1textBox.Location = new System.Drawing.Point(464, 170);
            this.Cantidad1textBox.Name = "Cantidad1textBox";
            this.Cantidad1textBox.Size = new System.Drawing.Size(89, 26);
            this.Cantidad1textBox.TabIndex = 22;
            // 
            // Cantidad2textBox
            // 
            this.Cantidad2textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Cantidad2textBox.Location = new System.Drawing.Point(464, 221);
            this.Cantidad2textBox.Name = "Cantidad2textBox";
            this.Cantidad2textBox.Size = new System.Drawing.Size(89, 26);
            this.Cantidad2textBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cantidad:";
            // 
            // segundoform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 416);
            this.Controls.Add(this.Cantidad1textBox);
            this.Controls.Add(this.Cantidad2textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Producto1TextBox);
            this.Controls.Add(this.Producto2TextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CalTotalButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrimerTextBox);
            this.Controls.Add(this.SegundoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "segundoform";
            this.Text = "segundoform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SegundoTextBox;
        private System.Windows.Forms.TextBox PrimerTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalTotalButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox Producto1TextBox;
        private System.Windows.Forms.TextBox Producto2TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Cantidad1textBox;
        private System.Windows.Forms.TextBox Cantidad2textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}