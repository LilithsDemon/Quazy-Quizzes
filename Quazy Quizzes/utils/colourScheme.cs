using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Quazy_Quizzes;

namespace QQColourScheme
{
    class ButtonColourScheme
    {
        public string _buttonBackground { private set; get; }
        public string _buttonText { private set; get; }
        public string _buttonHover { private set; get; }

        public ButtonColourScheme(string buttonBackground, string buttonText, string buttonHover)
        {
            _buttonBackground = buttonBackground;
            _buttonText = buttonText;
            _buttonHover = buttonHover;
        }
    }

    class ColourScheme
    {
        public string _background { private set; get; }
        public string _headerBackground { private set; get; }
        public string _headerText { private set; get; }
        public string _secondaryBackground { private set; get; }
        public string _cardBackground { private set; get; }
        public string _primaryText { private set; get; }
        public string _secondaryText { private set; get; }

        public ButtonColourScheme _primaryButtonColourScheme { private set; get; }
        public ButtonColourScheme _secondaryButtonColourScheme { private set; get; }
        public ButtonColourScheme _emergencyButtonColourScheme { private set; get; }


        public ColourScheme(string background, string headerBackground, string headerText, string secondaryBackground, string cardBackground, string primaryText, string secondaryText, ButtonColourScheme primaryButtonColourScheme, ButtonColourScheme secondaryButtonColourScheme, ButtonColourScheme emergencyButtonColourScheme)
        {
            _background = background;
            _headerBackground = headerBackground;
            _headerText = headerText;
            _secondaryBackground = secondaryBackground;
            _cardBackground = cardBackground;
            _primaryText = primaryText;
            _secondaryText = secondaryText;
            _primaryButtonColourScheme = primaryButtonColourScheme;
            _secondaryButtonColourScheme = secondaryButtonColourScheme;
            _emergencyButtonColourScheme = emergencyButtonColourScheme;
        }


        //Set the colours of the lable being used as the header
        public void SetColourSchemeHeader(Label header)
        {
            header.ForeColor = ColorTranslator.FromHtml(this._headerText);
            header.BackColor = ColorTranslator.FromHtml(this._headerBackground);
        }

        // Set the colour scheme on given text elements
        public void SetColourSchemePrimaryText(List<Label> textElements)
        {
            foreach (Label textElement in textElements) SetColourSchemePrimaryText(textElement);
        }

        // Method overloading to allow for just one text element instead of a list of them
        public void SetColourSchemePrimaryText(Label textElement)
        {
            textElement.ForeColor = ColorTranslator.FromHtml(this._primaryText);
        }

        public void SetColourSchemeSecondaryText(List<Label> textElements)
        {
            foreach (Label textElement in textElements) SetColourSchemeSecondaryText(textElement);
        }

        // Method overloading to allow for just one text element instead of a list of them
        public void SetColourSchemeSecondaryText(Label textElement)
        {
            textElement.ForeColor = ColorTranslator.FromHtml(this._secondaryText);
        }


        // Set the colour scheme on given RichTextBoxElements
        public void SetColourSchemeTextBox(List<RichTextBox> textBoxElements)
        {
                foreach (RichTextBox textBoxElement in textBoxElements) SetColourSchemeTextBox(textBoxElement);
        }

        // Method overloading to allow for just one RichTextBox element instead of a list of them
        public void SetColourSchemeTextBox(RichTextBox textBoxElement)
        {
            textBoxElement.BackColor = ColorTranslator.FromHtml(this._cardBackground);
            textBoxElement.ForeColor = ColorTranslator.FromHtml(this._primaryText);
        }

        // Set the colour scheme on given Button Elements
        public void SetColourSchemePrimaryButtons(List<Button> buttonElements)
        {
            foreach(Button buttonElement in buttonElements) SetColourSchemePrimaryButtons(buttonElement);
        }

        // Method overloading to allow for just one Button element instead of a list of them
        public void SetColourSchemePrimaryButtons(Button buttonElement)
        {
            buttonElement.BackColor = ColorTranslator.FromHtml(this._primaryButtonColourScheme._buttonBackground);
            buttonElement.ForeColor = ColorTranslator.FromHtml(this._primaryButtonColourScheme._buttonText);
            buttonElement.MouseHover += (sender, e) => buttonElement.BackColor = ColorTranslator.FromHtml(this._primaryButtonColourScheme._buttonHover);
        }

        public void SetColourSchemeSecondaryButtons(List<Button> buttonElements)
        {
            foreach (Button buttonElement in buttonElements) SetColourSchemeSecondaryButtons(buttonElement);
        }

        // Method overloading to allow for just one Button element instead of a list of them
        public void SetColourSchemeSecondaryButtons(Button buttonElement)
        {
            buttonElement.BackColor = ColorTranslator.FromHtml(this._secondaryButtonColourScheme._buttonBackground);
            buttonElement.ForeColor = ColorTranslator.FromHtml(this._secondaryButtonColourScheme._buttonText);
            buttonElement.MouseHover += (sender, e) => buttonElement.BackColor = ColorTranslator.FromHtml(this._secondaryButtonColourScheme._buttonHover);
        }

        public void SetColourSchemeEmergencyButtons(List<Button> buttonElements)
        {
            foreach (Button buttonElement in buttonElements) SetColourSchemeEmergencyButtons(buttonElement);
        }

        // Method overloading to allow for just one Button element instead of a list of them
        public void SetColourSchemeEmergencyButtons(Button buttonElement)
        {
            buttonElement.BackColor = ColorTranslator.FromHtml(this._emergencyButtonColourScheme._buttonBackground);
            buttonElement.ForeColor = ColorTranslator.FromHtml(this._emergencyButtonColourScheme._buttonText);
            buttonElement.MouseHover += (sender, e) => buttonElement.BackColor = ColorTranslator.FromHtml(this._emergencyButtonColourScheme._buttonHover);
        }
    }
}