using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA191120
{
    public partial class FrmMain : Form
    {
        static Random rnd = new Random();
        //gomb mátrix megosztott változóban
        Button[,] matrix;
        public FrmMain()
        {
            InitializeComponent();
            //Form-ra beállítom, hogy méreteződjön a tartalomhoz
            AutoSize = true;

        }

        private void btnDoIt_Click(object sender, EventArgs e)
        {
            //mátrixot inicializálom akkorára, ami a textoxokba van írva
            matrix = new Button[int.Parse(tbO.Text), int.Parse(tbS.Text)];

            //törlök a formról minden szart:
            this.Controls.Clear();

            //bejárom a mátroxot:
            for (int o = 0; o < matrix.GetLength(0); o++)
            {
                for (int s = 0; s < matrix.GetLength(1); s++)
                {
                    //íme az "egyszerűbb" szintax több tulajdonság beállítására
                    //figyelj rá, hogy VESSZŐ és nem PONTOSVESSZŐ van a tulajdonságok közt
                    matrix[o, s] = new Button()
                    {
                        Width = 100,
                        Height = 100,
                        Location = new Point(o * 100, s * 100),
                        //3 véletlen szám a színének RGB kódja:
                        BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)),
                        Text = $"s: {s + 1}, o: {o + 1}"
                    };

                    //hozzá kell adni a control-listához (elhagytam a this-t)
                    Controls.Add(matrix[o, s]);

                    //létrehuk neki egy eseménykezelőt
                    // += begépelése után tabulátor, és legenerálja a fejrészt
                    matrix[o, s].Click += GombKattintas;
                }
            }
        }

        private void GombKattintas(object sender, EventArgs e)
        {
            //ezt kitöröltem:
            //throw new NotImplementedException();

            //a paraméterben küldött 'sender' azt a gombot tárolja, amire rákattintottam

            //mivel ez 'csak' object "vissza kell alakítani" gombá, hogy tudjam használni:
            //mivel a selector (a pont) prió művelet, ezért kell zárójelbe tenni
            if ((sender as Button).BackColor == Color.Blue)
            {
                (sender as Button).BackColor = Color.Red;
            }
            else
            {
                (sender as Button).BackColor = Color.Blue;
            }
        }
    }
}
