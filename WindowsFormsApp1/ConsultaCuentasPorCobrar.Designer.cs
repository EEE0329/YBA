
namespace WindowsFormsApp1
{
    partial class ConsultaCuentasPorCobrar
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
            this.panelCpc = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblHastaCpc = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDesdeCpc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNomCpc = new System.Windows.Forms.Label();
            this.panelBtncpc = new System.Windows.Forms.Panel();
            this.btnImprimirClient = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelCpc.SuspendLayout();
            this.panelBtncpc.SuspendLayout();
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
            // panelCpc
            // 
            this.panelCpc.Controls.Add(this.textBox3);
            this.panelCpc.Controls.Add(this.lblHastaCpc);
            this.panelCpc.Controls.Add(this.textBox2);
            this.panelCpc.Controls.Add(this.lblDesdeCpc);
            this.panelCpc.Controls.Add(this.textBox1);
            this.panelCpc.Controls.Add(this.lblNomCpc);
            this.panelCpc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCpc.Location = new System.Drawing.Point(0, 0);
            this.panelCpc.Name = "panelCpc";
            this.panelCpc.Size = new System.Drawing.Size(800, 67);
            this.panelCpc.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(382, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 22);
            this.textBox3.TabIndex = 5;
            // 
            // lblHastaCpc
            // 
            this.lblHastaCpc.AutoSize = true;
            this.lblHastaCpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHastaCpc.Location = new System.Drawing.Point(296, 39);
            this.lblHastaCpc.Name = "lblHastaCpc";
            this.lblHastaCpc.Size = new System.Drawing.Size(65, 20);
            this.lblHastaCpc.TabIndex = 4;
            this.lblHastaCpc.Text = "Hasta:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 22);
            this.textBox2.TabIndex = 3;
            // 
            // lblDesdeCpc
            // 
            this.lblDesdeCpc.AutoSize = true;
            this.lblDesdeCpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesdeCpc.Location = new System.Drawing.Point(43, 39);
            this.lblDesdeCpc.Name = "lblDesdeCpc";
            this.lblDesdeCpc.Size = new System.Drawing.Size(69, 20);
            this.lblDesdeCpc.TabIndex = 2;
            this.lblDesdeCpc.Text = "Desde:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 22);
            this.textBox1.TabIndex = 1;
            // 
            // lblNomCpc
            // 
            this.lblNomCpc.AutoSize = true;
            this.lblNomCpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCpc.Location = new System.Drawing.Point(43, 9);
            this.lblNomCpc.Name = "lblNomCpc";
            this.lblNomCpc.Size = new System.Drawing.Size(80, 20);
            this.lblNomCpc.TabIndex = 0;
            this.lblNomCpc.Text = "Nombre:";
            // 
            // panelBtncpc
            // 
            this.panelBtncpc.Controls.Add(this.btnImprimirClient);
            this.panelBtncpc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBtncpc.Location = new System.Drawing.Point(0, 373);
            this.panelBtncpc.Name = "panelBtncpc";
            this.panelBtncpc.Size = new System.Drawing.Size(800, 77);
            this.panelBtncpc.TabIndex = 4;
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
            this.btnImprimirClient.TabIndex = 2;
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 306);
            this.dataGridView1.TabIndex = 5;
            // 
            // ConsultaCuentasPorCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelCpc);
            this.Controls.Add(this.panelBtncpc);
            this.Name = "ConsultaCuentasPorCobrar";
            this.Text = "ConsultaCuentasPorCobrar";
            this.Controls.SetChildIndex(this.panelBtncpc, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.btnSeleccionar, 0);
            this.Controls.SetChildIndex(this.panelCpc, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panelCpc.ResumeLayout(false);
            this.panelCpc.PerformLayout();
            this.panelBtncpc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCpc;
        private System.Windows.Forms.Panel panelBtncpc;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblHastaCpc;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDesdeCpc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNomCpc;
        private System.Windows.Forms.DataGridView dataGridView1;
        public FontAwesome.Sharp.IconButton btnImprimirClient;
    }
}