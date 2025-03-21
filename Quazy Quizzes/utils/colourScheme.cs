using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Quazy_Quizzes;

namespace QQColourScheme
{
    class ColourScheme
    {
        public string _background { private set; get; }
        public string _secondaryBackground { private set; get; }
        public string _foregroudText { private set; get; }
        public string _backgroundText { private set; get; }
        public string _cardBackground { private set; get; }
        public string _secondaryTextFg { private set; get; }
        public string _primaryButtonBackground { private set; get; }
        public string _secondaryButtonBackground { private set; get; }
        public string _emergencyButtonBackground { private set; get; }
        public string _buttonText { private set; get; }
        public string _buttonHover { private set; get; }
        public string _headerBackground { private set; get; }

        public ColourScheme(string background, string secondaryBackground, string primaryText, string secondaryText,
            string inputBackground, string inputText, string primaryButtonBackground, string secondaryButtonBackground,
            string emergencyButtonBackground, string buttonText, string buttonHover, string headerBackground)
        {
            _background = background;
            _secondaryBackground = secondaryBackground;
            _foregroudText = primaryText;
            _backgroundText = secondaryText;
            _cardBackground = inputBackground;
            _secondaryTextFg = inputText;
            _primaryButtonBackground = primaryButtonBackground;
            _secondaryButtonBackground = secondaryButtonBackground;
            _emergencyButtonBackground = emergencyButtonBackground;
            _buttonText = buttonText;
            _buttonHover = buttonHover;
            _headerBackground = headerBackground;
        }
        
        // Set the colour scheme on given text elements
        public void SetColourSchemeText(List<Label> textElements)
        {
            for (int i = 0; i < textElements.Count; i++)
            {
                textElements[i].ForeColor = ColorTranslator.FromHtml(this._foregroudText);
                textElements[i].BackColor = ColorTranslator.FromHtml(this._backgroundText);
            }
        }

        // Method overloading to allow for just one text element instead of a list of them
        public void SetColourSchemeText(Label textElement)
        {
            textElement.ForeColor = ColorTranslator.FromHtml(this._foregroudText);
            textElement.BackColor = ColorTranslator.FromHtml(this._backgroundText);
        }


        // Set the colour scheme on given RichTextBoxElements
        public void SetColourSchemeTextBox(List<RichTextBox> textBoxElements)
        {
            for (int i = 0; i < textBoxElements.Count; i++)
            {
                textBoxElements[i].BackColor = ColorTranslator.FromHtml(this._cardBackground);
                textBoxElements[i].ForeColor = ColorTranslator.FromHtml(this._secondaryTextFg);
            }
        }

        // Method overloading to allow for just one RichTextBox element instead of a list of them
        public void SetColourSchemeTextBox(RichTextBox textBoxElement)
        {
            textBoxElement.BackColor = ColorTranslator.FromHtml(this._cardBackground);
            textBoxElement.ForeColor = ColorTranslator.FromHtml(this._secondaryTextFg);
        }

        // Set the colour scheme on given Button Elements
        public void SetColourSchemePrimaryButtons(List<Button> buttonElements)
        {
            for (int i = 0; i < buttonElements.Count; i++)
            {
                buttonElements[i].BackColor = ColorTranslator.FromHtml(this._primaryButtonBackground);
            }
        }

        // Method overloading to allow for just one Button element instead of a list of them
        public void SetColourSchemePrimaryButtons(Button buttonElement)
        {
            buttonElement.BackColor = ColorTranslator.FromHtml(this._primaryButtonBackground);
        }

        public void SetColourSchemeSecondaryButtons(List<Button> buttonElements)
        {
            for (int i = 0; i < buttonElements.Count; i++)
            {
                buttonElements[i].BackColor = ColorTranslator.FromHtml(this._secondaryButtonBackground);
            }
        }

        // Method overloading to allow for just one Button element instead of a list of them
        public void SetColourSchemeSecondaryButtons(Button buttonElement)
        {
            buttonElement.BackColor = ColorTranslator.FromHtml(this._secondaryButtonBackground);
        }

        public void SetColourSchemeEmergencyButtons(List<Button> buttonElements)
        {
            for (int i = 0; i < buttonElements.Count; i++)
            {
                buttonElements[i].BackColor = ColorTranslator.FromHtml(this._emergencyButtonBackground);
            }
        }

        // Method overloading to allow for just one Button element instead of a list of them
        public void SetColourSchemeEmergencyButtons(Button buttonElement)
        {
            buttonElement.BackColor = ColorTranslator.FromHtml(this._emergencyButtonBackground);
        }
    }
}