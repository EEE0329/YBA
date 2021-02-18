
namespace WindowsFormsApp1
{
    partial class FrmConsultas
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
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnSeleccionar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Location = new System.Drawing.Point(670, 381);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Untitled_design___Copy;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscar.IconColor = System.Drawing.Color.Red;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(524, 381);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 57);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Untitled_design___Copy;
            this.btnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.IconChar = FontAwesome.Sharp.IconChar.MousePointer;
            this.btnSeleccionar.IconColor = System.Drawing.Color.Red;
            this.btnSeleccionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(350, 381);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(149, 57);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "FrmConsultas";
            this.Text = "FrmConsultas";
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.btnSeleccionar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public FontAwesome.Sharp.IconButton btnBuscar;
        public FontAwesome.Sharp.IconButton btnSeleccionar;
    }
}