using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RunnerManagementGui
{
    public static class GridsStructure
    {
        public static List<string> ColumnsRegister
        {
            /* Los nombres de las columnas deben estar en el 
             * diccionario que retorna la clase RegistroCorrida, 
             * para asi, adecuarse dinamicamente a los cambios de aqui */
            get
            {
                return new List<string>(new string[]
                {
                    "numero",
                    "categoria",
                    "horaPartida",
                    "horaLlegada",
                    "Tiempo",
                    "Lugar"
                });
            }
        }
        public static List<string> ColumnsResult
        {
            /* Los nombres de las columnas deben estar en el 
             * diccionario que retorna la clase RegistroCorrida, 
             * para asi, adecuarse dinamicamente a los cambios de aqui */
            get
            {
                return new List<string>(new string[]
                {
                    "numero",
                    "categoria",
                    "horaPartida",
                    "horaLlegada",
                    "Tiempo",
                    "Lugar"
                });
            }
        }
    }
}
