using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RunnerManagementGui
{
    static class Texts
    {
        public static Dictionary<string, string> Words
        {
            get
            {
                return new Dictionary<string, string> {
                    { "titleForm", "Consulta Estadistica de Running" },
                    { "textLabelInputHeader", "Datos del Registro del corredor" },
                    { "textLabelInputNumber", "Número" },
                    { "textLabelInputCategorie", "Corrida" },
                    { "textLabelInputTimeStart", "Hora Partida" },
                    { "textLabelInputTimeEnd", "Hora Llegada" },
                    { "textButtonInputAdd", "Agregar" },
                    { "textButtonInputUpdate", "Actualizar" },
                    { "textButtonInputDelete", "Eliminar" },
                    { "labelTitleRegisterRun", "Registro Corrida" },
                    { "labelTitleMessages", "Mensajes" },
                    { "labelTitleResultsRun", "Resultados Running" },
                    { "textButtonResultDelete", "Consultar" },
                    { "textButtonResultReset", "Resetear" },
                    { "textButtonClose", "Cerrar" },
                    { "invalidNumberRunner", "Numero de corredor Invalido" },
                    { "invalidCategorieRunner", "Categoria de corredor Invalido" },
                    { "invalidTimesRunner", "Tiempos del corredor Invalidos" },
                    { "RepitedNumberRunner", "El numero de corredor ya existe" },
                };
            }
        }
    }
}
