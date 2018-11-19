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
                    { "OptionCategorie", new { Text = "", Value = "" } },
                    { "OptionCategorie0", new { Text = "5k", Value = "0" } },
                    { "OptionCategorie1", new { Text = "10k", Value = "1" } },
                    { "OptionCategorie2", new { Text = "15k", Value = "2" } },
                    { "OptionCategorie3", new { Text = "20k", Value = "3" } },
                };
            }
        }
    }
}

