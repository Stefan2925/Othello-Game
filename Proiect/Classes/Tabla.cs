using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Tabla
    {

      
            public Piesa[,] Grid { get; private set; }

            public Tabla()
            {
                Grid = new Piesa[8, 8];


            Grid[3, 3] = new PiesaAlba();
                Grid[4, 4] = new PiesaAlba();
                Grid[3, 4] = new PiesaNeagra();
                Grid[4, 3] = new PiesaNeagra();
            }
        

    }
}
