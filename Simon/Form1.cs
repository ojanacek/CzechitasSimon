using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Simon
{
    public partial class Form1 : Form
    {
        // pripravime si co budeme potrebovat, tyto promenne musi byt takto definovany
        // ve tride, aby byly dostupne ze vsech metod ve tride (zde Form1)
        // - u prvnich tri znam hodnotu rovnou - prazdne listy a nova instance Random,
        // a ostatni dve budu znat pozdeji, necham zatim prazdne
        List<Button> vzor = new List<Button>();
        List<Button> opakovani = new List<Button>();
        Random generatorNahodnychCisel = new Random();
        int delkaVzoru;
        Button aktualniBarvaVzoru;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Zacit_Click(object sender, EventArgs e)
        {
            // Value je typu "desetinne cislo" (decimal), prevedeme na cele (int) a ulozime
            delkaVzoru = (int)pocitadloDelkyVzoru.Value;
            // zkontrolujeme hodnotu
            if (delkaVzoru <= 0)
            {
                MessageBox.Show("Takhle si asi nezahrajeme :-( Delka vzoru musi byt vetsi nez 0.");
                return;
            }

            // promazeme listy, aby slo hrat vice her po sobe
            vzor.Clear();
            opakovani.Clear();
            // spustime generovani vzoru - vykonavani metody timer_Tick
            timer.Start();
            button_Zacit.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // pokud uz se nam vygeneroval vzor dlouhy stejne jako pozadovana delka
            if (vzor.Count == delkaVzoru)
            {
                // zastavime vykonavani teto metody a tedy generovani vzoru
                timer.Stop();
                MessageBox.Show("A ted mi ukaz, kolik si toho pamatujes.");
                button_Vyhodnotit.Enabled = true;
                return;
            }
            // a pokud ne, tak vybereme nahodnou barvu a ulozime do listu
            Button nahodnaBarva = VyberNahodnouBarvu();
            vzor.Add(nahodnaBarva);
            // abychom mohli i z jine metody nastavit vlastnost Text aktualniho tlacitka,
            // ulozime si ho do promenne, ktera je dostupna v cele tride Form1
            aktualniBarvaVzoru = nahodnaBarva;
            aktualniBarvaVzoru.Text = "TADY";
            // spustime pomocny timer, ktery tikne drive, nez tento tikne znova,
            // aby zase odmazal text z aktualniho tlacitka; bez tohoto by se mohlo vybrat nekolikrat
            // po sobe stejne tlacitko a neslo by poznat, kolikrat se vybralo
            pomocnyTimer.Start();
        }

        private Button VyberNahodnouBarvu()
        {
            int nahodneCislo = generatorNahodnychCisel.Next(1, 5); // od 1 vcetne do 5 bez
            switch (nahodneCislo)
            {
                case 1:
                    return button_Cervena;
                case 2:
                    return button_Modra;
                case 3:
                    return button_Zelena;
                case 4:
                    return button_Zluta;
                default: // je slusnost pridat pripad pro ostatni hodnoty, i kdyz vime, ze se to nestane
                    // nemuselo by to tu byt v pripade, ze na konci metody vratime neco, tj. nesplnil se zadny case
                    return button_Zluta;
            }
        }

        private void button_Cervena_Click(object sender, EventArgs e)
        {
            opakovani.Add(button_Cervena);
        }

        private void button_Zelena_Click(object sender, EventArgs e)
        {
            opakovani.Add(button_Zelena);
        }

        private void button_Modra_Click(object sender, EventArgs e)
        {
            opakovani.Add(button_Modra);
        }

        private void button_Zluta_Click(object sender, EventArgs e)
        {
            opakovani.Add(button_Zluta);
        }

        private void button_Vyhodnotit_Click(object sender, EventArgs e)
        {
            // porovname dalku vzoru s poctem kliknuti hrace
            if (opakovani.Count != vzor.Count)
            {
                MessageBox.Show("Naklikala jsi spatny pocet barev. Vyhral jsem.");
                button_Zacit.Enabled = true;
                button_Vyhodnotit.Enabled = false;
                // uz nechceme, aby se dale vyhodnocovalo
                return;
            }

            // muze zde byt i "i < opakovani.Count" nebo "i < delkaVzoru", vsude je stejna hodnota
            for (int i = 0; i < vzor.Count; i++)
            {
                // zde pomoci indexovani do listu (vyber prvky na i. pozici), ktere podle pravidel zacina od 0,
                // vybereme barvu ze vzoru a barvu od hrace, ktere maji stejne poradi a porovname
                Button barvaPocitace = vzor[i];
                Button barvaHrace = opakovani[i];
                if (barvaPocitace != barvaHrace)
                {
                    MessageBox.Show(i + ". zadana barva v poradi je spatne. Vyhral jsem.");
                    button_Zacit.Enabled = true;
                    button_Vyhodnotit.Enabled = false;
                    // uz nechceme, aby se dale vyhodnocovalo, to je moje volba
                    // mohli bychom zkontrolovat vse a na konci hraci vypsat pocet chyb
                    return;
                }
            }

            // for cyklus dojel do konce, tedy ani jednou se nesplnila jeho vnitrni if podminka,
            // coz znamena, ze je vse spravne
            MessageBox.Show("Gratuluji, porazila jsi me :-) Co to takhle zkusit s delsim vzorem?");
            button_Zacit.Enabled = true;
            button_Vyhodnotit.Enabled = false;
        }

        private void pomocnyTimer_Tick(object sender, EventArgs e)
        {
            // smazu text na tzv. "prazdny string"
            aktualniBarvaVzoru.Text = "";
            // a vypnu pomocny timer, abych jej mohl zaes zapnout az mi znova tikne hlavni timer
            pomocnyTimer.Stop();
        }
    }
}
