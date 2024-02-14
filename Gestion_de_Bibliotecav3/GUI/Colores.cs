using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Biblioteca
{
    public static class Colores
    {
        public static List<string> ListaColores = new List<string>() {
                    "#00FFFF",
                    "#E0FFFF",
                    "#AFEEEE",
                    "#7FFFD4",
                    "#40E0D0",
                    "#48D1CC",
                    "#00CED1",
                    "#5F9EA0",
                    "#4682B4",
                    "#B0C4DE",
                    "#B0E0E6",
                    "#ADD8E6",
                    "#87CEEB",
                    "#87CEFA",
                    "#00BFFF",
                    "#1E90FF",
                    "#6495ED",
                    "#7B68EE",
                    "#4169E1",
                    "#0000FF",
                    "#0000CD",
                    "#00008B",
                    "#000080",
                    "#191970"
        };

        //Cambia la "iluminación" del color.
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            //Si el factor de corrección es menos que 0, se oscurece el color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //si el factor de corrección es mayor que cero, se enclarece el color
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
