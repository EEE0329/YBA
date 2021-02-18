
namespace WindowsFormsApp1
{
    partial class FrmVentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbVenCli = new System.Windows.Forms.ComboBox();
            this.btnConCli = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVenCedu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVenPro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConPro = new FontAwesome.Sharp.IconButton();
            this.txtVenColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVenCan = new System.Windows.Forms.TextBox();
            this.txtVenPre = new System.Windows.Forms.TextBox();
            this.txtVenDes = new System.Windows.Forms.TextBox();
            this.btnEliminaTod = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnBorraLine = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rtbVenNotas = new System.Windows.Forms.RichTextBox();
            this.txtVenNumFac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpVenFecha = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVenTotal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVerFactura = new FontAwesome.Sharp.IconButton();
            this.btnFacturar = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Location = new System.Drawing.Point(1118, 658);
            this.btnSalir.Size = new System.Drawing.Size(100, 51);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            // 
            // cbVenCli
            // 
            this.cbVenCli.FormattingEnabled = true;
            this.cbVenCli.Location = new System.Drawing.Point(126, 13);
            this.cbVenCli.Name = "cbVenCli";
            this.cbVenCli.Size = new System.Drawing.Size(504, 24);
            this.cbVenCli.TabIndex = 2;
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
            this.btnConCli.Location = new System.Drawing.Point(633, 9);
            this.btnConCli.Name = "btnConCli";
            this.btnConCli.Size = new System.Drawing.Size(42, 30);
            this.btnConCli.TabIndex = 6;
            this.btnConCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConCli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConCli.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cedula/RNC:";
            // 
            // txtVenCedu
            // 
            this.txtVenCedu.Location = new System.Drawing.Point(127, 50);
            this.txtVenCedu.Name = "txtVenCedu";
            this.txtVenCedu.Size = new System.Drawing.Size(272, 22);
            this.txtVenCedu.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prodcuto:";
            // 
            // cbVenPro
            // 
            this.cbVenPro.FormattingEnabled = true;
            this.cbVenPro.Location = new System.Drawing.Point(125, 16);
            this.cbVenPro.Name = "cbVenPro";
            this.cbVenPro.Size = new System.Drawing.Size(208, 24);
            this.cbVenPro.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Color:";
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
            this.btnConPro.Location = new System.Drawing.Point(522, 11);
            this.btnConPro.Name = "btnConPro";
            this.btnConPro.Size = new System.Drawing.Size(42, 30);
            this.btnConPro.TabIndex = 12;
            this.btnConPro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConPro.UseVisualStyleBackColor = false;
            // 
            // txtVenColor
            // 
            this.txtVenColor.Location = new System.Drawing.Point(414, 16);
            this.txtVenColor.Name = "txtVenColor";
            this.txtVenColor.Size = new System.Drawing.Size(104, 22);
            this.txtVenColor.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(424, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "% Descuento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(245, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Precio:";
            // 
            // txtVenCan
            // 
            this.txtVenCan.Location = new System.Drawing.Point(125, 54);
            this.txtVenCan.Name = "txtVenCan";
            this.txtVenCan.Size = new System.Drawing.Size(104, 22);
            this.txtVenCan.TabIndex = 17;
            // 
            // txtVenPre
            // 
            this.txtVenPre.Location = new System.Drawing.Point(348, 177);
            this.txtVenPre.Name = "txtVenPre";
            this.txtVenPre.Size = new System.Drawing.Size(104, 22);
            this.txtVenPre.TabIndex = 18;
            // 
            // txtVenDes
            // 
            this.txtVenDes.Location = new System.Drawing.Point(524, 54);
            this.txtVenDes.Name = "txtVenDes";
            this.txtVenDes.Size = new System.Drawing.Size(57, 22);
            this.txtVenDes.TabIndex = 19;
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
            this.btnEliminaTod.Location = new System.Drawing.Point(530, 6);
            this.btnEliminaTod.Name = "btnEliminaTod";
            this.btnEliminaTod.Size = new System.Drawing.Size(147, 33);
            this.btnEliminaTod.TabIndex = 20;
            this.btnEliminaTod.Text = "Eliminar todo";
            this.btnEliminaTod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminaTod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminaTod.UseVisualStyleBackColor = false;
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
            this.btnAgregar.Location = new System.Drawing.Point(78, 6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 33);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
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
            this.btnBorraLine.Location = new System.Drawing.Point(354, 6);
            this.btnBorraLine.Name = "btnBorraLine";
            this.btnBorraLine.Size = new System.Drawing.Size(147, 33);
            this.btnBorraLine.TabIndex = 22;
            this.btnBorraLine.Text = "Borrar Linea";
            this.btnBorraLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorraLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorraLine.UseVisualStyleBackColor = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(214, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 33);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(741, 384);
            this.dataGridView1.TabIndex = 24;
            // 
            // rtbVenNotas
            // 
            this.rtbVenNotas.Location = new System.Drawing.Point(812, 178);
            this.rtbVenNotas.Name = "rtbVenNotas";
            this.rtbVenNotas.Size = new System.Drawing.Size(388, 139);
            this.rtbVenNotas.TabIndex = 25;
            this.rtbVenNotas.Text = "";
            // 
            // txtVenNumFac
            // 
            this.txtVenNumFac.Location = new System.Drawing.Point(207, 39);
            this.txtVenNumFac.Name = "txtVenNumFac";
            this.txtVenNumFac.Size = new System.Drawing.Size(117, 22);
            this.txtVenNumFac.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(205, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "No. Factura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(808, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Notas:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(66, 39);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(117, 22);
            this.textBox7.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(62, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "No. Factura";
            // 
            // dtpVenFecha
            // 
            this.dtpVenFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVenFecha.Location = new System.Drawing.Point(66, 39);
            this.dtpVenFecha.Name = "dtpVenFecha";
            this.dtpVenFecha.Size = new System.Drawing.Size(117, 22);
            this.dtpVenFecha.TabIndex = 31;
            this.dtpVenFecha.Value = new System.DateTime(2021, 2, 16, 16, 27, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 658);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 25);
            this.label11.TabIndex = 32;
            this.label11.Text = "Total:";
            // 
            // txtVenTotal
            // 
            this.txtVenTotal.Location = new System.Drawing.Point(113, 661);
            this.txtVenTotal.Name = "txtVenTotal";
            this.txtVenTotal.Size = new System.Drawing.Size(117, 22);
            this.txtVenTotal.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnBorraLine);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnEliminaTod);
            this.panel1.Location = new System.Drawing.Point(46, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 45);
            this.panel1.TabIndex = 34;
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
            this.btnVerFactura.Location = new System.Drawing.Point(976, 658);
            this.btnVerFactura.Name = "btnVerFactura";
            this.btnVerFactura.Size = new System.Drawing.Size(126, 51);
            this.btnVerFactura.TabIndex = 24;
            this.btnVerFactura.Text = "Ver Factura";
            this.btnVerFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerFactura.UseVisualStyleBackColor = false;
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
            this.btnFacturar.Location = new System.Drawing.Point(824, 658);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(136, 51);
            this.btnFacturar.TabIndex = 35;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(696, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 22);
            this.textBox1.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(585, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "% ITBIS:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtVenCedu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnConCli);
            this.panel2.Controls.Add(this.cbVenCli);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(46, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 83);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtVenDes);
            this.panel3.Controls.Add(this.txtVenCan);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtVenColor);
            this.panel3.Controls.Add(this.btnConPro);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cbVenPro);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(46, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(741, 87);
            this.panel3.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dtpVenFecha);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.textBox7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtVenNumFac);
            this.panel4.Location = new System.Drawing.Point(812, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 79);
            this.panel4.TabIndex = 40;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1230, 716);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnVerFactura);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtVenTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rtbVenNotas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtVenPre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.Controls.SetChildIndex(this.txtVenPre, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.rtbVenNotas, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtVenTotal, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnVerFactura, 0);
            this.Controls.SetChildIndex(this.btnFacturar, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVenCli;
        public FontAwesome.Sharp.IconButton btnConCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVenCedu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVenPro;
        private System.Windows.Forms.Label label4;
        public FontAwesome.Sharp.IconButton btnConPro;
        private System.Windows.Forms.TextBox txtVenColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVenCan;
        private System.Windows.Forms.TextBox txtVenPre;
        private System.Windows.Forms.TextBox txtVenDes;
        public FontAwesome.Sharp.IconButton btnEliminaTod;
        public FontAwesome.Sharp.IconButton btnAgregar;
        public FontAwesome.Sharp.IconButton btnBorraLine;
        public FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox rtbVenNotas;
        private System.Windows.Forms.TextBox txtVenNumFac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpVenFecha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVenTotal;
        private System.Windows.Forms.Panel panel1;
        public FontAwesome.Sharp.IconButton btnVerFactura;
        public FontAwesome.Sharp.IconButton btnFacturar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}