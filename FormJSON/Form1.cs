using System;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormJSON
{
    public partial class Form1 : Form
    {
        int listNr = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void btnTest_Click(object sender, EventArgs e)
        {
            Quizfrage q = new Quizfrage
            {
                Frage = "Hauptstadt von Italien?",
                AntwortListe = new List<string> { "Berlin", "Rom", "Madrid" },
                RichtigeAntwort = 1
            };
            //Quizfrage m = JsonConvert.DeserializeObject<Quizfrage>(json);
            string json = JsonConvert.SerializeObject(q);
            File.WriteAllText("Quiz.JSON", json);
        }

        List<Quizfrage> quizfrageList = new List<Quizfrage>();


        private void Form1_Load(object sender, EventArgs e)
        {
            //String line= File.ReadLines("Quiz.JSON");

            foreach (string line in File.ReadLines(@"Quiz.JSON"))
            {
                Quizfrage quizfrage = JsonConvert.DeserializeObject<Quizfrage>(line);
                quizfrageList.Add(quizfrage);
            }


            listNr = 1;
            lblFrage.Text = quizfrageList[listNr].Frage;
            btnAntwort1.Text = quizfrageList[listNr].AntwortListe[0];
            btnAntwort2.Text = quizfrageList[listNr].AntwortListe[1];
            btnAntwort3.Text = quizfrageList[listNr].AntwortListe[2];

        }

        private void btnAntwort1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int antw = Int32.Parse((string)btn.Tag);
            if (antw == quizfrageList[listNr].RichtigeAntwort)
            {
                MessageBox.Show("Richtige Antwort! \nCongratulation!!!");
            }
            else
            {
                MessageBox.Show("Falsche Antwort!");
            }
        }

    }
}
