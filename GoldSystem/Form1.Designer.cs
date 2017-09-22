using System.Windows.Forms;

namespace FormSingUp
{
    partial class GoldSystem
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_title2 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_list_estoque = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_item = new System.Windows.Forms.Button();
            this.btn_dash = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_home = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tab_add_produtos = new System.Windows.Forms.TabPage();
            this.tab_list_estoque = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tab_home.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label_title2);
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(178, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(30, 8, 8, 8);
            this.panel2.Size = new System.Drawing.Size(722, 37);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::GoldSystem.Properties.Resources.ic_dashboard_black_24dp_2x;
            this.pictureBox2.Location = new System.Drawing.Point(30, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
            // 
            // label_title2
            // 
            this.label_title2.AutoSize = true;
            this.label_title2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title2.ForeColor = System.Drawing.Color.Gray;
            this.label_title2.Location = new System.Drawing.Point(56, 7);
            this.label_title2.Name = "label_title2";
            this.label_title2.Size = new System.Drawing.Size(113, 22);
            this.label_title2.TabIndex = 0;
            this.label_title2.Text = "Dashboard";
            this.label_title2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.label_title2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.label_title2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.Location = new System.Drawing.Point(674, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMinimize.Size = new System.Drawing.Size(20, 21);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.LightCoral;
            this.btnClose.Location = new System.Drawing.Point(694, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(20, 21);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 500);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_list_estoque);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btn_add_item);
            this.panel5.Controls.Add(this.btn_dash);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 63);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(178, 437);
            this.panel5.TabIndex = 0;
            // 
            // btn_list_estoque
            // 
            this.btn_list_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_list_estoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_list_estoque.FlatAppearance.BorderSize = 0;
            this.btn_list_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_list_estoque.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_list_estoque.ForeColor = System.Drawing.Color.LightGray;
            this.btn_list_estoque.Location = new System.Drawing.Point(10, 86);
            this.btn_list_estoque.Name = "btn_list_estoque";
            this.btn_list_estoque.Size = new System.Drawing.Size(158, 38);
            this.btn_list_estoque.TabIndex = 5;
            this.btn_list_estoque.Text = "Listar Estoque";
            this.btn_list_estoque.UseVisualStyleBackColor = false;
            this.btn_list_estoque.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(10, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Created by: Isaac";
            // 
            // btn_add_item
            // 
            this.btn_add_item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_item.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_add_item.FlatAppearance.BorderSize = 0;
            this.btn_add_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_item.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_item.ForeColor = System.Drawing.Color.LightGray;
            this.btn_add_item.Location = new System.Drawing.Point(10, 48);
            this.btn_add_item.Name = "btn_add_item";
            this.btn_add_item.Size = new System.Drawing.Size(158, 38);
            this.btn_add_item.TabIndex = 2;
            this.btn_add_item.Text = "Adicionar Produtos";
            this.btn_add_item.UseVisualStyleBackColor = false;
            this.btn_add_item.Click += new System.EventHandler(this.btn_add_user_Click);
            // 
            // btn_dash
            // 
            this.btn_dash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dash.FlatAppearance.BorderSize = 0;
            this.btn_dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dash.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dash.ForeColor = System.Drawing.Color.LightGray;
            this.btn_dash.Location = new System.Drawing.Point(10, 10);
            this.btn_dash.Name = "btn_dash";
            this.btn_dash.Size = new System.Drawing.Size(158, 38);
            this.btn_dash.TabIndex = 1;
            this.btn_dash.Text = "Dashboard";
            this.btn_dash.UseVisualStyleBackColor = false;
            this.btn_dash.Click += new System.EventHandler(this.btn_dash_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(146)))), ((int)(((byte)(19)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label_title);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.panel4.Size = new System.Drawing.Size(178, 63);
            this.panel4.TabIndex = 0;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoldSystem.Properties.Resources.ic_shopping_cart_white_24dp_2x;
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(48, 24);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(104, 19);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Gold System";
            this.label_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.label_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.label_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.tabControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(178, 37);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(722, 463);
            this.panel3.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tab_home);
            this.tabControl.Controls.Add(this.tab_add_produtos);
            this.tabControl.Controls.Add(this.tab_list_estoque);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(120, 18);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(716, 457);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tab_home
            // 
            this.tab_home.BackColor = System.Drawing.Color.White;
            this.tab_home.Controls.Add(this.panel7);
            this.tab_home.Controls.Add(this.panel6);
            this.tab_home.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_home.Location = new System.Drawing.Point(4, 22);
            this.tab_home.Name = "tab_home";
            this.tab_home.Size = new System.Drawing.Size(708, 431);
            this.tab_home.TabIndex = 0;
            this.tab_home.Text = "Página Inicial";
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(403, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(305, 431);
            this.panel7.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.listBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(387, 431);
            this.panel6.TabIndex = 0;
            // 
            // tab_add_produtos
            // 
            this.tab_add_produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tab_add_produtos.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_add_produtos.Location = new System.Drawing.Point(4, 22);
            this.tab_add_produtos.Name = "tab_add_produtos";
            this.tab_add_produtos.Size = new System.Drawing.Size(708, 441);
            this.tab_add_produtos.TabIndex = 1;
            this.tab_add_produtos.Text = "Adicionar Produtos";
            // 
            // tab_list_estoque
            // 
            this.tab_list_estoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tab_list_estoque.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_list_estoque.Location = new System.Drawing.Point(4, 22);
            this.tab_list_estoque.Name = "tab_list_estoque";
            this.tab_list_estoque.Size = new System.Drawing.Size(708, 441);
            this.tab_list_estoque.TabIndex = 3;
            this.tab_list_estoque.Text = "Listas Estoques";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 10;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(387, 431);
            this.listBox1.TabIndex = 0;
            // 
            // GoldSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoldSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tab_home.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_dash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add_item;
        private System.Windows.Forms.Button btn_list_estoque;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_title2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_home;
        private System.Windows.Forms.TabPage tab_add_produtos;
        private System.Windows.Forms.TabPage tab_list_estoque;
        private Panel panel7;
        private Panel panel6;
        private ListBox listBox1;

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
    }
}

