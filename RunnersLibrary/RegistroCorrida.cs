using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RunnersLibrary
{
    public class RegistroCorrida
    {
        public int numeroCorredor { get; set; }
        public int categoria { get; set; }
        public string horaPartida { get; set; }
        public string horaLlegada { get; set; }

        public RegistroCorrida() { }

        public RegistroCorrida(int numeroCorredor, int categoria, string horaPartida, string horaLLegada) {
            this.numeroCorredor = numeroCorredor;
            this.categoria = categoria;
            this.horaPartida = horaPartida;
            this.horaLlegada = horaLlegada;
        }
        public String obtenerTiempo()
        {
            String output;
            DateTime horaPartida = DateTime.Parse(this.horaPartida, System.Globalization.CultureInfo.CurrentCulture);
            Console.WriteLine('{0}', horaPartida);
            return output;
        }
    }
}
