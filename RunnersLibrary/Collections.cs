﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RunnersLibrary
{
    public class CollectionsRegister
    {
        private List<RegistroCorrida> runners;

        public CollectionsRegister()
        {
            this.runners = new List<RegistroCorrida>();
        }
        public bool addRunner(RegistroCorrida runner)
        {
            try
            {
                this.runners.Add(runner);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public List<Dictionary<string, string>> allRunners()
        {
            List<Dictionary<string, string>> output = new List<Dictionary<string, string>>();
            foreach (RegistroCorrida runner in this.runners)
                output.Add(new Dictionary<string, string> {
                    { "numero", runner.numeroCorredor.ToString()},
                    { "categoria", runner.categoria.ToString()},
                    { "horaPartida", runner.horaPartida},
                    { "horaLlegada", runner.horaLlegada},
                    { "Tiempo", runner.obtenerTiempo()},
                    { "Lugar","-"},
                });
            return output;

        }
    }
}
