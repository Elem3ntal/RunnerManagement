using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RunnersLibrary
{
    public static class Categories
    {
        public static Dictionary<string, object> Options
        {
            get
            {
                return new Dictionary<string, object> {
                    { "OptionCategorie0", new { Text = "", Value = "" } },
                    { "OptionCategorie1", new { Text = "5k", Value = "0" } },
                    { "OptionCategorie2", new { Text = "10k", Value = "1" } },
                    { "OptionCategorie3", new { Text = "16k", Value = "2" } },
                    { "OptionCategorie4", new { Text = "21k", Value = "3" } },
                    { "OptionCategorie5", new { Text = "42k", Value = "4" } },
                };
            }
        }
    }
}

