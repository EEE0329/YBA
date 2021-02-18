
namespace WindowsFormsApp1
{
    partial class ConsultasCuentasPorPagar
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
            this.txtHastaCpp = new System.Windows.Forms.TextBox();
            this.lblHastaCpp = new System.Windows.Forms.Label();
            this.txtDesdeCpp = new System.Windows.Forms.TextBox();
            this.lblDesdeCpp = new System.Windows.Forms.Label();
            this.txtProeeCpp = new System.Windows.Forms.TextBox();
            this.lblProveeCpp = new System.Windows.Forms.Label();
            this.panelBtnCpp = new System.Windows.Forms.Panel();
            this.btnImprimirClient = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelBtnCpp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtHastaCpp);
            this.panel1.Controls.Add(this.lblHastaCpp);
            this.panel1.Controls.Add(this.txtDesdeCpp);
            this.panel1.Controls.Add(this.lblDesdeCpp);
            this.panel1.Controls.Add(this.txtProeeCpp);
            this.panel1.Controls.Add(this.lblProveeCpp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 69);
            this.panel1.TabIndex = 3;
            // 
            // txtHastaCpp
            // 
            this.txtHastaCpp.Location = new System.Drawing.Point(407, 39);
            this.txtHastaCpp.Name = "txtHastaCpp";
            this.txtHastaCpp.Size = new System.Drawing.Size(139, 22);
            this.txtHastaCpp.TabIndex = 11;
            // 
            // lblHastaCpp
            // 
            this.lblHastaCpp.AutoSize = true;
            this.lblHastaCpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaCpp.Location = new System.Drawing.Point(321, 39);
            this.lblHastaCpp.Name = "lblHastaCpp";
            this.lblHastaCpp.Size = new System.Drawing.Size(65, 20);
            this.lblHastaCpp.TabIndex = 10;
            this.lblHastaCpp.Text = "Hasta:";
            // 
            // txtDesdeCpp
            // 
            this.txtDesdeCpp.Location = new System.Drawing.Point(154, 39);
            this.txtDesdeCpp.Name = "txtDesdeCpp";
            this.txtDesdeCpp.Size = new System.Drawing.Size(139, 22);
            this.txtDesdeCpp.TabIndex = 9;
            // 
            // lblDesdeCpp
            // 
            this.lblDesdeCpp.AutoSize = true;
            this.lblDesdeCpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesdeCpp.Location = new System.Drawing.Point(68, 39);
            this.lblDesdeCpp.Name = "lblDesdeCpp";
            this.lblDesdeCpp.Size = new System.Drawing.Size(69, 20);
            this.lblDesdeCpp.TabIndex = 8;
            this.lblDesdeCpp.Text = "Desde:";
            // 
            // txtProeeCpp
            // 
            this.txtProeeCpp.Location = new System.Drawing.Point(174, 9);
            this.txtProeeCpp.Name = "txtProeeCpp";
            this.txtProeeCpp.Size = new System.Drawing.Size(304, 22);
            this.txtProeeCpp.TabIndex = 7;
            // 
            // lblProveeCpp
            // 
            this.lblProveeCpp.AutoSize = true;
            this.lblProveeCpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveeCpp.Location = new System.Drawing.Point(68, 9);
            this.lblProveeCpp.Name = "lblProveeCpp";
            this.lblProveeCpp.Size = new System.Drawing.Size(100, 20);
            this.lblProveeCpp.TabIndex = 6;
            this.lblProveeCpp.Text = "Proveedor:";
            // 
            // panelBtnCpp
            // 
            this.panelBtnCpp.Controls.Add(this.btnImprimirClient);
            this.panelBtnCpp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBtnCpp.Location = new System.Drawing.Point(0, 373);
            this.panelBtnCpp.Name = "panelBtnCpp";
            this.panelBtnCpp.Size = new System.Drawing.Size(800, 77);
            this.panelBtnCpp.TabIndex = 4;
            // 
            // btnImprimirClient
            // 
            this.btnImprimirClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirClient.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimirClient.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Untitled_design___Copy;
            this.btnImprimirClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimirClient.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnImprimirClient.FlatAppearance.BorderSize = 0;
            this.btnImprimirClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimirClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirClient.ForeColor = System.Drawing.Color.White;
            this.btnImprimirClient.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimirClient.IconColor = System.Drawing.Color.Red;
            this.btnImprimirClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimirClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirClient.Location = new System.Drawing.Point(196, 8);
            this.btnImprimirClient.Name = "btnImprimirClient";
            this.btnImprimirClient.Size = new System.Drawing.Size(127, 57);
            this.btnImprimirClient.TabIndex = 3;
            this.btnImprimirClient.Text = "Imprimir";
            this.btnImprimirClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirClient.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 304);
            this.dataGridView1.TabIndex = 5;
            // 
            // ConsultasCuentasPorPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBtnCpp);
            this.Name = "ConsultasCuentasPorPagar";
            this.Text = "ConsultasCuentasPorPagar";
            this.Controls.SetChildIndex(this.panelBtnCpp, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.btnSeleccionar, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBtnCpp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtHastaCpp;
        private System.Windows.Forms.Label lblHastaCpp;
        private System.Windows.Forms.TextBox txtDesdeCpp;
        private System.Windows.Forms.Label lblDesdeCpp;
        private System.Windows.Forms.TextBox txtProeeCpp;
        private System.Windows.Forms.Label lblProveeCpp;
        private System.Windows.Forms.Panel panelBtnCpp;
        public FontAwesome.Sharp.IconButton btnImprimirClient;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}