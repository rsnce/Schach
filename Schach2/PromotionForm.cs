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
    public partial class PromotionForm : Form
    {
        private Figur newFigur { get; set; }
        private int Zug { get; set; }
        public PromotionForm(int zug)
        {
            InitializeComponent();
            Zug = zug;
            if (zug == 1)
            {
                queenButton.Text = "♕";
                rookButton.Text = "♖";
                bishopButton.Text = "♗";
                knightButton.Text = "♘";                
            }
            else
            {
                queenButton.Text = "♛";
                rookButton.Text = "♜";
                bishopButton.Text = "♝";
                knightButton.Text = "♞";
            }
        }
        public Figur GetNewFigur()
        {
            return newFigur;
        }
        //TODO - in PromotionFromButton Figuren characters statt Text anzeigen!
        private void queenButton_Click(object sender, EventArgs e)
        {
            newFigur = new Figur('q', Zug);
            DialogResult = DialogResult.OK;
        }

        private void rookButton_Click(object sender, EventArgs e)
        {
            newFigur = new Figur('r', Zug);
            DialogResult = DialogResult.OK;
        }

        private void bishopButton_Click(object sender, EventArgs e)
        {
            newFigur = new Figur('b', Zug);
            DialogResult = DialogResult.OK;
        }

        private void knightButton_Click(object sender, EventArgs e)
        {
            newFigur = new Figur('n', Zug);
            DialogResult = DialogResult.OK;
        }
    }
}
