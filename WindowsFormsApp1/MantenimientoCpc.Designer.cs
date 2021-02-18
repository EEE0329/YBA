
namespace WindowsFormsApp1
{
    partial class MantenimientoCpc
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
            this.lblClienMCpc = new System.Windows.Forms.Label();
            this.lblIdCLienteCpc = new System.Windows.Forms.Label();
            this.dtFechadpCpc = new System.Windows.Forms.DateTimePicker();
            this.numPlazoCpc = new System.Windows.Forms.NumericUpDown();
            this.cbPlzoCpc = new System.Windows.Forms.ComboBox();
            this.txtCantidaCpc = new System.Windows.Forms.TextBox();
            this.txtMontoCpc = new System.Windows.Forms.TextBox();
            this.txtArticuloCpc = new System.Windows.Forms.TextBox();
            this.lblFdPago = new System.Windows.Forms.Label();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblArticuloCpc = new System.Windows.Forms.Label();
            this.txtClientCpc = new System.Windows.Forms.TextBox();
            this.txtIDCpc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlazoCpc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarMante
            // 
            this.btnGuardarMante.FlatAppearance.BorderSize = 0;
            this.btnGuardarMante.Location = new System.Drawing.Point(601, 381);
            // 
            // btnElminarMante
            // 
            this.btnElminarMante.FlatAppearance.BorderSize = 0;
            this.btnElminarMante.Location = new System.Drawing.Point(458, 381);
            // 
            // btnConsultarMante
            // 
            this.btnConsultarMante.FlatAppearance.BorderSize = 0;
            this.btnConsultarMante.Location = new System.Drawing.Point(303, 381);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Location = new System.Drawing.Point(745, 381);
            // 
            // lblClienMCpc
            // 
            this.lblClienMCpc.AutoSize = true;
            this.lblClienMCpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienMCpc.Location = new System.Drawing.Point(76, 79);
            this.lblClienMCpc.Name = "lblClienMCpc";
            this.lblClienMCpc.Size = new System.Drawing.Size(74, 20);
            this.lblClienMCpc.TabIndex = 6;
            this.lblClienMCpc.Text = "Cliente:";
            // 
            // lblIdCLienteCpc
            // 
            this.lblIdCLienteCpc.AutoSize = true;
            this.lblIdCLienteCpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCLienteCpc.Location = new System.Drawing.Point(522, 79);
            this.lblIdCLienteCpc.Name = "lblIdCLienteCpc";
            this.lblIdCLienteCpc.Size = new System.Drawing.Size(98, 20);
            this.lblIdCLienteCpc.TabIndex = 7;
            this.lblIdCLienteCpc.Text = "ID.Cliente:";
            // 
            // dtFechadpCpc
            // 
            this.dtFechadpCpc.Location = new System.Drawing.Point(220, 279);
            this.dtFechadpCpc.Name = "dtFechadpCpc";
            this.dtFechadpCpc.Size = new System.Drawing.Size(243, 22);
            this.dtFechadpCpc.TabIndex = 31;
            // 
            // numPlazoCpc
            // 
            this.numPlazoCpc.Location = new System.Drawing.Point(668, 225);
            this.numPlazoCpc.Name = "numPlazoCpc";
            this.numPlazoCpc.Size = new System.Drawing.Size(57, 22);
            this.numPlazoCpc.TabIndex = 30;
            // 
            // cbPlzoCpc
            // 
            this.cbPlzoCpc.FormattingEnabled = true;
            this.cbPlzoCpc.Location = new System.Drawing.Point(582, 225);
            this.cbPlzoCpc.Name = "cbPlzoCpc";
            this.cbPlzoCpc.Size = new System.Drawing.Size(80, 24);
            this.cbPlzoCpc.TabIndex = 29;
            // 
            // txtCantidaCpc
            // 
            this.txtCantidaCpc.Location = new System.Drawing.Point(609, 152);
            this.txtCantidaCpc.Name = "txtCantidaCpc";
            this.txtCantidaCpc.Size = new System.Drawing.Size(102, 22);
            this.txtCantidaCpc.TabIndex = 28;
            // 
            // txtMontoCpc
            // 
            this.txtMontoCpc.Location = new System.Drawing.Point(168, 210);
            this.txtMontoCpc.Name = "txtMontoCpc";
            this.txtMontoCpc.Size = new System.Drawing.Size(135, 22);
            this.txtMontoCpc.TabIndex = 27;
            // 
            // txtArticuloCpc
            // 
            this.txtArticuloCpc.Location = new System.Drawing.Point(168, 150);
            this.txtArticuloCpc.Name = "txtArticuloCpc";
            this.txtArticuloCpc.Size = new System.Drawing.Size(256, 22);
            this.txtArticuloCpc.TabIndex = 26;
            // 
            // lblFdPago
            // 
            this.lblFdPago.AutoSize = true;
            this.lblFdPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFdPago.Location = new System.Drawing.Point(76, 279);
            this.lblFdPago.Name = "lblFdPago";
            this.lblFdPago.Size = new System.Drawing.Size(138, 20);
            this.lblFdPago.TabIndex = 25;
            this.lblFdPago.Text = "Fecha de pago:";
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlazo.Location = new System.Drawing.Point(514, 225);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(62, 20);
            this.lblPlazo.TabIndex = 24;
            this.lblPlazo.Text = "Plazo:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(76, 212);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(66, 20);
            this.lblMonto.TabIndex = 23;
            this.lblMonto.Text = "Monto:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(514, 152);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(89, 20);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblArticuloCpc
            // 
            this.lblArticuloCpc.AutoSize = true;
            this.lblArticuloCpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticuloCpc.Location = new System.Drawing.Point(76, 150);
            this.lblArticuloCpc.Name = "lblArticuloCpc";
            this.lblArticuloCpc.Size = new System.Drawing.Size(80, 20);
            this.lblArticuloCpc.TabIndex = 21;
            this.lblArticuloCpc.Text = "Articulo:";
            // 
            // txtClientCpc
            // 
            this.txtClientCpc.Location = new System.Drawing.Point(168, 79);
            this.txtClientCpc.Name = "txtClientCpc";
            this.txtClientCpc.Size = new System.Drawing.Size(256, 22);
            this.txtClientCpc.TabIndex = 32;
            // 
            // txtIDCpc
            // 
            this.txtIDCpc.Location = new System.Drawing.Point(626, 79);
            this.txtIDCpc.Name = "txtIDCpc";
            this.txtIDCpc.Size = new System.Drawing.Size(229, 22);
            this.txtIDCpc.TabIndex = 33;
            // 
            // MantenimientoCpc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.txtIDCpc);
            this.Controls.Add(this.txtClientCpc);
            this.Controls.Add(this.dtFechadpCpc);
            this.Controls.Add(this.numPlazoCpc);
            this.Controls.Add(this.cbPlzoCpc);
            this.Controls.Add(this.txtCantidaCpc);
            this.Controls.Add(this.txtMontoCpc);
            this.Controls.Add(this.txtArticuloCpc);
            this.Controls.Add(this.lblFdPago);
            this.Controls.Add(this.lblPlazo);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblArticuloCpc);
            this.Controls.Add(this.lblIdCLienteCpc);
            this.Controls.Add(this.lblClienMCpc);
            this.Name = "MantenimientoCpc";
            this.Text = "MantenimientoCpc";
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnGuardarMante, 0);
            this.Controls.SetChildIndex(this.btnElminarMante, 0);
            this.Controls.SetChildIndex(this.btnConsultarMante, 0);
            this.Controls.SetChildIndex(this.lblClienMCpc, 0);
            this.Controls.SetChildIndex(this.lblIdCLienteCpc, 0);
            this.Controls.SetChildIndex(this.lblArticuloCpc, 0);
            this.Controls.SetChildIndex(this.lblCantidad, 0);
            this.Controls.SetChildIndex(this.lblMonto, 0);
            this.Controls.SetChildIndex(this.lblPlazo, 0);
            this.Controls.SetChildIndex(this.lblFdPago, 0);
            this.Controls.SetChildIndex(this.txtArticuloCpc, 0);
            this.Controls.SetChildIndex(this.txtMontoCpc, 0);
            this.Controls.SetChildIndex(this.txtCantidaCpc, 0);
            this.Controls.SetChildIndex(this.cbPlzoCpc, 0);
            this.Controls.SetChildIndex(this.numPlazoCpc, 0);
            this.Controls.SetChildIndex(this.dtFechadpCpc, 0);
            this.Controls.SetChildIndex(this.txtClientCpc, 0);
            this.Controls.SetChildIndex(this.txtIDCpc, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlazoCpc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClienMCpc;
        private System.Windows.Forms.Label lblIdCLienteCpc;
        private System.Windows.Forms.DateTimePicker dtFechadpCpc;
        private System.Windows.Forms.NumericUpDown numPlazoCpc;
        private System.Windows.Forms.ComboBox cbPlzoCpc;
        private System.Windows.Forms.TextBox txtCantidaCpc;
        private System.Windows.Forms.TextBox txtMontoCpc;
        private System.Windows.Forms.TextBox txtArticuloCpc;
        private System.Windows.Forms.Label lblFdPago;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblArticuloCpc;
        private System.Windows.Forms.TextBox txtClientCpc;
        private System.Windows.Forms.TextBox txtIDCpc;
    }
}