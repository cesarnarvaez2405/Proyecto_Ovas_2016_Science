using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace Proyecto_OVAS_Matematicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Transition t = new Transition(new TransitionType_EaseInEaseOut(200));
            t.add(pictureBox1, "Left", 1550);
            t.run();
            Hide();

           menu men = new menu();
            men.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Hide();

            menu men = new menu();
            men.Show();
        }
    }
}
