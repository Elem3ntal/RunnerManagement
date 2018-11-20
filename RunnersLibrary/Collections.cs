using System;
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
        public bool updateRunner(RegistroCorrida runner)
        {
            try
            {
                this.runners[this.runners.IndexOf(this.runners.Single(x => x.numeroCorredor == runner.numeroCorredor))] = runner;
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool removeRunner(int runner_id)
        {
            try
            {
                this.runners.Remove(this.runners[this.runners.IndexOf(this.runners.Single(x => x.numeroCorredor == runner_id))]);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public List<Dictionary<string, string>> allRunnerSorted()
        {
            List<Dictionary<string, string>> output = new List<Dictionary<string, string>>();
            //busco las categorias validas, distintias de cero
            List<string> valid_categories = new List<string>();
            foreach (dynamic categorie in Categories.Options.Values)
                if (categorie.Value != "")
                    valid_categories.Add(categorie.Value);
            List<string> categories = valid_categories.OrderBy(x => x).ToList();
            //por cada categoria, buscar todos los corredores, ordenar y enumerar
            foreach (string cat in categories)
            {
                var runners_cat = (from runner in (from runner_cat in this.runners where runner_cat.categoria.ToString() == cat select runner_cat)
                                   orderby runner.obtenerTiempo()
                                   select runner).ToList();
                foreach (RegistroCorrida participant in runners_cat)
                {
                    dynamic textcat = Categories.Options[string.Format("OptionCategorie{0}", participant.categoria.ToString())];
                    output.Add(new Dictionary<string, string> {
                        { "numero", participant.numeroCorredor.ToString()},
                        { "categoria", textcat.Text},
                        { "horaPartida", participant.horaPartida},
                        { "horaLlegada", participant.horaLlegada},
                        { "Tiempo", participant.obtenerTiempo()},
                        { "Lugar", (1+runners_cat.IndexOf(participant)).ToString()},
                    });
                }
            }
            return output;

        }
        public List<Dictionary<string, string>> allRunners()
        {
            List<Dictionary<string, string>> output = new List<Dictionary<string, string>>();
            foreach (RegistroCorrida runner in this.runners)
            {
                dynamic cat = Categories.Options[string.Format("OptionCategorie{0}", runner.categoria.ToString())];
                output.Add(new Dictionary<string, string> {
                    { "numero", runner.numeroCorredor.ToString()},
                    { "categoria", cat.Text},
                    { "horaPartida", runner.horaPartida},
                    { "horaLlegada", runner.horaLlegada},
                    { "Tiempo", runner.obtenerTiempo()},
                    { "Lugar","-"},
                });
            }
            return output;
        }
        public void removeAll()
        {
            //eliminar todos los weones
        }
    }
}
