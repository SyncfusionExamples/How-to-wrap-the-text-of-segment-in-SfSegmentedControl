using Syncfusion.XForms.Buttons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class ViewModel 
    {
        public ObservableCollection<View> ViewItems { get; set; }

        public ViewModel()
        {
            ViewItems = new ObservableCollection<View>()
            {
                new CustomLabel(){Text = "Veg (Garlic, taco toppings and ranch)" },
                new CustomLabel(){Text = "Non Veg (bafbecue sauce and chicken)" }
            };
         }
    }

    public class CustomLabel : Label
    {
        public CustomLabel()
        {
            TextColor = Color.Black;
            FontSize = 30;
            LineBreakMode = Xamarin.Forms.LineBreakMode.WordWrap;
            HorizontalTextAlignment = TextAlignment.Center;
            VerticalOptions = LayoutOptions.Center;
            HeightRequest = 200;
        }
    }

}
