using Proiect.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class GameWindow : Form
    {
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }
        private OthelloGame game;
        private Tabla tabla;
        public GameWindow()
        {
            InitializeComponent();
         
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                   ControlStyles.UserPaint |
                   ControlStyles.DoubleBuffer, true);
            this.UpdateStyles();
            tabla = new Tabla();
            game = new OthelloGame(tabla, culoareJucator.White, Panou);

           
            Panou.Invalidate();

        }
        private void Game_Resize(object sender, EventArgs e)
        {
            int spacing = 20;
            int totalWidth = button1.Width + +spacing * 2;


            int startX = (this.ClientSize.Width - totalWidth) / 2;
            int startY = (this.ClientSize.Height - button1.Height) / 2;


            button1.Left = startX + 600;


            button1.Top = startY;





            int maxWidth = (int)(this.ClientSize.Width * 0.8);
            int maxHeight = (int)(this.ClientSize.Height * 0.8);

            int boardSize = Math.Min(maxWidth, maxHeight);


            Panou.Width = boardSize;
            Panou.Height = boardSize;

            Panou.Left = (this.ClientSize.Width - boardSize) / 2;
            Panou.Top = (this.ClientSize.Height - boardSize) / 2;



        }






        private void Back_Menu(object sender, EventArgs e)
        {

            Application.Exit();
        }


      


        private void Board_Panel(object sender, EventArgs e)
        {

        }
    }
}