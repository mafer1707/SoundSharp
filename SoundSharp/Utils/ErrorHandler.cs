using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundSharp.Utils
{
    public class ErrorHandler
    {
        private Label _label;

        public ErrorHandler(Label label)
        {
            _label = label;
        }

        public void ShowError(string message)
        {
            _label.Text = message;
        }
        public void HideError()
        {
            _label.Text = "";
        }
    }
}
