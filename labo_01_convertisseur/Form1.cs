using System;
using System.Drawing;
using System.Windows.Forms;

namespace labo_01_convertisseur
{

    public partial class Form1 : Form
    {
        PortSerie ps;
        

        private Label[] septSegments = new Label[7];

       

        public Form1()
        {
            InitializeComponent();

            ps = new PortSerie();
            
        }

        private void nudDecimal_ValueChanged(object sender, EventArgs e)
        {
            if (radDec.Checked)
            {
                if (nudDecimal.Value > nudDecimal.Maximum)
                {
                    nudDecimal.Value = 0;
                }
                nudHex.Value = nudDecimal.Value;
                AffecteValeurBinaire((int)nudDecimal.Value);
                Affiche7Segments((int)nudDecimal.Value);
   
            }

            if (ps.Ouvert)
            {
                if (chkSerialPortSync.Checked)
                {
                    ps.EcrireLigne(nudDecimal.Value.ToString());

                }
            }
        }

        private void nudHex_ValueChanged(object sender, EventArgs e)
        {
            if (radHex.Checked)
            {
                nudDecimal.Value = nudHex.Value;
                AffecteValeurBinaire((int)nudDecimal.Value);
                Affiche7Segments((int)nudDecimal.Value);
            }
        }

        private void nudBin_ValueChanged(object sender, EventArgs e)
        {
            if (radBinaire.Checked)
            {
                binaire2Integer();
                Affiche7Segments((int)nudDecimal.Value);
            }
        }

        private void radDec_CheckedChanged(object sender, EventArgs e)
        {
            nudDecimal.Enabled = radDec.Checked;
        }

        private void radBinaire_CheckedChanged(object sender, EventArgs e)
        {
            nudBin00.Enabled = nudBin01.Enabled = nudBin02.Enabled = nudBin03.Enabled = radBinaire.Checked;
        }

        private void radHex_CheckedChanged(object sender, EventArgs e)
        {
            nudHex.Enabled = radHex.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            septSegments[0] = lblSeg_A;
            septSegments[1] = lblSeg_B;
            septSegments[2] = lblSeg_C;
            septSegments[3] = lblSeg_D;
            septSegments[4] = lblSeg_E;
            septSegments[5] = lblSeg_F;
            septSegments[6] = lblSeg_G;


            radDec.Checked = true;
            radBinaire.Checked = nudBin00.Enabled = nudBin01.Enabled = nudBin02.Enabled = nudBin03.Enabled = false;
            radHex.Checked = nudHex.Enabled = false;

            nudDecimal.Value = 0;


            cboSerialPortList.Items.Clear();
            String[] Ports = System.IO.Ports.SerialPort.GetPortNames();
            cboSerialPortList.Items.AddRange(Ports);

            btnSerialPortOpen.Enabled = cboSerialPortList.SelectedItem != null;
            setStateLabelColor();
        }

        private void AffecteValeurBinaire(int valeur)
        {
            nudBin00.Value = valeur % 2;
            valeur >>= 1;
            nudBin01.Value = valeur % 2;
            valeur >>= 1;
            nudBin02.Value = valeur % 2;
            valeur >>= 1;
            nudBin03.Value = valeur % 2;
        }

        private void binaire2Integer()
        {
            int result = (int)(nudBin00.Value + 2 * nudBin01.Value + 4 * nudBin02.Value + 8 * nudBin03.Value);
            nudDecimal.Value = nudHex.Value = result;
        }

        #region Section de code pour l'affichage du 7 segments

        // Table de vérité (valeur,A,B,C,D,E,F,G) pour l'affichage des segments
        private int[,] LS7447 = new int[,]
            { //0 1 2 3 4 5 6
                {1,1,1,1,1,1,0}, // 0
                {0,1,1,0,0,0,0}, // 1
                {1,1,0,1,1,0,1}, // 2
                {1,1,1,1,0,0,1}, // 3
    
                {0,1,1,0,0,1,1}, // 4
                {1,0,1,1,0,1,1}, // 5
                {1,0,1,1,1,1,1}, // 6
                {1,1,1,0,0,0,0}, // 7

                {1,1,1,1,1,1,1}, // 8
                {1,1,1,0,0,1,1}, // 9
                {1,1,1,0,1,1,1}, // A
                {0,0,1,1,1,1,1}, // B

                {1,0,0,1,1,1,0}, // C
                {0,1,1,1,1,0,1}, // D
                {1,0,0,1,1,1,1}, // E
                {1,0,0,0,1,1,1}  // F
            };
        

        /// <summary>
        /// Affiche la valeur sur le pseudo 7 segments représenté par 7 Libellés
        /// </summary>
        /// <param name="valeur">La valeur à afficher (0-15).</param>
        private void Affiche7Segments(int valeur)
        {
            for (int i = 0; i < 7; ++i)
                if (LS7447[valeur, i] == 1)
                    septSegments[i].BackColor = Color.Red;
                else
                    septSegments[i].BackColor = Color.LightGray;
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            nudDecimal.Value = (nudDecimal.Value + 1) % (nudDecimal.Maximum + 1);
        }

        private void chkCounter_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = chkCounter.Checked;
        }

        private void btnSerialPortOpen_Click(object sender, EventArgs e)
        {
            if (cboSerialPortList.SelectedItem != null)
            {
                ps.Ouvrir(cboSerialPortList.SelectedItem.ToString());
                setStateLabelColor();
            }
        }

        private void btnSerialPortClose_Click(object sender, EventArgs e)
        {
            ps.Fermer();
            setStateLabelColor();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSerialPortList.SelectedItem == null)
            {
                btnSerialPortOpen.Enabled = false;              
            } else
            {
                btnSerialPortOpen.Enabled = true;
            }

            ps.Fermer();
            setStateLabelColor();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ps.Ouvert)
            {
                ps.Fermer();
                setStateLabelColor();
            }
        }

        private void setStateLabelColor()
        {
            if (ps.Ouvert)
            {
                lblState.BackColor = Color.Green;
            } else
            {
                lblState.BackColor = Color.LightGray;
            }
        }
    }
}
