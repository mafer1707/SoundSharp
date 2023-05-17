using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundSharp.Utils
{
    public class Misc
    {
        public static string GetValue(object obj, string key)
        {
            return obj.GetType().GetProperty(key).GetValue(obj, null).ToString();
        }
    }
}
