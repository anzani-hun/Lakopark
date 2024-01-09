using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lakopark
{
    public partial class Form_Lakopark : Form
    {

        List<Lakopark> lakoparkok = new List<Lakopark>();
        Adatbazis db = new Adatbazis();

        public Form_Lakopark()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // adatok betöltése adatbázisból //
            lakoparkok = db.parkadatokBetoltese();
        }
    }
}
