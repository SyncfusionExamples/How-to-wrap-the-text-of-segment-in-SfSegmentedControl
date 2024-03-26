# How-to-wrap-the-text-of-segment-in-SfSegmentedControl
This section explains how to wrap the text of segment in SfsegmentedControl with examples.

## Getting Started with Xamarin Segmented Control (SfSegmentedControl)

This section provides an overview for working with the segmented control for Xamarin.Forms. Walk through the entire process of creating a real-world application with the SfSegmentedControl.

## Adding SfSegmentedControl reference
You can add SfSegmentedControl reference using one of the following methods:

### Method 1: Adding SfSegmentedControl reference from nuget.org

Syncfusion Xamarin components are available in nuget.org. To add SfSegmentedControl to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Xamarin.Buttons, and then install it.

### Method 2: Adding SfSegmentedControl reference from toolbox

Syncfusion also provides Xamarin Toolbox. Using this toolbox, you can drag the SfSegmentedControl control to the XAML page. It will automatically install the required NuGet packages and add the namespace to the page. To install Syncfusion Xamarin Toolbox, refer to Toolbox.

### Method 3: Adding SfSegmentedControl assemblies manually from the installed location

If you prefer to manually reference the assemblies instead referencing from NuGet, add the following assemblies in respective projects.

Location: {Installed location}/{version}/Xamarin/lib

## Creating a project
Create a new BlankApp (Xamarin.Forms.Portable) application in Visual Studio for Xamarin.Forms.

## Adding SfSegmentedControl in Xamarin.Forms
Add the required assembly references to the PCL and renderer projects as discussed in the Assembly deployment  section.

Import the control namespace as shown in the following code.

**[XAML]**

```
xmlns:buttons="clr-namespace:Syncfusion.XForms.Buttons;assembly=Syncfusion.Buttons.XForms"
```
Set the control to content in ContentPage.

**[XAML]**
```
<ContentPage.Content>
    <buttons:SfSegmentedControl  />
</ContentPage.Content>
```
## Wrap text in Segmented control

**[C#]**
```
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:sfButtons="clr-namespace:Syncfusion.XForms.Buttons;assembly=Syncfusion.Buttons.XForms"
             xmlns:local="clr-namespace:SimpleSample"
             x:Class="SimpleSample.MainPage">
    <ContentPage.Content>
        <StackLayout VerticalOptions="Center">
            <Label Text="Meals combo" TextColor="Black" FontSize="22"/>
            <sfButtons:SfSegmentedControl
                x:Name="segmentedControl"
                BorderColor="Transparent"
                BackgroundColor="LightBlue"
                HorizontalOptions="StartAndExpand"
                VerticalOptions="CenterAndExpand"
                Color="Transparent"
                SegmentHeight="120"
                SegmentWidth="200"
                ItemsSource="{Binding ViewItems}">
                <sfButtons:SfSegmentedControl.BindingContext>
                    <local:ViewModel/>
                </sfButtons:SfSegmentedControl.BindingContext>
                <sfButtons:SfSegmentedControl.SelectionIndicatorSettings>
                    <sfButtons:SelectionIndicatorSettings Color="LightPink"/>
                </sfButtons:SfSegmentedControl.SelectionIndicatorSettings>
            </sfButtons:SfSegmentedControl>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>
```

**[C#]**

```
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
```