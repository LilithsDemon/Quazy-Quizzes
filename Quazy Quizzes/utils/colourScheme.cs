using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QQColourScheme
{
    class ColourScheme
    {
        public string Background { private set; get; }
        public string SecondaryBackground { private set; get; }
        public string PrimaryText { private set; get; }
        public string SecondaryText { private set; get; }
        public string InputBackground { private set; get; }
        public string InputText { private set; get; }
        public string ButtonBackground { private set; get; }

        public ColourScheme(string background, string secondaryBackground, string primaryText, string secondaryText,
            string inputBackground, string inputText, string buttonBackground)
        {
            Background = background;
            SecondaryBackground = secondaryBackground;
            PrimaryText = primaryText;
            SecondaryText = secondaryText;
            InputBackground = inputBackground;
            InputText = inputText;
            ButtonBackground = buttonBackground;
        }
    }
}