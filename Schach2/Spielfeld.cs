using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schach2
{
    public class Spielfeld : Button
    {
        public int Spalte { get; set; }
        public int Zeile { get; set; }
        public Figur Figur { get; set; } = null;


        public bool ContainsFigur(Spielfeld feld)
        {
            foreach (Spielfeld f in Spielbrett.GetFelderMitFiguren())
            {
                if (feld.Spalte == f.Spalte && feld.Zeile == f.Zeile)
                {
                    return true;
                }
            }
            return false;
        }


        //gibt eine Liste von Feldern zurück, auf die sich eine Figur bewegen kann
        public List<Spielfeld> MoeglicheBewegungen(Figur figur)
        {

            int spalte = Spielbrett.MarkiertesFeld.Spalte;
            int zeile = Spielbrett.MarkiertesFeld.Zeile;

            if (figur.Name == 'R')
            {
                bool selfcheck1 = true;
                bool selfcheck2 = true;
                bool selfcheck3 = true;
                bool selfcheck4 = true;
                List<Spielfeld> rook = new List<Spielfeld>();


                for (int i = 1; i < 8; i++)
                {
                    if (spalte + i < 8 && selfcheck1)
                    {
                        if (ContainsFigur(new Spielfeld(spalte + i, zeile)))
                        {
                            rook.Add(new Spielfeld(spalte + i, zeile));
                            selfcheck1 = false;
                        }
                        else
                        {
                            rook.Add(new Spielfeld(spalte + i, zeile));
                        }
                     
                    }
                    if (spalte - i >= 0 && selfcheck2)
                    {
                        if (ContainsFigur(new Spielfeld(spalte - i, zeile)))
                        {
                            rook.Add(new Spielfeld(spalte - i, zeile));
                            selfcheck2 = false;
                        }
                        else
                        {
                            rook.Add(new Spielfeld(spalte - i, zeile));
                        }
                        
                    }
                    if (zeile + i < 8 && selfcheck3)
                    {
                        if (ContainsFigur(new Spielfeld(spalte, zeile + i)))
                        {
                            rook.Add(new Spielfeld(spalte, zeile + i));
                            selfcheck3 = false;
                        }
                        else
                        {
                            rook.Add(new Spielfeld(spalte, zeile + i));
                        }
                        
                    }
                    if (zeile - i >= 0 && selfcheck4)
                    {
                        if (ContainsFigur(new Spielfeld(spalte, zeile - i)))
                        {
                            rook.Add(new Spielfeld(spalte, zeile - i));
                            selfcheck4 = false;
                        }
                        else
                        {
                            rook.Add(new Spielfeld(spalte, zeile - i));
                        }
                        
                    }    

                }
             
                return rook;               
            }
            if (figur.Name == 'N')
            {
                List<Spielfeld> springer = new List<Spielfeld>();
                springer.Add(new Spielfeld(spalte - 1, zeile - 2));
                springer.Add(new Spielfeld(spalte - 1, zeile + 2));
                springer.Add(new Spielfeld(spalte + 1, zeile - 2));
                springer.Add(new Spielfeld(spalte + 1, zeile + 2));
                springer.Add(new Spielfeld(spalte - 2, zeile - 1));
                springer.Add(new Spielfeld(spalte - 2, zeile + 1));
                springer.Add(new Spielfeld(spalte + 2, zeile - 1));
                springer.Add(new Spielfeld(spalte + 2, zeile + 1));


                return springer; 
            }
            if (figur.Name == 'B')
            {

                bool selfcheck1 = true;
                bool selfcheck2 = true;
                bool selfcheck3 = true;
                bool selfcheck4 = true;
                List<Spielfeld> laufer = new List<Spielfeld>();


                for (int i = 1; i < 8; i++)
                {
                    if (spalte + i < 8  && selfcheck1)
                    {
                        if (ContainsFigur(new Spielfeld(spalte + i, zeile + i)))
                        {
                            laufer.Add(new Spielfeld(spalte + i, zeile + i));
                            selfcheck1 = false;
                        }
                        else
                        {
                            laufer.Add(new Spielfeld(spalte + i, zeile + i));
                        }

                    }
                    if (spalte + i < 8 && selfcheck2)
                    {
                        if (ContainsFigur(new Spielfeld(spalte + i, zeile - i)))
                        {
                            laufer.Add(new Spielfeld(spalte + i, zeile - i));
                            selfcheck2 = false;
                        }
                        else
                        {
                            laufer.Add(new Spielfeld(spalte + i, zeile - i));
                        }

                    }
                    if (zeile + i < 8 && selfcheck3)
                    {
                        if (ContainsFigur(new Spielfeld(spalte - i, zeile + i)))
                        {
                            laufer.Add(new Spielfeld(spalte - i, zeile + i));
                            selfcheck3 = false;
                        }
                        else
                        {
                            laufer.Add(new Spielfeld(spalte - i, zeile + i));
                        }

                    }
                    if (zeile - i >= 0 && selfcheck4)
                    {
                        if (ContainsFigur(new Spielfeld(spalte - i, zeile - i)))
                        {
                            laufer.Add(new Spielfeld(spalte - i, zeile - i));
                            selfcheck4 = false;
                        }
                        else
                        {
                            laufer.Add(new Spielfeld(spalte - i, zeile - i));
                        }
                    }
                }

                return laufer;
            }
            if (figur.Name == 'K')
            {
                List<Spielfeld> king = new List<Spielfeld>();
                king.Add(new Spielfeld(spalte + 1, zeile + 1));
                king.Add(new Spielfeld(spalte + 1, zeile - 1));
                king.Add(new Spielfeld(spalte - 1, zeile + 1));
                king.Add(new Spielfeld(spalte - 1, zeile - 1));
                king.Add(new Spielfeld(spalte + 1, zeile));
                king.Add(new Spielfeld(spalte, zeile + 1));
                king.Add(new Spielfeld(spalte - 1, zeile));
                king.Add(new Spielfeld(spalte, zeile - 1));
                

                return king;

            }
            if (figur.Name == 'Q')
            {

                bool selfcheck1 = true;
                bool selfcheck2 = true;
                bool selfcheck3 = true;
                bool selfcheck4 = true;
                bool selfcheck5 = true;
                bool selfcheck6 = true;
                bool selfcheck7 = true;
                bool selfcheck8 = true;
                List<Spielfeld> queen = new List<Spielfeld>();


                for (int i = 1; i < 8; i++)
                {
                    if (spalte + i < 8 && selfcheck1)
                    {
                        if (ContainsFigur(new Spielfeld(spalte + i, zeile)))
                        {
                            queen.Add(new Spielfeld(spalte + i, zeile));
                            selfcheck1 = false;
                        }
                        else
                        {
                            queen.Add(new Spielfeld(spalte + i, zeile));
                        }

                    }
                    if (spalte - i >= 0 && selfcheck2)
                    {
                        if (ContainsFigur(new Spielfeld(spalte - i, zeile)))
                        {
                            queen.Add(new Spielfeld(spalte - i, zeile));
                            selfcheck2 = false;
                        }
                        else
                        {
                            queen.Add(new Spielfeld(spalte - i, zeile));
                        }

                    }
                    if (zeile + i < 8 && selfcheck3)
                    {
                        if (ContainsFigur(new Spielfeld(spalte, zeile + i)))
                        {
                            queen.Add(new Spielfeld(spalte, zeile + i));
                            selfcheck3 = false;
                        }
                        else
                        {
                            queen.Add(new Spielfeld(spalte, zeile + i));
                        }

                    }
                    if (zeile - i >= 0 && selfcheck4)
                    {
                        if (ContainsFigur(new Spielfeld(spalte, zeile - i)))
                        {
                            queen.Add(new Spielfeld(spalte, zeile - i));
                            selfcheck4 = false;
                        }
                        else
                        {
                            queen.Add(new Spielfeld(spalte, zeile - i));
                        }

                    }
                    if (spalte + i < 8 && selfcheck5)
                    {
                        if (ContainsFigur(new Spielfeld(spalte + i, zeile + i)))
                        {
                            queen.Add(new Spielfeld(spalte + i, zeile + i));
                            selfcheck5 = false;
                        }
                        else
                        {
                            queen.Add(new Spielfeld(spalte + i, zeile + i));
                        }

                    }
                    if (spalte + i <8 && selfcheck6)
                    {
                        if (ContainsFigur(new Spielfeld(spalte + i, zeile - i)))
                        {
                            queen.Add(new Spielfeld(spalte + i, zeile - i));
                            selfcheck6 = false;
                        }
                        else
                        {
                            queen.Add(new Spielfeld(spalte + i, zeile - i));
                        }

                    }
                    if (zeile + i < 8 && selfcheck7)
                    {
                        if (ContainsFigur(new Spielfeld(spalte - i, zeile + i)))
                        {
                            queen.Add(new Spielfeld(spalte - i, zeile + i));
                            selfcheck7 = false;
                        }
                        else
                        {
                            queen.Add(new Spielfeld(spalte - i, zeile + i));
                        }

                    }
                    if (zeile - i >= 0 && selfcheck8)
                    {
                        if (ContainsFigur(new Spielfeld(spalte - i, zeile - i)))
                        {
                            queen.Add(new Spielfeld(spalte - i, zeile - i));
                            selfcheck8 = false;
                        }
                        else
                        {
                            queen.Add(new Spielfeld(spalte - i, zeile - i));
                        }

                    }

                }
                return queen;
            }
            if (figur.Name == 'P'&&figur.Farbe == 1)
            {
                List<Spielfeld> pawnW = new List<Spielfeld>();
                if (zeile==6)
                {
                    pawnW.Add(new Spielfeld(spalte, zeile - 2));
                }
                if (!ContainsFigur(new Spielfeld(spalte, zeile - 1)))
                {
                    pawnW.Add(new Spielfeld(spalte, zeile - 1));
                }
                if (ContainsFigur(new Spielfeld(spalte - 1, zeile - 1)))
                {
                    pawnW.Add(new Spielfeld(spalte - 1, zeile - 1));
                }
                if (ContainsFigur(new Spielfeld(spalte + 1, zeile - 1)))
                {
                    pawnW.Add(new Spielfeld(spalte + 1, zeile - 1));
                }
                return pawnW;
            }
            if (figur.Name == 'P' && figur.Farbe == 0)
            {
                List<Spielfeld> pawnB = new List<Spielfeld>();
                if (zeile == 1)
                {
                    pawnB.Add(new Spielfeld(spalte, zeile + 2));
                }
                if (!ContainsFigur(new Spielfeld(spalte, zeile + 1)))
                {
                    pawnB.Add(new Spielfeld(spalte , zeile + 1));
                }
                if (ContainsFigur(new Spielfeld(spalte + 1, zeile + 1)))
                {
                    pawnB.Add(new Spielfeld(spalte + 1, zeile + 1));
                }
                if (ContainsFigur(new Spielfeld(spalte - 1, zeile + 1)))
                {
                    pawnB.Add(new Spielfeld(spalte - 1, zeile + 1));
                }

                return pawnB;
            }
            return null;
        }

        public Spielfeld(int spalte, int zeile) 
        {
            Spalte = spalte;
            Zeile = zeile;
            if (Spielbrett.FirstTime)
            {
                BrettLaden(spalte, zeile);
            }
           
        }
        public void BrettLaden(int spalte, int zeile)
        {
            Location = new Point((spalte + 1) * 50, (zeile + 1) * 50);
            Name = $"{spalte}{zeile}Feld";
            Size = new Size(50, 50);
            UseVisualStyleBackColor = true;
            BackColor = spalte % 2 == zeile % 2 ? Color.White : Color.SandyBrown;
            TabStop = false;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
        }
        // TODO - nach check züge einschränken, checkmate, könig nicht erlauben ins schach zu laufen
        public void Feld_Click(object sender, EventArgs e)
        {
            
            // Auswahl wiederrufen, wenn das geklickte Feld erneut geklickt wird
            if (this == Spielbrett.MarkiertesFeld)
            {
                Spielbrett.FelderUnmarkieren();
                return;
            }
            // Nichts tun, wenn als erstes Feld ein Feld ohne Figur ausgewählt wird
            if (Figur==null&&Spielbrett.MarkiertesFeld==null)
            {
                return;
            }
            // Figur auf ein Feld bewegen, auf dem keine Figur steht
            if (Figur==null&&Spielbrett.MarkiertesFeld.Figur!=null)
            {
                
                //Rochrade weiß klein
                if (Spielbrett.MarkiertesFeld.Figur.Name == 'K'
                    && Spielbrett.MarkiertesFeld.Figur.Moves == 0
                    && Spielbrett.Zug == 1
                    && Spielbrett.Felder[7].ElementAt(7).Figur.Name == 'R'
                    && Spielbrett.Felder[7].ElementAt(7).Figur.Moves == 0
                    && Zeile == 7 && Spalte == 6
                    && Spielbrett.Felder[7].ElementAt(6).Figur == null
                    && Spielbrett.Felder[7].ElementAt(5).Figur == null)
                {
                    Figur = Spielbrett.MarkiertesFeld.Figur;
                    Spielbrett.MarkiertesFeld.Figur = null;
                    Figur.Moves++;

                    Spielbrett.Felder[7].ElementAt(5).Figur = Spielbrett.Felder[7].ElementAt(7).Figur;
                    Spielbrett.Felder[7].ElementAt(7).Figur = null;
                    Spielbrett.Felder[7].ElementAt(5).Figur.Moves++;

                    Spielbrett.Zug = Spielbrett.Zug == 1 ? 0 : 1;
                    Spielbrett.FeldRefresh();
                    return;
                }
                //Rochrade schwarz klein
                if (Spielbrett.MarkiertesFeld.Figur.Name == 'K'
                    && Spielbrett.MarkiertesFeld.Figur.Moves == 0
                    && Spielbrett.Zug == 0
                    && Spielbrett.Felder[0].ElementAt(7).Figur.Name == 'R'
                    && Spielbrett.Felder[0].ElementAt(7).Figur.Moves == 0
                    && Zeile == 0 && Spalte == 6
                    && Spielbrett.Felder[0].ElementAt(6).Figur == null
                    && Spielbrett.Felder[0].ElementAt(5).Figur == null)
                {
                    Figur = Spielbrett.MarkiertesFeld.Figur;
                    Spielbrett.MarkiertesFeld.Figur = null;
                    Figur.Moves++;

                    Spielbrett.Felder[0].ElementAt(5).Figur = Spielbrett.Felder[0].ElementAt(7).Figur;
                    Spielbrett.Felder[0].ElementAt(7).Figur = null;
                    Spielbrett.Felder[0].ElementAt(5).Figur.Moves++;

                    Spielbrett.Zug = Spielbrett.Zug == 1 ? 0 : 1;
                    Spielbrett.FeldRefresh();
                    return;
                }
                //Rochrade weiß groß
                if (Spielbrett.MarkiertesFeld.Figur.Name == 'K'
                    && Spielbrett.MarkiertesFeld.Figur.Moves == 0
                    && Spielbrett.Zug == 1
                    && Spielbrett.Felder[7].ElementAt(0).Figur.Name == 'R'
                    && Spielbrett.Felder[7].ElementAt(0).Figur.Moves == 0
                    && Zeile == 7 && Spalte == 2
                    && Spielbrett.Felder[7].ElementAt(1).Figur == null
                    && Spielbrett.Felder[7].ElementAt(2).Figur == null
                    && Spielbrett.Felder[7].ElementAt(3).Figur == null)
                {
                    Figur = Spielbrett.MarkiertesFeld.Figur;
                    Spielbrett.MarkiertesFeld.Figur = null;
                    Figur.Moves++;

                    Spielbrett.Felder[7].ElementAt(3).Figur = Spielbrett.Felder[7].ElementAt(0).Figur;
                    Spielbrett.Felder[7].ElementAt(0).Figur = null;
                    Spielbrett.Felder[7].ElementAt(3).Figur.Moves++;

                    Spielbrett.Zug = Spielbrett.Zug == 1 ? 0 : 1;
                    Spielbrett.FeldRefresh();
                    return;
                }
                //Rochrade schwarz groß
                if (Spielbrett.MarkiertesFeld.Figur.Name == 'K'
                    && Spielbrett.MarkiertesFeld.Figur.Moves == 0
                    && Spielbrett.Zug == 0
                    && Spielbrett.Felder[0].ElementAt(0).Figur.Name == 'R'
                    && Spielbrett.Felder[0].ElementAt(0).Figur.Moves == 0
                    && Zeile == 0 && Spalte == 2
                    && Spielbrett.Felder[0].ElementAt(1).Figur == null
                    && Spielbrett.Felder[0].ElementAt(2).Figur == null
                    && Spielbrett.Felder[0].ElementAt(3).Figur == null)
                {
                    Figur = Spielbrett.MarkiertesFeld.Figur;
                    Spielbrett.MarkiertesFeld.Figur = null;
                    Figur.Moves++;

                    Spielbrett.Felder[0].ElementAt(3).Figur = Spielbrett.Felder[0].ElementAt(0).Figur;
                    Spielbrett.Felder[0].ElementAt(0).Figur = null;
                    Spielbrett.Felder[0].ElementAt(3).Figur.Moves++;

                    Spielbrett.Zug = Spielbrett.Zug == 1 ? 0 : 1;
                    Spielbrett.FeldRefresh();
                    return;
                }
                //en-passant weiß nach links
                if (Spielbrett.MarkiertesFeld.Figur.Name == 'P'
                    && Spielbrett.Zug == 1
                    && Spielbrett.MarkiertesFeld.Zeile == 3
                    && Spielbrett.MarkiertesFeld.Spalte - 1 >= 0
                    && Spielbrett.Felder[3].ElementAt(Spielbrett.MarkiertesFeld.Spalte - 1).Figur != null
                    && Spielbrett.Felder[3].ElementAt(Spielbrett.MarkiertesFeld.Spalte - 1).Figur.Name == 'P'
                    && Spielbrett.Felder[3].ElementAt(Spielbrett.MarkiertesFeld.Spalte - 1).Figur.EnPassentAble
                    && Spalte == Spielbrett.MarkiertesFeld.Spalte - 1
                    && Zeile == 2)            
                {
                    Figur = Spielbrett.MarkiertesFeld.Figur;
                    Spielbrett.MarkiertesFeld.Figur = null;
                    Spielbrett.Felder[3].ElementAt(Spielbrett.MarkiertesFeld.Spalte - 1).Figur = null;
                    Figur.Moves++;
                    Spielbrett.Zug = Spielbrett.Zug == 1 ? 0 : 1;
                    Spielbrett.FeldRefresh();
                    return;
                }
                //en-passant weiß nach rechts
                if (Spielbrett.MarkiertesFeld.Figur.Name == 'P'
                    && Spielbrett.Zug == 1
                    && Spielbrett.MarkiertesFeld.Zeile == 3
                    && Spielbrett.MarkiertesFeld.Spalte + 1 < 8
                    && Spielbrett.Felder[3].ElementAt(Spielbrett.MarkiertesFeld.Spalte + 1).Figur != null
                    && Spielbrett.Felder[3].ElementAt(Spielbrett.MarkiertesFeld.Spalte + 1).Figur.Name == 'P'
                    && Spielbrett.Felder[3].ElementAt(Spielbrett.MarkiertesFeld.Spalte + 1).Figur.EnPassentAble 
                    && Spalte == Spielbrett.MarkiertesFeld.Spalte + 1
                    && Zeile == 2)
                {
                    Figur = Spielbrett.MarkiertesFeld.Figur;
                    Spielbrett.MarkiertesFeld.Figur = null;
                    Spielbrett.Felder[3].ElementAt(Spielbrett.MarkiertesFeld.Spalte + 1).Figur = null;
                    Figur.Moves++;
                    Spielbrett.Zug = Spielbrett.Zug == 1 ? 0 : 1;
                    Spielbrett.FeldRefresh();
                    return;
                }
                //en-passant schwarz nach links
                if (Spielbrett.MarkiertesFeld.Figur.Name == 'P'
                    && Spielbrett.Zug == 0
                    && Spielbrett.MarkiertesFeld.Zeile == 4
                    && Spielbrett.MarkiertesFeld.Spalte + 1 < 8
                    && Spielbrett.Felder[4].ElementAt(Spielbrett.MarkiertesFeld.Spalte + 1).Figur != null
                    && Spielbrett.Felder[4].ElementAt(Spielbrett.MarkiertesFeld.Spalte + 1).Figur.Name == 'P'
                    && Spielbrett.Felder[4].ElementAt(Spielbrett.MarkiertesFeld.Spalte + 1).Figur.EnPassentAble
                    && Spalte == Spielbrett.MarkiertesFeld.Spalte + 1
                    && Zeile == 5)
                {
                    Figur = Spielbrett.MarkiertesFeld.Figur;
                    Spielbrett.MarkiertesFeld.Figur = null;
                    Spielbrett.Felder[4].ElementAt(Spielbrett.MarkiertesFeld.Spalte + 1).Figur = null;
                    Figur.Moves++;
                    Spielbrett.Zug = Spielbrett.Zug == 1 ? 0 : 1;
                    Spielbrett.FeldRefresh();
                    return;
                }
                //en-passant schwarz nach rechts
                if (Spielbrett.MarkiertesFeld.Figur.Name == 'P'
                    && Spielbrett.Zug == 0
                    && Spielbrett.MarkiertesFeld.Zeile == 4
                    && Spielbrett.MarkiertesFeld.Spalte - 1 >= 0
                    && Spielbrett.Felder[4].ElementAt(Spielbrett.MarkiertesFeld.Spalte - 1).Figur != null
                    && Spielbrett.Felder[4].ElementAt(Spielbrett.MarkiertesFeld.Spalte - 1).Figur.Name == 'P'
                    && Spielbrett.Felder[4].ElementAt(Spielbrett.MarkiertesFeld.Spalte - 1).Figur.EnPassentAble
                    && Spalte == Spielbrett.MarkiertesFeld.Spalte - 1
                    && Zeile == 5)
                {
                    Figur = Spielbrett.MarkiertesFeld.Figur;
                    Spielbrett.MarkiertesFeld.Figur = null;
                    Spielbrett.Felder[4].ElementAt(Spielbrett.MarkiertesFeld.Spalte - 1).Figur = null;
                    Figur.Moves++;
                    Spielbrett.Zug = Spielbrett.Zug == 1 ? 0 : 1;
                    Spielbrett.FeldRefresh();
                    return;
                }
                //promotion weiß
                if (Spielbrett.MarkiertesFeld.Figur.Name == 'P'
                    && Spielbrett.Zug == 1
                    && Spielbrett.MarkiertesFeld.Zeile == 1
                    && Spielbrett.MarkiertesFeld.Spalte == Spalte 
                    && Zeile == 0)
                {
                    using (var form = new PromotionForm(Spielbrett.Zug))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            Figur = form.GetNewFigur();
                            Spielbrett.MarkiertesFeld.Figur = null;
                            Figur.Moves++;
                            Spielbrett.Zug = Spielbrett.Zug == 1 ? 0 : 1;
                            Spielbrett.FeldRefresh();

                        }
                    }


                    return;
                }
                //promotion schwarz
                if (Spielbrett.MarkiertesFeld.Figur.Name == 'P'
                    && Spielbrett.Zug == 0
                    && Spielbrett.MarkiertesFeld.Zeile == 6
                    && Spielbrett.MarkiertesFeld.Spalte == Spalte
                    && Zeile == 7)
                {
                    using (var form = new PromotionForm(Spielbrett.Zug))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            Figur = form.GetNewFigur();
                            Spielbrett.MarkiertesFeld.Figur = null;
                            Figur.Moves++;
                            Spielbrett.Zug = Spielbrett.Zug == 1 ? 0 : 1;
                            Spielbrett.FeldRefresh();
                        }
                    }

                    return;
                }


                foreach (var feld in MoeglicheBewegungen(Spielbrett.MarkiertesFeld.Figur))
                {
                    
                    if (Zeile == feld.Zeile && Spalte == feld.Spalte)
                    {
                        Figur = Spielbrett.MarkiertesFeld.Figur;
                        Spielbrett.MarkiertesFeld.Figur = null;
                        Figur.Moves++;

                        // enPassent möglich?
                        if (Figur.Name == 'P' && Figur.Moves== 1 && Figur.Farbe == 0 && Zeile == 3)
                        {
                            Figur.EnPassentAble = true;
                        }
                        else if (Figur.Name == 'P' && Figur.Moves == 1 && Figur.Farbe == 1 && Zeile == 4)
                        {
                            Figur.EnPassentAble = true;
                        }
                        else
                        {
                            for (int i = 0; i < 8; i++)
                            {
                                foreach (var f in Spielbrett.Felder[i])
                                {
                                    if (f.Figur != null && f.Figur.Name == 'P')
                                    {
                                        f.Figur.EnPassentAble = false;
                                    }
                                    
                                }
                            }
                            
                        }

                        Spielbrett.Zug = Spielbrett.Zug == 1 ? 0 : 1;

                        // check ?
                        Spielbrett.MarkiertesFeld = this;
                        
                        foreach (var kf in MoeglicheBewegungen(Figur))
                        {
                            for (int i = 0; i < 8; i++)
                            {
                                foreach (var kff in Spielbrett.Felder[i])
                                {
                                    if (kf.Zeile == kff.Zeile && kf.Spalte==kff.Spalte)
                                    {
                                        if (kff.Figur != null && kff.Figur.Name=='K' && kff.Figur.Farbe == Spielbrett.Zug)
                                        {
                                            Spielbrett.FeldRefresh();
                                            kff.FlatAppearance.BorderColor = Color.Red;
                                            kff.FlatAppearance.BorderSize = 2;
                                            return;
                                        }
                                    }
                                }
                            }
                        }
                        Spielbrett.FeldRefresh();

                        return;
                    }
                }

                return;               
            }
            
            // first time markieren nur, wenn figur.farbe  ==  farbe am zug
            if (Figur != null && Figur.Farbe == Spielbrett.Zug )
            {
                Spielbrett.FelderUnmarkieren();
                Spielbrett.FeldMarkieren((Spielfeld)sender);
                return;
            }
            // kann nie auftreten?
            if (Figur != null && Figur.Farbe!=Spielbrett.Zug && Spielbrett.MarkiertesFeld==null)
            {
                Spielbrett.FelderUnmarkieren();
                return;
            }
            // Figur auf ein Feld bewegen, auf dem eine Andere Figur steht (schlagen)
            if (Figur != null && Figur.Farbe!=Spielbrett.Zug && Spielbrett.MarkiertesFeld.Figur != null &&Spielbrett.MarkiertesFeld.Figur.Farbe == Spielbrett.Zug)
            {
                //promotion via schlagen weiß
                if (Spielbrett.MarkiertesFeld.Figur.Name == 'P'
                    && Spielbrett.Zug == 1
                    && Spielbrett.MarkiertesFeld.Zeile == 1
                    && ( Spielbrett.MarkiertesFeld.Spalte == Spalte + 1 || Spielbrett.MarkiertesFeld.Spalte == Spalte - 1)
                    && Zeile == 0)
                {
                    using (var form = new PromotionForm(Spielbrett.Zug))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            if (Figur.Name == 'K')
                            {
                                Figur = form.GetNewFigur();
                                Spielbrett.MarkiertesFeld.Figur = null;
                                Spielbrett.FeldRefresh();
                                MessageBox.Show(Figur.Farbe == 0 ? "Schwarz gewinnt." : "Weiß gewinnt.");
                                Application.Exit();
                            }
                            else
                            {
                                Figur = form.GetNewFigur();
                                Spielbrett.MarkiertesFeld.Figur = null;
                                Figur.Moves++;
                                Spielbrett.Zug = Spielbrett.Zug == 1 ? 0 : 1;
                                Spielbrett.FeldRefresh();
                            }

                        }
                    }


                    return;
                }
                //promotion via schlagen schwarz
                if (Spielbrett.MarkiertesFeld.Figur.Name == 'P'
                    && Spielbrett.Zug == 0
                    && Spielbrett.MarkiertesFeld.Zeile == 6
                    && (Spielbrett.MarkiertesFeld.Spalte == Spalte + 1 || Spielbrett.MarkiertesFeld.Spalte == Spalte - 1)
                    && Zeile == 7)
                {
                    using (var form = new PromotionForm(Spielbrett.Zug))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            if (Figur.Name == 'K')
                            {
                                Figur = form.GetNewFigur();
                                Spielbrett.MarkiertesFeld.Figur = null;
                                Spielbrett.FeldRefresh();
                                MessageBox.Show(Figur.Farbe == 0 ? "Schwarz gewinnt." : "Weiß gewinnt.");
                                Application.Exit();
                            }
                            else
                            {
                                Figur = form.GetNewFigur();
                                Spielbrett.MarkiertesFeld.Figur = null;
                                Figur.Moves++;
                                Spielbrett.Zug = Spielbrett.Zug == 1 ? 0 : 1;
                                Spielbrett.FeldRefresh();
                            }
                            

                        }
                    }

                    return;
                }
                foreach (var feld in MoeglicheBewegungen(Spielbrett.MarkiertesFeld.Figur))
                {
                    if (Zeile == feld.Zeile && Spalte == feld.Spalte)
                    {
                        if (Figur.Name == 'K')
                        {
                            Figur = Spielbrett.MarkiertesFeld.Figur;
                            Spielbrett.MarkiertesFeld.Figur = null;
                            Spielbrett.FeldRefresh();
                            MessageBox.Show(Figur.Farbe == 0 ? "Schwarz gewinnt." : "Weiß gewinnt.");
                            Application.Exit();
                        }
                        else
                        {
                            Figur = Spielbrett.MarkiertesFeld.Figur;
                            Spielbrett.MarkiertesFeld.Figur = null;

                            Spielbrett.Zug = Spielbrett.Zug == 1 ? 0 : 1;

                            Spielbrett.MarkiertesFeld = this;
                            foreach (var kf in MoeglicheBewegungen(Figur))
                            {
                                for (int i = 0; i < 8; i++)
                                {
                                    foreach (var kff in Spielbrett.Felder[i])
                                    {
                                        if (kf.Zeile == kff.Zeile && kf.Spalte == kff.Spalte)
                                        {
                                            if (kff.Figur != null && kff.Figur.Name == 'K' && kff.Figur.Farbe == Spielbrett.Zug)
                                            {
                                                Spielbrett.FeldRefresh();
                                                kff.FlatAppearance.BorderColor = Color.Red;
                                                kff.FlatAppearance.BorderSize = 2;
                                                return;
                                            }
                                        }
                                    }
                                }
                            }

                            Spielbrett.FeldRefresh();
                            Figur.Moves++;

                            return;
                        }                    
                    }
                }
            }
                  
        }

    }
}
