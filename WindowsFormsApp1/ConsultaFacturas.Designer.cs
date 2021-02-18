
namespace WindowsFormsApp1
{
    partial class ConsultaFacturas
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
            this.panelFactura = new System.Windows.Forms.Panel();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.panelBtnFac = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnImprimirFact = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelFactura.SuspendLayout();
            this.panelBtnFac.SuspendLayout();
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
            // panelFactura
            // 
            this.panelFactura.Controls.Add(this.txtHasta);
            this.panelFactura.Controls.Add(this.txtDesde);
            this.panelFactura.Controls.Add(this.lblHasta);
            this.panelFactura.Controls.Add(this.lblDesde);
            this.panelFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFactura.Location = new System.Drawing.Point(0, 0);
            this.panelFactura.Name = "panelFactura";
            this.panelFactura.Size = new System.Drawing.Size(800, 52);
            this.panelFactura.TabIndex = 3;
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(463, 18);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(155, 22);
            this.txtHasta.TabIndex = 3;
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(142, 18);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(155, 22);
            this.txtDesde.TabIndex = 2;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(382, 18);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(65, 20);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(55, 18);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(69, 20);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // panelBtnFac
            // 
            this.panelBtnFac.Controls.Add(this.btnImprimirFact);
            this.panelBtnFac.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBtnFac.Location = new System.Drawing.Point(0, 369);
            this.panelBtnFac.Name = "panelBtnFac";
            this.panelBtnFac.Size = new System.Drawing.Size(800, 81);
            this.panelBtnFac.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 317);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnImprimirFact
            // 
            this.btnImprimirFact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirFact.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimirFact.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Untitled_design___Copy;
            this.btnImprimirFact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimirFact.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnImprimirFact.FlatAppearance.BorderSize = 0;
            this.btnImprimirFact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimirFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirFact.ForeColor = System.Drawing.Color.White;
            this.btnImprimirFact.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImprimirFact.IconColor = System.Drawing.Color.Red;
            this.btnImprimirFact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimirFact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirFact.Location = new System.Drawing.Point(197, 12);
            this.btnImprimirFact.Name = "btnImprimirFact";
            this.btnImprimirFact.Size = new System.Drawing.Size(127, 57);
            this.btnImprimirFact.TabIndex = 2;
            this.btnImprimirFact.Text = "Imprimir";
            this.btnImprimirFact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirFact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirFact.UseVisualStyleBackColor = false;
            // 
            // ConsultaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelFactura);
            this.Controls.Add(this.panelBtnFac);
            this.Name = "ConsultaFacturas";
            this.Text = "ConsultaFacturas";
            this.Controls.SetChildIndex(this.panelBtnFac, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.btnSeleccionar, 0);
            this.Controls.SetChildIndex(this.panelFactura, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panelFactura.ResumeLayout(false);
            this.panelFactura.PerformLayout();
            this.panelBtnFac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFactura;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Panel panelBtnFac;
        private System.Windows.Forms.DataGridView dataGridView1;
        public FontAwesome.Sharp.IconButton btnImprimirFact;
    }
}