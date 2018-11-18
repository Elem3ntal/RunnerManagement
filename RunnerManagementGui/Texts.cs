using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RunnerManagementGui
{
    static class Texts
    {
        public static Dictionary<string, object> Words
        {
            get
            {
                return new Dictionary<string, object> {
                    { "titleForm", "Consulta Estadistica de Running" },
                    { "textLabelInputHeader", "Datos del Registro del corredor" },
                    { "textLabelInputNumber", "Número" },
                    { "textLabelInputCategorie", "Corrida" },
                    { "textLabelInputTimeStart", "Hora Partida" },
                    { "textLabelInputTimeEnd", "Hora Llegada" },
                    { "textButtonInputAdd", "Agregar" },
                    { "textButtonInputUpdate", "Actualizar" },
                    { "textButtonInputDelete", "Eliminar" },
                    { "labelTitleRegisterRun", "Mensajes" },
                    { "labelTitleMessages", "Registro Corrida" },
                    { "labelTitleResultsRun", "Resultados Running" },
                    { "textButtonResultDelete", "Consultar" },
                    { "textButtonResultReset", "Resetear" },
                    { "textButtonClose", "Cerrar" },
                };
            }
        }
    }
}
