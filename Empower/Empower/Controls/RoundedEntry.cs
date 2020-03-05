using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Empower.Controls
{
    public class RoundedEntry : Entry
    {

        public static BindableProperty DisplaySuggestionsProperty = BindableProperty.Create(nameof(DisplaySuggestions), typeof(bool), typeof(RoundedEntry), true);
        public static BindableProperty BorderThicknessProperty = BindableProperty.Create(nameof(BorderThickness), typeof(int), typeof(RoundedEntry), 0);
        public static BindableProperty BorderRadiusProperty = BindableProperty.Create(nameof(BorderRadius), typeof(int), typeof(RoundedEntry), 0);
        public static BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(RoundedEntry), Color.Default);
        public static BindableProperty EntryBackgroundColorProperty = BindableProperty.Create(nameof(EntryBackgroundColor), typeof(Color), typeof(RoundedEntry), Color.Default);

        public bool DisplaySuggestions
        {
            get { return (bool)GetValue(DisplaySuggestionsProperty); }
            set { SetValue(DisplaySuggestionsProperty, value); }
        }

        public int BorderThickness
        {
            get { return (int)GetValue(BorderThicknessProperty); }
            set { SetValue(BorderThicknessProperty, value); }
        }

        public int BorderRadius
        {
            get { return (int)GetValue(BorderRadiusProperty); }
            set { SetValue(BorderRadiusProperty, value); }
        }

        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public Color EntryBackgroundColor
        {
            get { return (Color)GetValue(EntryBackgroundColorProperty); }
            set { SetValue(EntryBackgroundColorProperty, value); }
        }

        public new event EventHandler Completed;


        public static readonly BindableProperty ReturnTypeProperty = BindableProperty.Create(
            nameof(ReturnType),
            typeof(ReturnType),
            typeof(RoundedEntry),
            ReturnType.Done,
            BindingMode.OneWay
        );

        public ReturnType ReturnType
        {
            get { return (ReturnType)GetValue(ReturnTypeProperty); }
            set { SetValue(ReturnTypeProperty, value); }
        }

        public void InvokeCompleted()
        {
            if (this.Completed != null)
                this.Completed.Invoke(this, null);
        }



    }
}
