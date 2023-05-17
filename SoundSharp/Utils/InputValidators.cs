using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoundSharp.Models;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SoundSharp.Utils
{
    public class InputValidators
    {
        public static bool IsLonger(string input, int max)
        {
            if (input.Length > max) return true;
            return false;
        }
        public static void LimitInput(TextBox textBox, int max)
        {
            bool isLonger = IsLonger(textBox.Text, max);
            int textLength = textBox.Text.Length;
            if (isLonger)
            {
                textBox.Text = textBox.Text.Remove(textLength - 1);
                textBox.Select(textLength, 0);
            };
        }
        public static bool Exists<T>(string entry, string key, List<T> entries)
        {
            return entries.Any(elm => entry == Misc.GetValue(elm, key));
        }
        public static bool IsEmpty(string entry)
        {
            return entry == "";
        }
    }
}
