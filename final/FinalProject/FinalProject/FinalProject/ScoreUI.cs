using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ScoreUI : Form
    {
        private Facade _fc;
        public ScoreUI(Facade fc)
        {
            InitializeComponent();
            _fc = fc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
