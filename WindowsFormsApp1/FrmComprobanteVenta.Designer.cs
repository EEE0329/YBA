
namespace WindowsFormsApp1
{
    partial class FrmComprobanteVenta
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
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFacturar = new FontAwesome.Sharp.IconButton();
            this.btnVerFactura = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnBorraLine = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnEliminaTod = new FontAwesome.Sharp.IconButton();
            this.txtVenTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpVenFecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVenNumFac = new System.Windows.Forms.TextBox();
            this.rtbVenNotas = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtVenDes = new System.Windows.Forms.TextBox();
            this.txtVenPre = new System.Windows.Forms.TextBox();
            this.txtVenCan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVenColor = new System.Windows.Forms.TextBox();
            this.btnConPro = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbVenPro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVenCedu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConCli = new FontAwesome.Sharp.IconButton();
            this.cbVenCli = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreRazon = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panelRNC = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.radioFiscal = new System.Windows.Forms.RadioButton();
            this.radioConsumo = new System.Windows.Forms.RadioButton();
            this.panelNCF = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelRNC.SuspendLayout();
            this.panelNCF.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Location = new System.Drawing.Point(1097, 652);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(612, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 68;
            this.label12.Text = "% ITBIS:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(681, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 22);
            this.textBox1.TabIndex = 67;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFacturar.BackColor = System.Drawing.Color.Transparent;
            this.btnFacturar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Untitled_design___Copy;
            this.btnFacturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacturar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFacturar.FlatAppearance.BorderSize = 0;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.White;
            this.btnFacturar.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnFacturar.IconColor = System.Drawing.Color.Red;
            this.btnFacturar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.Location = new System.Drawing.Point(800, 654);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(136, 57);
            this.btnFacturar.TabIndex = 66;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturar.UseVisualStyleBackColor = false;
            // 
            // btnVerFactura
            // 
            this.btnVerFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerFactura.BackColor = System.Drawing.Color.Transparent;
            this.btnVerFactura.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Untitled_design___Copy;
            this.btnVerFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerFactura.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVerFactura.FlatAppearance.BorderSize = 0;
            this.btnVerFactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerFactura.ForeColor = System.Drawing.Color.White;
            this.btnVerFactura.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVerFactura.IconColor = System.Drawing.Color.Red;
            this.btnVerFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerFactura.Location = new System.Drawing.Point(952, 654);
            this.btnVerFactura.Name = "btnVerFactura";
            this.btnVerFactura.Size = new System.Drawing.Size(126, 57);
            this.btnVerFactura.TabIndex = 54;
            this.btnVerFactura.Text = "Ver Factura";
            this.btnVerFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerFactura.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnBorraLine);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnEliminaTod);
            this.panel1.Location = new System.Drawing.Point(31, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 45);
            this.panel1.TabIndex = 65;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Untitled_design___Copy;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCancelar.IconColor = System.Drawing.Color.Red;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 30;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(198, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 33);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnBorraLine
            // 
            this.btnBorraLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorraLine.BackColor = System.Drawing.Color.Transparent;
            this.btnBorraLine.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Untitled_design___Copy;
            this.btnBorraLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorraLine.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBorraLine.FlatAppearance.BorderSize = 0;
            this.btnBorraLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorraLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorraLine.ForeColor = System.Drawing.Color.White;
            this.btnBorraLine.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnBorraLine.IconColor = System.Drawing.Color.Red;
            this.btnBorraLine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBorraLine.IconSize = 30;
            this.btnBorraLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorraLine.Location = new System.Drawing.Point(340, 6);
            this.btnBorraLine.Name = "btnBorraLine";
            this.btnBorraLine.Size = new System.Drawing.Size(147, 33);
            this.btnBorraLine.TabIndex = 22;
            this.btnBorraLine.Text = "Borrar Linea";
            this.btnBorraLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorraLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorraLine.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Untitled_design___Copy;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAgregar.IconColor = System.Drawing.Color.Red;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregar.IconSize = 30;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(63, 6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 33);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnEliminaTod
            // 
            this.btnEliminaTod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminaTod.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminaTod.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Untitled_design___Copy;
            this.btnEliminaTod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminaTod.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEliminaTod.FlatAppearance.BorderSize = 0;
            this.btnEliminaTod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminaTod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaTod.ForeColor = System.Drawing.Color.White;
            this.btnEliminaTod.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminaTod.IconColor = System.Drawing.Color.Red;
            this.btnEliminaTod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminaTod.IconSize = 30;
            this.btnEliminaTod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminaTod.Location = new System.Drawing.Point(520, 6);
            this.btnEliminaTod.Name = "btnEliminaTod";
            this.btnEliminaTod.Size = new System.Drawing.Size(147, 33);
            this.btnEliminaTod.TabIndex = 20;
            this.btnEliminaTod.Text = "Eliminar todo";
            this.btnEliminaTod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminaTod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminaTod.UseVisualStyleBackColor = false;
            // 
            // txtVenTotal
            // 
            this.txtVenTotal.Location = new System.Drawing.Point(98, 630);
            this.txtVenTotal.Name = "txtVenTotal";
            this.txtVenTotal.Size = new System.Drawing.Size(117, 22);
            this.txtVenTotal.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 627);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 25);
            this.label11.TabIndex = 63;
            this.label11.Text = "Total:";
            // 
            // dtpVenFecha
            // 
            this.dtpVenFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVenFecha.Location = new System.Drawing.Point(874, 87);
            this.dtpVenFecha.Name = "dtpVenFecha";
            this.dtpVenFecha.Size = new System.Drawing.Size(117, 22);
            this.dtpVenFecha.TabIndex = 62;
            this.dtpVenFecha.Value = new System.DateTime(2021, 2, 16, 16, 27, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(871, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 61;
            this.label10.Text = "No. Factura";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(874, 87);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(117, 22);
            this.textBox7.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(816, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "Notas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1013, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "No. Factura";
            // 
            // txtVenNumFac
            // 
            this.txtVenNumFac.Location = new System.Drawing.Point(1015, 87);
            this.txtVenNumFac.Name = "txtVenNumFac";
            this.txtVenNumFac.ReadOnly = true;
            this.txtVenNumFac.Size = new System.Drawing.Size(117, 22);
            this.txtVenNumFac.TabIndex = 57;
            // 
            // rtbVenNotas
            // 
            this.rtbVenNotas.Location = new System.Drawing.Point(820, 329);
            this.rtbVenNotas.Name = "rtbVenNotas";
            this.rtbVenNotas.Size = new System.Drawing.Size(388, 139);
            this.rtbVenNotas.TabIndex = 56;
            this.rtbVenNotas.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(741, 302);
            this.dataGridView1.TabIndex = 55;
            // 
            // txtVenDes
            // 
            this.txtVenDes.Location = new System.Drawing.Point(551, 223);
            this.txtVenDes.Name = "txtVenDes";
            this.txtVenDes.Size = new System.Drawing.Size(57, 22);
            this.txtVenDes.TabIndex = 53;
            // 
            // txtVenPre
            // 
            this.txtVenPre.Location = new System.Drawing.Point(333, 224);
            this.txtVenPre.Name = "txtVenPre";
            this.txtVenPre.Size = new System.Drawing.Size(104, 22);
            this.txtVenPre.TabIndex = 52;
            // 
            // txtVenCan
            // 
            this.txtVenCan.Location = new System.Drawing.Point(152, 223);
            this.txtVenCan.Name = "txtVenCan";
            this.txtVenCan.Size = new System.Drawing.Size(104, 22);
            this.txtVenCan.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Precio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(451, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "% Descuento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "Cantidad:";
            // 
            // txtVenColor
            // 
            this.txtVenColor.Location = new System.Drawing.Point(441, 185);
            this.txtVenColor.Name = "txtVenColor";
            this.txtVenColor.Size = new System.Drawing.Size(104, 22);
            this.txtVenColor.TabIndex = 47;
            // 
            // btnConPro
            // 
            this.btnConPro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConPro.BackColor = System.Drawing.Color.Transparent;
            this.btnConPro.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Untitled_design___Copy;
            this.btnConPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConPro.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConPro.FlatAppearance.BorderSize = 0;
            this.btnConPro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConPro.ForeColor = System.Drawing.Color.White;
            this.btnConPro.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnConPro.IconColor = System.Drawing.Color.Red;
            this.btnConPro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConPro.IconSize = 30;
            this.btnConPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConPro.Location = new System.Drawing.Point(569, 180);
            this.btnConPro.Name = "btnConPro";
            this.btnConPro.Size = new System.Drawing.Size(42, 30);
            this.btnConPro.TabIndex = 46;
            this.btnConPro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConPro.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(381, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "Color:";
            // 
            // cbVenPro
            // 
            this.cbVenPro.FormattingEnabled = true;
            this.cbVenPro.Location = new System.Drawing.Point(152, 185);
            this.cbVenPro.Name = "cbVenPro";
            this.cbVenPro.Size = new System.Drawing.Size(208, 24);
            this.cbVenPro.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Prodcuto:";
            // 
            // txtVenCedu
            // 
            this.txtVenCedu.Location = new System.Drawing.Point(191, 15);
            this.txtVenCedu.Name = "txtVenCedu";
            this.txtVenCedu.Size = new System.Drawing.Size(272, 22);
            this.txtVenCedu.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Cedula/RNC:";
            // 
            // btnConCli
            // 
            this.btnConCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConCli.BackColor = System.Drawing.Color.Transparent;
            this.btnConCli.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Untitled_design___Copy;
            this.btnConCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConCli.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConCli.FlatAppearance.BorderSize = 0;
            this.btnConCli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConCli.ForeColor = System.Drawing.Color.White;
            this.btnConCli.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnConCli.IconColor = System.Drawing.Color.Red;
            this.btnConCli.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConCli.IconSize = 30;
            this.btnConCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConCli.Location = new System.Drawing.Point(724, 12);
            this.btnConCli.Name = "btnConCli";
            this.btnConCli.Size = new System.Drawing.Size(42, 30);
            this.btnConCli.TabIndex = 40;
            this.btnConCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConCli.UseVisualStyleBackColor = false;
            // 
            // cbVenCli
            // 
            this.cbVenCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVenCli.FormattingEnabled = true;
            this.cbVenCli.Location = new System.Drawing.Point(214, 16);
            this.cbVenCli.Name = "cbVenCli";
            this.cbVenCli.Size = new System.Drawing.Size(504, 24);
            this.cbVenCli.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cliente:";
            // 
            // lblNombreRazon
            // 
            this.lblNombreRazon.AutoSize = true;
            this.lblNombreRazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRazon.Location = new System.Drawing.Point(3, 55);
            this.lblNombreRazon.Name = "lblNombreRazon";
            this.lblNombreRazon.Size = new System.Drawing.Size(181, 17);
            this.lblNombreRazon.TabIndex = 69;
            this.lblNombreRazon.Text = "Nombre o Razon social:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(190, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(504, 22);
            this.textBox2.TabIndex = 70;
            // 
            // panelRNC
            // 
            this.panelRNC.BackColor = System.Drawing.Color.DarkGray;
            this.panelRNC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRNC.Controls.Add(this.txtEstado);
            this.panelRNC.Controls.Add(this.label14);
            this.panelRNC.Controls.Add(this.iconButton1);
            this.panelRNC.Controls.Add(this.textBox2);
            this.panelRNC.Controls.Add(this.lblNombreRazon);
            this.panelRNC.Controls.Add(this.txtVenCedu);
            this.panelRNC.Controls.Add(this.label2);
            this.panelRNC.Location = new System.Drawing.Point(31, 54);
            this.panelRNC.Name = "panelRNC";
            this.panelRNC.Size = new System.Drawing.Size(741, 120);
            this.panelRNC.TabIndex = 71;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Untitled_design___Copy;
            this.iconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.Red;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(459, 11);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(42, 30);
            this.iconButton1.TabIndex = 74;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 24);
            this.comboBox1.TabIndex = 72;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 17);
            this.label13.TabIndex = 73;
            this.label13.Text = "NCF:";
            // 
            // radioFiscal
            // 
            this.radioFiscal.AutoSize = true;
            this.radioFiscal.Location = new System.Drawing.Point(91, 43);
            this.radioFiscal.Name = "radioFiscal";
            this.radioFiscal.Size = new System.Drawing.Size(65, 21);
            this.radioFiscal.TabIndex = 74;
            this.radioFiscal.TabStop = true;
            this.radioFiscal.Text = "Fiscal";
            this.radioFiscal.UseVisualStyleBackColor = true;
            // 
            // radioConsumo
            // 
            this.radioConsumo.AutoSize = true;
            this.radioConsumo.Location = new System.Drawing.Point(188, 43);
            this.radioConsumo.Name = "radioConsumo";
            this.radioConsumo.Size = new System.Drawing.Size(88, 21);
            this.radioConsumo.TabIndex = 75;
            this.radioConsumo.TabStop = true;
            this.radioConsumo.Text = "Consumo";
            this.radioConsumo.UseVisualStyleBackColor = true;
            // 
            // panelNCF
            // 
            this.panelNCF.BackColor = System.Drawing.Color.DarkGray;
            this.panelNCF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNCF.Controls.Add(this.radioConsumo);
            this.panelNCF.Controls.Add(this.radioFiscal);
            this.panelNCF.Controls.Add(this.label13);
            this.panelNCF.Controls.Add(this.comboBox1);
            this.panelNCF.Location = new System.Drawing.Point(835, 128);
            this.panelNCF.Name = "panelNCF";
            this.panelNCF.Size = new System.Drawing.Size(353, 78);
            this.panelNCF.TabIndex = 76;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(115, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 17);
            this.label14.TabIndex = 75;
            this.label14.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(190, 85);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(121, 22);
            this.txtEstado.TabIndex = 76;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 17);
            this.label15.TabIndex = 77;
            this.label15.Text = "Condiciones de pago";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(17, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(322, 24);
            this.comboBox2.TabIndex = 76;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(835, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 72);
            this.panel2.TabIndex = 78;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(117, 22);
            this.dateTimePicker1.TabIndex = 79;
            this.dateTimePicker1.Value = new System.DateTime(2021, 2, 16, 16, 27, 0, 0);
            this.dateTimePicker1.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(178, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(168, 17);
            this.label16.TabIndex = 79;
            this.label16.Text = "Fecha de Vencimiento";
            this.label16.Visible = false;
            // 
            // FrmComprobanteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1230, 716);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelNCF);
            this.Controls.Add(this.panelRNC);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnVerFactura);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtVenTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpVenFecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtVenNumFac);
            this.Controls.Add(this.rtbVenNotas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtVenDes);
            this.Controls.Add(this.txtVenPre);
            this.Controls.Add(this.txtVenCan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVenColor);
            this.Controls.Add(this.btnConPro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbVenPro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConCli);
            this.Controls.Add(this.cbVenCli);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmComprobanteVenta";
            this.Text = "FrmComprobanteVenta";
            this.Load += new System.EventHandler(this.FrmComprobanteVenta_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cbVenCli, 0);
            this.Controls.SetChildIndex(this.btnConCli, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cbVenPro, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btnConPro, 0);
            this.Controls.SetChildIndex(this.txtVenColor, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtVenCan, 0);
            this.Controls.SetChildIndex(this.txtVenPre, 0);
            this.Controls.SetChildIndex(this.txtVenDes, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.rtbVenNotas, 0);
            this.Controls.SetChildIndex(this.txtVenNumFac, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.textBox7, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.dtpVenFecha, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtVenTotal, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnVerFactura, 0);
            this.Controls.SetChildIndex(this.btnFacturar, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.panelRNC, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.panelNCF, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelRNC.ResumeLayout(false);
            this.panelRNC.PerformLayout();
            this.panelNCF.ResumeLayout(false);
            this.panelNCF.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        public FontAwesome.Sharp.IconButton btnFacturar;
        public FontAwesome.Sharp.IconButton btnVerFactura;
        private System.Windows.Forms.Panel panel1;
        public FontAwesome.Sharp.IconButton btnCancelar;
        public FontAwesome.Sharp.IconButton btnBorraLine;
        public FontAwesome.Sharp.IconButton btnAgregar;
        public FontAwesome.Sharp.IconButton btnEliminaTod;
        private System.Windows.Forms.TextBox txtVenTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpVenFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVenNumFac;
        private System.Windows.Forms.RichTextBox rtbVenNotas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtVenDes;
        private System.Windows.Forms.TextBox txtVenPre;
        private System.Windows.Forms.TextBox txtVenCan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVenColor;
        public FontAwesome.Sharp.IconButton btnConPro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbVenPro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVenCedu;
        private System.Windows.Forms.Label label2;
        public FontAwesome.Sharp.IconButton btnConCli;
        private System.Windows.Forms.ComboBox cbVenCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreRazon;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panelRNC;
        public FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioFiscal;
        private System.Windows.Forms.RadioButton radioConsumo;
        private System.Windows.Forms.Panel panelNCF;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}