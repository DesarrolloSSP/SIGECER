using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sigecer
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //
        }

        private void TimerFadeLogin_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.080;
            if (Opacity == 0.0)
            {
                TimerFadeLogin.Stop();
                this.Hide();
                //Form inicio = new Principal();
                //inicio.Show();
                Login login = new Login();
                login.Show();
            }
        }
    }
}
