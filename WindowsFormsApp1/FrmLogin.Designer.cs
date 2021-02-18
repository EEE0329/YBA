
namespace WindowsFormsApp1
{
    partial class FrmLogin
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ckRecontra = new System.Windows.Forms.CheckBox();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.btnPass = new FontAwesome.Sharp.IconButton();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.emma_logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 367);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(382, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "USUARIO";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.DimGray;
            this.textBox2.Location = new System.Drawing.Point(382, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(315, 25);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "CONTRASEÑA";
            // 
            // ckRecontra
            // 
            this.ckRecontra.AutoSize = true;
            this.ckRecontra.BackColor = System.Drawing.Color.Transparent;
            this.ckRecontra.ForeColor = System.Drawing.Color.White;
            this.ckRecontra.Location = new System.Drawing.Point(447, 228);
            this.ckRecontra.Name = "ckRecontra";
            this.ckRecontra.Size = new System.Drawing.Size(166, 21);
            this.ckRecontra.TabIndex = 3;
            this.ckRecontra.Text = "Recordar Contraseña";
            this.ckRecontra.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUser.IconColor = System.Drawing.Color.Red;
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUser.IconSize = 40;
            this.btnUser.Location = new System.Drawing.Point(336, 94);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(40, 46);
            this.btnUser.TabIndex = 4;
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.Transparent;
            this.btnPass.FlatAppearance.BorderSize = 0;
            this.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPass.ForeColor = System.Drawing.Color.Transparent;
            this.btnPass.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnPass.IconColor = System.Drawing.Color.Red;
            this.btnPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPass.IconSize = 40;
            this.btnPass.Location = new System.Drawing.Point(336, 173);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(40, 40);
            this.btnPass.TabIndex = 5;
            this.btnPass.UseVisualStyleBackColor = false;
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.DimGray;
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcceder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.Location = new System.Drawing.Point(382, 282);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(315, 37);
            this.btnAcceder.TabIndex = 6;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(467, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "LOGIN";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.depositphotos_42940873_stock_photo_dark_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.ckRecontra);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox ckRecontra;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnPass;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.Label label1;
    }
}