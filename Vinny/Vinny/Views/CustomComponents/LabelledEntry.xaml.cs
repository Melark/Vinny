using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Vinny.Views.CustomComponents
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LabelledEntry : ContentView
	{
        public static readonly BindableProperty TitleTextProperty = BindableProperty.Create(
            propertyName: "LabelText",
            returnType: typeof(string),
            declaringType: typeof(LabelledEntry),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: LabelTextPropertyChanged);

        private static void LabelTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (LabelledEntry)bindable;
            control.labelText.Text = newValue?.ToString() ?? "";
        }

        public string LabelText
        {
            get => GetValue(TitleTextProperty).ToString();
            set => SetValue(TitleTextProperty, value);
        }

        public static readonly BindableProperty EntryTextProperty = BindableProperty.Create(
            propertyName: "EntryText",
            returnType: typeof(string),
            declaringType: typeof(LabelledEntry),
            defaultValue: "",
            defaultBindingMode: BindingMode.TwoWay,
            propertyChanged: EntryTextPropertyChanged);

        private static void EntryTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (LabelledEntry)bindable;
            control.entryText.Text = newValue?.ToString() ?? "";
        }

        public string EntryText
        {
            get => GetValue(EntryTextProperty).ToString();
            set => SetValue(EntryTextProperty, value);
        }

        public LabelledEntry ()
		{
			InitializeComponent ();
		}
	}
}