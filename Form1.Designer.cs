using System.Drawing;

namespace GBM
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.ToT = new System.Windows.Forms.Button();
            this.Apartados = new System.Windows.Forms.Button();
            this.Portofer = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Cbox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMinus = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.Titulo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.PnlNav);
            this.panel1.Controls.Add(this.ToT);
            this.panel1.Controls.Add(this.Apartados);
            this.panel1.Controls.Add(this.Portofer);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 651);
            this.panel1.TabIndex = 0;
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 198);
            this.PnlNav.Margin = new System.Windows.Forms.Padding(2);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(2, 81);
            this.PnlNav.TabIndex = 3;
            // 
            // ToT
            // 
            this.ToT.AutoSize = true;
            this.ToT.FlatAppearance.BorderSize = 0;
            this.ToT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToT.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ToT.Image = global::GBM.Properties.Resources.diagram;
            this.ToT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToT.Location = new System.Drawing.Point(0, 284);
            this.ToT.Margin = new System.Windows.Forms.Padding(2);
            this.ToT.Name = "ToT";
            this.ToT.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.ToT.Size = new System.Drawing.Size(189, 43);
            this.ToT.TabIndex = 4;
            this.ToT.Text = "ToT";
            this.ToT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ToT.UseVisualStyleBackColor = true;
            this.ToT.Click += new System.EventHandler(this.Btn_Click);
            this.ToT.Leave += new System.EventHandler(this.Btn_Leave);
            // 
            // Apartados
            // 
            this.Apartados.AutoSize = true;
            this.Apartados.FlatAppearance.BorderSize = 0;
            this.Apartados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apartados.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apartados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Apartados.Image = global::GBM.Properties.Resources.recusado;
            this.Apartados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Apartados.Location = new System.Drawing.Point(0, 236);
            this.Apartados.Margin = new System.Windows.Forms.Padding(2);
            this.Apartados.Name = "Apartados";
            this.Apartados.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Apartados.Size = new System.Drawing.Size(189, 43);
            this.Apartados.TabIndex = 3;
            this.Apartados.Text = "Apartados";
            this.Apartados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Apartados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Apartados.UseVisualStyleBackColor = true;
            this.Apartados.Click += new System.EventHandler(this.Btn_Click);
            this.Apartados.Leave += new System.EventHandler(this.Btn_Leave);
            // 
            // Portofer
            // 
            this.Portofer.AutoSize = true;
            this.Portofer.FlatAppearance.BorderSize = 0;
            this.Portofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Portofer.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Portofer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Portofer.Image = ((System.Drawing.Image)(resources.GetObject("Portofer.Image")));
            this.Portofer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Portofer.Location = new System.Drawing.Point(0, 188);
            this.Portofer.Margin = new System.Windows.Forms.Padding(2);
            this.Portofer.Name = "Portofer";
            this.Portofer.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Portofer.Size = new System.Drawing.Size(189, 43);
            this.Portofer.TabIndex = 2;
            this.Portofer.Text = "Portofer";
            this.Portofer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Portofer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Portofer.UseVisualStyleBackColor = true;
            this.Portofer.Click += new System.EventHandler(this.Btn_Click);
            this.Portofer.Leave += new System.EventHandler(this.Btn_Leave);
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Home.Image = global::GBM.Properties.Resources.home;
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Home.Location = new System.Drawing.Point(0, 141);
            this.Home.Margin = new System.Windows.Forms.Padding(2);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.Home.Size = new System.Drawing.Size(189, 43);
            this.Home.TabIndex = 1;
            this.Home.Text = "Visão Geral";
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Btn_Click);
            this.Home.Leave += new System.EventHandler(this.Btn_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Cbox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 141);
            this.panel2.TabIndex = 0;
            // 
            // Cbox1
            // 
            this.Cbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Cbox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox1.ForeColor = System.Drawing.Color.White;
            this.Cbox1.FormattingEnabled = true;
            this.Cbox1.Items.AddRange(new object[] {
            "Total",
            "01x07",
            "07x13",
            "13x19",
            "19x01"});
            this.Cbox1.Location = new System.Drawing.Point(47, 97);
            this.Cbox1.Margin = new System.Windows.Forms.Padding(0);
            this.Cbox1.Name = "Cbox1";
            this.Cbox1.Size = new System.Drawing.Size(92, 21);
            this.Cbox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(68, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TGG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GBM.Properties.Resources.transporte_ferroviario;
            this.pictureBox1.Location = new System.Drawing.Point(68, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.panel3.Controls.Add(this.btnMinus);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.Titulo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(191, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 35);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // btnMinus
            // 
            this.btnMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinus.IconColor = System.Drawing.Color.White;
            this.btnMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinus.IconSize = 15;
            this.btnMinus.Location = new System.Drawing.Point(737, 7);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(26, 23);
            this.btnMinus.TabIndex = 3;
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 15;
            this.btnClose.Location = new System.Drawing.Point(769, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(6, 7);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(103, 20);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Visão Geral";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(63)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(191, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(807, 7);
            this.panel4.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(191, 42);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(807, 609);
            this.panelDesktop.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(998, 651);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox Cbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button ToT;
        private System.Windows.Forms.Button Apartados;
        private System.Windows.Forms.Button Portofer;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Titulo;
        private FontAwesome.Sharp.IconButton btnMinus;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

