using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schach2
{
    public partial class Spielbrett : Form
    {
        public static List<Spielfeld>[] Felder = new List<Spielfeld>[8]; // spielbrett
        public static Spielfeld MarkiertesFeld { get; set; } 
        public static int Zug { get; set; } = 1; // Wer ist am Zug? 1 = weiß, 0 = schwarz
        public static bool FirstTime { get; set; } // erstes mal spielbrett laden


        public static void FeldRefresh()
        {
            for (int i = 0; i < 8; i++)
            {
                foreach (var feld in Felder[i])
                {
                    if (feld.Figur != null)
                    {
                        feld.Text = feld.Figur.Darstellung;
                        if (feld.Figur.Name=='P'&&feld.Figur.Farbe==0)
                        {
                            feld.Font = new Font(feld.Font.Name, 16F);
                        }
                        else
                        {
                            feld.Font = new Font(feld.Font.Name, 24F);
                        }
                    }
                    else
                    {
                        feld.Text = null;
                    }
                    
                }
            }
            FelderUnmarkieren();
        }
        public static List<Spielfeld> GetFelderMitFiguren()
        {
            List<Spielfeld> output = new List<Spielfeld>();
            for (int i = 0; i < 8; i++)
            {
                foreach (var feld in Felder[i])
                {
                    if (feld.Figur!=null)
                    {
                        output.Add(feld);
                    }
                    
                }
            }
            return output;
        }
        public static void FeldMarkieren(Spielfeld feld)
        {
            MarkiertesFeld = feld;
            MarkiertesFeld.FlatAppearance.BorderColor = Color.Blue;
            MarkiertesFeld.FlatAppearance.BorderSize = 1;
        }
        public static void FelderUnmarkieren()
        { 
            for (int i = 0; i < 8; i++)
            {
                foreach (var fe in Felder[i])
                {
                    fe.FlatAppearance.BorderSize = 0;
                }
            }
        }
        public Spielbrett()
        {
            InitializeComponent();

            FelderInitialisieren();           

            SuspendLayout();

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 500);

            FigurenAnzeigen();

            Name = "spielbrettForm";
            Text = "Spielbrett";
            ResumeLayout(false);

        }
        // leere felder erstellen
        private void FelderInitialisieren()
        {
            FirstTime = true;
            for (int zeile = 0; zeile < 8; zeile++)
            {
                
                Felder[zeile] = new List<Spielfeld>();
                for (int spalte = 0; spalte < 8; spalte++)
                {
                    Felder[zeile].Add(new Spielfeld(spalte, zeile));
                }

            }
            FirstTime = false;
        }
        // felder mit figuren befüllen (am anfang)
        private void FigurenAnzeigen()
        {
            List<char> figurenChars = new List<char>();
            figurenChars.Add('r');
            figurenChars.Add('n');
            figurenChars.Add('b');
            figurenChars.Add('q');
            figurenChars.Add('k');
            figurenChars.Add('b');
            figurenChars.Add('n');
            figurenChars.Add('r');

            
            for (int i = 0; i < 8; i++)
            {
                foreach (var feld in Felder[i])
                {
                    Controls.Add(feld);

                    if (i==1||i==6)
                    {
                        feld.Figur = i == 6  ? new Figur('p', 1) : new Figur('p', 0);
                        feld.Text = feld.Figur.Darstellung;
                        feld.Font = i == 6 ?  new Font(feld.Font.Name, 24F): new Font(feld.Font.Name, 16F);
                    }
                }
                if (i == 0)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Felder[i].ElementAt(j).Figur = new Figur(figurenChars.ElementAt(j), 0);
                        Felder[i].ElementAt(j).Text = Felder[i].ElementAt(j).Figur.Darstellung;
                        Felder[i].ElementAt(j).Font = new Font(Felder[i].ElementAt(j).Font.Name, 24F);
                    }
                }
                if (i == 7)
                {                   
                    for (int j = 0; j < 8; j++)
                    {                        
                        Felder[i].ElementAt(j).Figur = new Figur(figurenChars.ElementAt(j), 1);
                        Felder[i].ElementAt(j).Text = Felder[i].ElementAt(j).Figur.Darstellung;
                        Felder[i].ElementAt(j).Font = new Font(Felder[i].ElementAt(j).Font.Name, 24F);
                    }
                }
                
            }
            // felder zum event machen
            for (int i = 0; i < 8; i++)
            {
                foreach (var feld in Felder[i])
                {
                    feld.Click += feld.Feld_Click;
                }
            }

        }
        
        
        
    }
}
