using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RunnersLibrary;

namespace RunnerManagementGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            test();
        }
        public void test() {
            RegistroCorrida weon = new RegistroCorrida();
            weon.horaPartida = "19:15:30";
            weon.horaLlegada = "20:30:25";
            Console.WriteLine("se partio: {0}", weon.horaPartida);
            Console.WriteLine("se llego: {0}", weon.horaLlegada);
            Console.WriteLine("se demoro: {0}", weon.obtenerTiempo());
        }
    }
}
