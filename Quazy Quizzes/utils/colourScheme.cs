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
        public string _buttonBackground { private set; get; }
        public string _buttonText { private set; get; }
        public string _buttonHover { private set; get; }
        public string _headerBackground { private set; get; }

        public ColourScheme(string background, string secondaryBackground, string primaryText, string secondaryText,
            string inputBackground, string inputText, string buttonBackground, string buttonText, string buttonHover, string headerBackground)
        {
            _background = background;
            _secondaryBackground = secondaryBackground;
            _foregroudText = primaryText;
            _backgroundText = secondaryText;
            _cardBackground = inputBackground;
            _secondaryTextFg = inputText;
            _buttonBackground = buttonBackground;
            _buttonText = buttonText;
            _buttonHover = buttonHover;
            _headerBackground = headerBackground;
        }
    }
}