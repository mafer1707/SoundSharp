using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundSharp.Utils
{
    public class InputSuggestions
    {

        public static void SetSuggestions<T>(List<T> items, TextBox textBox, string key)
        {
            AutoCompleteStringCollection suggestions = new AutoCompleteStringCollection();

            foreach (T item in items)
            {
                suggestions.Add(Misc.GetValue(item, key));
            }

            textBox.AutoCompleteCustomSource = suggestions;
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }
    }
}
