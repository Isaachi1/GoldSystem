using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FormSingUp
{
    public partial class GoldSystem : Form 
    {

        private bool _dragging = false;
        private Point _start_point = new Point(0,0);

        public GoldSystem()
        {
            InitializeComponent();
            this.showTab(tab_home);
            this.tabControl.ItemSize = new Size(0, 1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void mouse_Up(object sender, MouseEventArgs e)
        {
            this._dragging = false;
        }

        public void mouse_Move(object sender, MouseEventArgs e)
        {
            if (this._dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        public void mouse_Down(object sender, MouseEventArgs e)
        {
            this._dragging = false;
            this._start_point = new Point(e.X, e.Y);
        }

        public void showTab(TabPage tab)
        {
            this.tabControl.TabPages.Clear();
            if (tabControl.TabPages.Contains(tab))
            {
                tabControl.TabPages.Remove(tab);
            }
            else
            {
                tabControl.TabPages.Add(tab);
            }
        }
        
        private void btn_dash_Click(object sender, EventArgs e)
        {
            showTab(tab_home);
            label_title2.Text = "Dashboard";
        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            showTab(tab_add_produtos);
            label_title2.Text = "Cadastrar Usuários";
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            showTab(tab_list_estoque);
            label_title2.Text = "Configurações";
        }
    }
}
