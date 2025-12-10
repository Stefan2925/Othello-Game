using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
   
        public enum culoareJucator{ Black, White }

    public abstract class Piesa
    {
        private culoareJucator color;

        public culoareJucator Color
        {
            get { return color; }
            set { color = value; }
        }
       

        public Piesa(culoareJucator color)
        {
            Color = color;
        }
        public abstract void Draw(Graphics g,int x,int y,int size);
    }

    public class PiesaNeagra:Piesa
    {
        public PiesaNeagra():base(culoareJucator.Black)
        {

        }

        public override void Draw(Graphics g, int x, int y, int size)
        {
            Image img = Properties.Resources.black_piece;
            g.DrawImage(img,x,y,size,size);
        }
    }
    public class PiesaAlba : Piesa
    {
        public PiesaAlba() : base(culoareJucator.White)
        {

        }

        public override void Draw(Graphics g, int x, int y, int size)
        {
            Image img = Properties.Resources.white_piece;
            g.DrawImage(img, x, y, size, size);
        }
    }
}
