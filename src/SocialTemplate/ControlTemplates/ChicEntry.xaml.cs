using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace SocialTemplate.ControlTemplates
{
    /// <summary>
    /// A control that provides single-line text input. 
    /// </summary>
    public partial class ChicEntry : ContentView
	{
        /// <summary>
        /// To set and read the text presented by the Editor.
        /// </summary>
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(ChicEntry), string.Empty, BindingMode.TwoWay);

        /// <summary>
        /// A hint shown if there is no user input.
        /// </summary>
        public static readonly BindableProperty PlaceholderProperty =
            BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(ChicEntry), string.Empty);

        /// <summary>
        /// To limit the input length that's permitted for the ChicEntry
        /// </summary>
        public static readonly BindableProperty MaxLengthProperty =
            BindableProperty.Create(nameof(MaxLength), typeof(int), typeof(ChicEntry), int.MaxValue);

        /// <summary>
        /// The keyboard that's presented when users interact with a ChicEntry
        /// </summary>
        public static readonly BindableProperty KeyboardProperty =
            BindableProperty.Create(nameof(Keyboard), typeof(Keyboard), typeof(ChicEntry), Keyboard.Default);

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public string Placeholder
        {
            get => (string)GetValue(PlaceholderProperty);
            set => SetValue(PlaceholderProperty, value);
        }

        public int MaxLength
        {
            get => (int)GetValue(MaxLengthProperty);
            set => SetValue(MaxLengthProperty, value);
        }

        public Keyboard Keyboard
        {
            get => (Keyboard)GetValue(KeyboardProperty);
            set => SetValue(KeyboardProperty, value);
        }

        public ChicEntry ()
		{
			InitializeComponent ();

        }
    }
}

