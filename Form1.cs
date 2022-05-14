namespace BlackJack
{
    public partial class Form1 : Form
    {
        private int[] tableau_carte = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        private int somme_joueur = 0;
        private int somme_casino = 0;
        private int argent = 0;
        private int mise = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void carte_joueur_TextChanged(object sender, EventArgs e)
        {

        }

        private void carte_casino_TextChanged(object sender, EventArgs e)
        {

        }

        private void init_game_Click(object sender, EventArgs e)
        {        
            afficher_argent.Text = argent_depart.Text;
            argent = int.Parse(afficher_argent.Text);
            init_game.Enabled = false;
        }

        private void argent_depart_TextChanged(object sender, EventArgs e)
        {

        }

        private void distribue_Click(object sender, EventArgs e)
        {
            int i;

            Random alea = new Random();
            
            for(i = 0; i < 2; i++)
            {
                int carte_j = alea.Next(1, tableau_carte.Length + 1);
                carte_joueur.AppendText("" + carte_j + System.Environment.NewLine);
                somme_joueur = somme_joueur + carte_j;
                total_joueur.Text = "" + somme_joueur;
            }

            int carte_c = alea.Next(1, tableau_carte.Length + 1);
            carte_casino.AppendText("" + carte_c + System.Environment.NewLine);
            somme_casino = carte_c;
            total_casino.Text = "" + somme_casino;
            distribue.Enabled = false;
            
            if(radio_10.Checked == true)
            {
                argent = argent - 10;
                afficher_argent.Text = "" + argent;
                mise = 10;
            }

            if (radio_20.Checked == true)
            {
                argent = argent - 20;
                afficher_argent.Text = "" + argent;
                mise = 20;
            }

            if (radio_50.Checked == true)
            {
                argent = argent - 50;
                afficher_argent.Text = "" + argent;
                mise = 50;
            }

            if (radio_100.Checked == true)
            {
                argent = argent - 100;
                afficher_argent.Text = "" + argent;
                mise = 100;
            }

            if (radio_max.Checked == true)
            {
                mise = argent;
                argent = argent - argent;
                afficher_argent.Text = "" + argent;     
            }
        }

        private void tirer_carte_Click(object sender, EventArgs e)
        {
            Random alea = new Random();
            
            

            if (somme_joueur <= 21)
            {
                int carte_j = alea.Next(1, tableau_carte.Length + 1);
                carte_joueur.AppendText("" + carte_j + System.Environment.NewLine);
                somme_joueur = somme_joueur + carte_j;
                total_joueur.Text = "" + somme_joueur;
            }

            if (somme_joueur == 21)
            {
                tirer_carte.Enabled = false;
                MessageBox.Show("BlackJack !");
            }

            if (somme_joueur > 21)
            {
                tirer_carte.Enabled = false;
                reste.Enabled = false;
                MessageBox.Show("Joueur busted");
            }
        }

        private void reste_Click(object sender, EventArgs e)
        {
            Random alea = new Random();

            while(somme_casino < 17)
            {
                int carte_c = alea.Next(1, tableau_carte.Length + 1);
                carte_casino.AppendText("" + carte_c + System.Environment.NewLine);
                somme_casino = somme_casino + carte_c;
                total_casino.Text = "" + somme_casino;
            }

            if(somme_casino == somme_joueur)    // égalité
            {
                MessageBox.Show("Egalité");
                argent = argent + mise;
                afficher_argent.Text = "" + argent; 
            }

            if(somme_casino < somme_joueur) // casino < joueur, gagné
            {
                MessageBox.Show("Gagné");
                argent = argent + (mise * 2);
                afficher_argent.Text = "" + argent;
            }

            if(somme_casino > 21)   // casino bust, gagné
            {
                MessageBox.Show("Casino busted");
                argent = argent + (mise * 2);
                afficher_argent.Text = "" + argent;
            }            
        }
    }
}