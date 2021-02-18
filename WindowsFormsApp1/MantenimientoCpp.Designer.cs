
namespace WindowsFormsApp1
{
    partial class MantenimientoCpp
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
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.lblFdPago = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarMante
            // 
            this.btnGuardarMante.FlatAppearance.BorderSize = 0;
            // 
            // btnElminarMante
            // 
            this.btnElminarMante.FlatAppearance.BorderSize = 0;
            // 
            // btnConsultarMante
            // 
            this.btnConsultarMante.FlatAppearance.BorderSize = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(45, 56);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(100, 20);
            this.lblProveedor.TabIndex = 6;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(45, 114);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(80, 20);
            this.lblArticulo.TabIndex = 7;
            this.lblArticulo.Text = "Articulo:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(483, 116);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(89, 20);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(45, 176);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(66, 20);
            this.lblMonto.TabIndex = 9;
            this.lblMonto.Text = "Monto:";
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlazo.Location = new System.Drawing.Point(483, 189);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(62, 20);
            this.lblPlazo.TabIndex = 10;
            this.lblPlazo.Text = "Plazo:";
            // 
            // lblFdPago
            // 
            this.lblFdPago.AutoSize = true;
            this.lblFdPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFdPago.Location = new System.Drawing.Point(45, 243);
            this.lblFdPago.Name = "lblFdPago";
            this.lblFdPago.Size = new System.Drawing.Size(138, 20);
            this.lblFdPago.TabIndex = 11;
            this.lblFdPago.Text = "Fecha de pago:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(421, 22);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 22);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 22);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(578, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(102, 22);
            this.textBox4.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(551, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 24);
            this.comboBox1.TabIndex = 16;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(637, 189);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(57, 22);
            this.numericUpDown2.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(189, 243);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // MantenimientoCpp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFdPago);
            this.Controls.Add(this.lblPlazo);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblArticulo);
            this.Controls.Add(this.lblProveedor);
            this.Name = "MantenimientoCpp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoCpp";
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnGuardarMante, 0);
            this.Controls.SetChildIndex(this.btnElminarMante, 0);
            this.Controls.SetChildIndex(this.btnConsultarMante, 0);
            this.Controls.SetChildIndex(this.lblProveedor, 0);
            this.Controls.SetChildIndex(this.lblArticulo, 0);
            this.Controls.SetChildIndex(this.lblCantidad, 0);
            this.Controls.SetChildIndex(this.lblMonto, 0);
            this.Controls.SetChildIndex(this.lblPlazo, 0);
            this.Controls.SetChildIndex(this.lblFdPago, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            this.Controls.SetChildIndex(this.textBox4, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.numericUpDown2, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.Label lblFdPago;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}