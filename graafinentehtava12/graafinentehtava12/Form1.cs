using System.ComponentModel;

namespace graafinentehtava12
{
    public partial class VastausLomakeForm : Form
    {
        int laskuri = 0; //laskurilla luetaan 10 kertaa
        int oikein = 0; //Kun saadaan oikein, saadaan verrattua meid‰n taulua oikein-tauluun
        string[] oikeatvastaukset = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" }; // oikein-taulukon vastaukset t‰ss‰
        string[] vastaukset = new string[10]; //vastauksia odotetaan 10
        public VastausLomakeForm()
        {
            InitializeComponent();// Alla m‰‰ritell‰‰n painikkeille uudet tapahtumak‰sittelij‰t
            VastausARB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged); //kun napautetaan a-painiketta, luodaan uusi RB
            VastausBRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            VastausCRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            VastausDRB.CheckedChanged -= new EventHandler(radiobutton_CheckedChanged);

        }

        private void VastausLomakeForm_Load(object sender, EventArgs e)
        {

        }

        private void radiobutton_CheckedChanged(object sender, EventArgs e) //Yksityinen, eli ei p‰‰se muualta k‰siksi + ei palauta mit‰‰n
        {
            if (sender is RadioButton && laskuri < 10) // tapaus, jossa tulee RB ja laskuri on alle 10
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text; //ensimm‰iseen, eli numeroon 0, tuleva vastaus tallennetaan laskuriin
                KysymysLB.Text = "Vastaus " + (laskuri) + ". kysymykseen: "; //Eli kerrotaan monenteenko kysymykseen t‰m‰ vastaus on
                laskuri++;
            }
            else
            {
                VastausLB.Text = ""; //Tyhjennet‰‰n vastaus
                VastausARB.Enabled = false; //Estet‰‰n vastaaminen, sill‰ on jo vastattu 10 kertaa
                VastausBRB.Enabled = false;
                VastausCRB.Enabled = false;
                VastausDRB.Enabled = false;
                for (int j = 0; j < 10; j++)
                {
                    if (vastaukset[j] == oikeatvastaukset[j]) //verrataan j:t‰ annettua vastausta oikeatvastauksen -taulukkoon
                    {
                        oikein++; // jos j.annettu vastaus on oikein eli vastaa oikeatvastaukset -taulukkoa, lis‰t‰‰n oikein -laskuriin 1
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli " + oikein;
                VastausLB.Visible = true;
            }
            Tyhjaavastaus();

        }
        private void Tyhjaavastaus() // vastaukset tulee tyhj‰t‰
        {
            if (VastausARB.Checked == true)
            {
                VastausARB.Checked = false;
                laskuri--; // laskuria v‰hent‰‰
            }
            if (VastausBRB.Checked == true)
            {
                VastausBRB.Checked = false;
                laskuri--;
            }
            if (VastausCRB.Checked == true)
            {
                VastausCRB.Checked = false;
                laskuri--;
            }
            if (VastausDRB.Checked == true)
            {
                VastausDRB.Checked = false;
                laskuri--;
            }
        }
    }
}



