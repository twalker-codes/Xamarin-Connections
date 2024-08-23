using SocialTemplate.MaterialDesign;
using Xamarin.Forms;

namespace SocialTemplate.ControlTemplates
{
    /// <summary>
    /// Button with two icons.
    /// </summary>
    public partial class ChicButton : ContentView
    {
        /// <summary>
        /// The Unicode string of a material icon to be displayed in the left side.
        /// </summary>
        public static readonly BindableProperty IconProperty =
            BindableProperty.Create(nameof(Icon), typeof(string), typeof(ChicButton), Icons.Image);

        /// <summary>
        /// The string to be displayed in the button.
        /// </summary>
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(ChicButton), string.Empty);

        /// <summary>
        /// The command to be executed when the button is pressed.
        /// </summary>
        public static readonly BindableProperty FetchCommandProperty =
            BindableProperty.Create(nameof(FetchCommand), typeof(Command), typeof(ChicButton), null);

        public string Icon
        {
            get => (string)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public Command FetchCommand
        {
            get => (Command)GetValue(FetchCommandProperty);
            set => SetValue(FetchCommandProperty, value);
        }

        public ChicButton()
        {
            InitializeComponent();
        }
    }
}
