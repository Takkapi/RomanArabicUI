using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace RomanArabicUI.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void ButtonClicked(object source, RoutedEventArgs args) {
        var roamnNum = roman.Text.ToUpper();
        var arabicNum = arabic.Text;
        ConvertRomanToArabic a = new ConvertRomanToArabic();
        ConvertArabicToRoman b = new ConvertArabicToRoman();
        if((bool)toRoman.IsChecked) {
            roman.Text = b.Convert((int)arabic.Value);
        } else {
            arabic.Value = a.Convert(roman.Text);
        }
    }

    public void OpenAbout(object source, RoutedEventArgs args) {
        var window = new AboutWindow();

        window.Show();
    }
}