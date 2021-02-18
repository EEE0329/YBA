
namespace WindowsFormsApp1
{
    partial class ConsultaClientes
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
            this.txtNombreClient = new System.Windows.Forms.TextBox();
            this.lblNomClient = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImprimirClient = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtNombreClient);
            this.panel1.Controls.Add(this.lblNomClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 50);
            this.panel1.TabIndex = 3;
            // 
            // txtNombreClient
            // 
            this.txtNombreClient.Location = new System.Drawing.Point(159, 13);
            this.txtNombreClient.Name = "txtNombreClient";
            this.txtNombreClient.Size = new System.Drawing.Size(431, 22);
            this.txtNombreClient.TabIndex = 1;
            // 
            // lblNomClient
            // 
            this.lblNomClient.AutoSize = true;
            this.lblNomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomClient.Location = new System.Drawing.Point(73, 13);
            this.lblNomClient.Name = "lblNomClient";
            this.lblNomClient.Size = new System.Drawing.Size(80, 20);
            this.lblNomClient.TabIndex = 0;
            this.lblNomClient.Text = "Nombre:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnImprimirClient);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 78);
            this.panel2.TabIndex = 5;
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
            this.btnImprimirClient.Location = new System.Drawing.Point(196, 9);
            this.btnImprimirClient.Name = "btnImprimirClient";
            this.btnImprimirClient.Size = new System.Drawing.Size(127, 57);
            this.btnImprimirClient.TabIndex = 1;
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 322);
            this.dataGridView1.TabIndex = 6;
            // 
            // ConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ConsultaClientes";
            this.Text = "ConsultaClientes";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.btnSeleccionar, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombreClient;
        private System.Windows.Forms.Label lblNomClient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        public FontAwesome.Sharp.IconButton btnImprimirClient;
    }
}