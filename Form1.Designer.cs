namespace repaso2_JuaniFinalVargui
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
            this.cbGustos = new System.Windows.Forms.ComboBox();
            this.cbTipos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbGustos
            // 
            this.cbGustos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGustos.FormattingEnabled = true;
            this.cbGustos.Location = new System.Drawing.Point(12, 12);
            this.cbGustos.Name = "cbGustos";
            this.cbGustos.Size = new System.Drawing.Size(175, 21);
            this.cbGustos.TabIndex = 0;
            // 
            // cbTipos
            // 
            this.cbTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipos.FormattingEnabled = true;
            this.cbTipos.Location = new System.Drawing.Point(214, 12);
            this.cbTipos.Name = "cbTipos";
            this.cbTipos.Size = new System.Drawing.Size(121, 21);
            this.cbTipos.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 282);
            this.Controls.Add(this.cbTipos);
            this.Controls.Add(this.cbGustos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGustos;
        private System.Windows.Forms.ComboBox cbTipos;
    }
}

