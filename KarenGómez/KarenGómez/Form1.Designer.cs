namespace KarenGómez
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.primerFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segundoFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tercerFormularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primerFormularioToolStripMenuItem,
            this.segundoFormularioToolStripMenuItem,
            this.tercerFormularioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(624, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // primerFormularioToolStripMenuItem
            // 
            this.primerFormularioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primerFormularioToolStripMenuItem.Name = "primerFormularioToolStripMenuItem";
            this.primerFormularioToolStripMenuItem.Size = new System.Drawing.Size(133, 21);
            this.primerFormularioToolStripMenuItem.Text = "Primer Formulario";
            this.primerFormularioToolStripMenuItem.Click += new System.EventHandler(this.primerFormularioToolStripMenuItem_Click);
            // 
            // segundoFormularioToolStripMenuItem
            // 
            this.segundoFormularioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundoFormularioToolStripMenuItem.Name = "segundoFormularioToolStripMenuItem";
            this.segundoFormularioToolStripMenuItem.Size = new System.Drawing.Size(146, 21);
            this.segundoFormularioToolStripMenuItem.Text = "Segundo Formulario";
            this.segundoFormularioToolStripMenuItem.Click += new System.EventHandler(this.segundoFormularioToolStripMenuItem_Click);
            // 
            // tercerFormularioToolStripMenuItem
            // 
            this.tercerFormularioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tercerFormularioToolStripMenuItem.Name = "tercerFormularioToolStripMenuItem";
            this.tercerFormularioToolStripMenuItem.Size = new System.Drawing.Size(129, 21);
            this.tercerFormularioToolStripMenuItem.Text = "Tercer Formulario";
            this.tercerFormularioToolStripMenuItem.Click += new System.EventHandler(this.tercerFormularioToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 100);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Menú";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem primerFormularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segundoFormularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tercerFormularioToolStripMenuItem;
    }
}

