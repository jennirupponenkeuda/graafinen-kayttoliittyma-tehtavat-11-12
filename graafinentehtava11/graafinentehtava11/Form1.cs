namespace graafinentehtava11
{
    public partial class NopanheittoF : Form
    {
        public NopanheittoF()
        {
            InitializeComponent();
        }

        private void HeitaBT_Click(object sender, EventArgs e)
        {
            PiirraNoppa(Noppa01PB); //kutsutaan ensimmäistä noppaa 1 
            PiirraNoppa(Noppa02PB);// kutsutaan toista noppaa 2 eli Noppa02PB 
        }

        private void PiirraNoppa(PictureBox NoppaBox)
        {
            Random satunnainen = new Random(); // saadaan satunnaisuus
            int noppa = satunnainen.Next(1, 7); // arpoo luvun 1 ja 6 välillä
            switch (noppa) // Saadaan eri tapaukset, eli lukua ns. vastaava kuva
            {
                case 1:
                    NoppaBox.Image = Properties.Resources.dice01; // Kun nopan arvo 1, kutsutaan kuvaa 1 (tässä tapauksessa dice01 -nimistä kuvaa) 
                    break;
                case 2:
                    NoppaBox.Image = Properties.Resources.dice02;
                    break;
                case 3:
                    NoppaBox.Image = Properties.Resources.dice03;
                    break;
                case 4:
                    NoppaBox.Image = Properties.Resources.dice04;
                    break;
                case 5:
                    NoppaBox.Image = Properties.Resources.dice05;
                    break;
                case 6:
                    NoppaBox.Image = Properties.Resources.dice06;
                    break;
            }
        }
    }
 }

