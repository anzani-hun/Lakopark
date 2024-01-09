using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lakopark
{
    public partial class Form_Lakopark : Form
    {
        List<Lakopark> lakoparkok = new List<Lakopark>();
        Adatbazis db = new Adatbazis();
        
        int aktualisParkIndex = 0;

        public Form_Lakopark()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // adatok betöltése adatbázisból //
            lakoparkok = db.parkadatokBetoltese();
            parkAdatokMegjelenitese();
        }

        private void parkAdatokMegjelenitese()
        {
            this.Text = $"{lakoparkok[aktualisParkIndex].LakoparkNeve} lakópark adatai";
            pictureBox_Nevado.Image = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}{lakoparkok[aktualisParkIndex].LakoparkNeve}.jpg");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}