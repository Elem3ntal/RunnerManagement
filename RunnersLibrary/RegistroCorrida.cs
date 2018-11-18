using System;
using System.Collections.Generic;
using System.Globalization;
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

        public RegistroCorrida(int numeroCorredor, int categoria, string horaPartida, string horaLLegada)
        {
            this.numeroCorredor = numeroCorredor;
            this.categoria = categoria;
            this.horaPartida = horaPartida;
            this.horaLlegada = horaLLegada;
        }
        public String obtenerTiempo()
        {
            DateTime horaPartida = DateTime.ParseExact(this.horaPartida, "HH:mm:ss", CultureInfo.InvariantCulture); ;
            DateTime horaLlegada = DateTime.ParseExact(this.horaLlegada, "HH:mm:ss", CultureInfo.InvariantCulture); ;
            return String.Format("{0}", horaLlegada - horaPartida);
        }
    }
}
