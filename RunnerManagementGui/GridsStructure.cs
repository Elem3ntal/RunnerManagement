using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RunnerManagementGui
{
    public static class GridsStructure
    {
        /* Los nombres de las columnas deben estar en el 
             * diccionario que retorna la clase CollectionsRegister, 
             * para asi, adecuarse dinamicamente a los cambios de aqui */

        public static List<string> ColumnsRegister
        {
            get
            {
                return new List<string>(new string[]
                {
                    "numero",
                    "categoria",
                    "horaPartida",
                    "horaLlegada",
                    "Tiempo"
                });
            }
        }
        public static List<string> ColumnsResult
        {
            get
            {
                return new List<string>(new string[]
                {
                    "categoria",
                    "numero",
                    "Lugar",
                    "Tiempo"
                });
            }
        }
    }
}
