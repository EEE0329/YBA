
namespace WindowsFormsApp1
{
    partial class Consultar_RNC
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtRNC = new System.Windows.Forms.TextBox();
            this.txtNomRazonSocial = new System.Windows.Forms.TextBox();
            this.txtNomComercial = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtRegimenPagos = new System.Windows.Forms.TextBox();
            this.txtActividadEco = new System.Windows.Forms.TextBox();
            this.txtAdmiLocal = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(607, 60);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(75, 23);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtRNC
            // 
            this.txtRNC.Location = new System.Drawing.Point(107, 36);
            this.txtRNC.Name = "txtRNC";
            this.txtRNC.Size = new System.Drawing.Size(294, 22);
            this.txtRNC.TabIndex = 1;
            // 
            // txtNomRazonSocial
            // 
            this.txtNomRazonSocial.Location = new System.Drawing.Point(107, 124);
            this.txtNomRazonSocial.Name = "txtNomRazonSocial";
            this.txtNomRazonSocial.Size = new System.Drawing.Size(294, 22);
            this.txtNomRazonSocial.TabIndex = 3;
            // 
            // txtNomComercial
            // 
            this.txtNomComercial.Location = new System.Drawing.Point(107, 200);
            this.txtNomComercial.Name = "txtNomComercial";
            this.txtNomComercial.Size = new System.Drawing.Size(294, 22);
            this.txtNomComercial.TabIndex = 4;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(107, 244);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(294, 22);
            this.txtCategoria.TabIndex = 5;
            // 
            // txtRegimenPagos
            // 
            this.txtRegimenPagos.Location = new System.Drawing.Point(107, 297);
            this.txtRegimenPagos.Name = "txtRegimenPagos";
            this.txtRegimenPagos.Size = new System.Drawing.Size(294, 22);
            this.txtRegimenPagos.TabIndex = 6;
            // 
            // txtActividadEco
            // 
            this.txtActividadEco.Location = new System.Drawing.Point(107, 364);
            this.txtActividadEco.Name = "txtActividadEco";
            this.txtActividadEco.Size = new System.Drawing.Size(294, 22);
            this.txtActividadEco.TabIndex = 7;
            // 
            // txtAdmiLocal
            // 
            this.txtAdmiLocal.Location = new System.Drawing.Point(442, 137);
            this.txtAdmiLocal.Name = "txtAdmiLocal";
            this.txtAdmiLocal.Size = new System.Drawing.Size(294, 22);
            this.txtAdmiLocal.TabIndex = 8;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(442, 186);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(294, 22);
            this.txtEstado.TabIndex = 9;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(407, 273);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(683, 339);
            this.webBrowser1.TabIndex = 10;
            // 
            // Consultar_RNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 699);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtAdmiLocal);
            this.Controls.Add(this.txtActividadEco);
            this.Controls.Add(this.txtRegimenPagos);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtNomComercial);
            this.Controls.Add(this.txtNomRazonSocial);
            this.Controls.Add(this.txtRNC);
            this.Controls.Add(this.iconButton1);
            this.Name = "Consultar_RNC";
            this.Text = "Consultar_RNC";
            this.Load += new System.EventHandler(this.Consultar_RNC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtRNC;
        private System.Windows.Forms.TextBox txtNomRazonSocial;
        private System.Windows.Forms.TextBox txtNomComercial;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtRegimenPagos;
        private System.Windows.Forms.TextBox txtActividadEco;
        private System.Windows.Forms.TextBox txtAdmiLocal;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}