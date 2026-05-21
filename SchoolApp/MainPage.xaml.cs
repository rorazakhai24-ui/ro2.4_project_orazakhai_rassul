using System;
using Microsoft.Maui.Controls;

namespace SchoolApp;

public class MainPage : ContentPage
{
    private int _count = 0;

    private Label StatusLabel;

    public MainPage()
    {
        Title = "Home";

        var titleLabel = new Label { Text = "School App", FontSize = 32, HorizontalOptions = LayoutOptions.Center };
        var subLabel = new Label { Text = "Powered by .NET 10 MAUI", FontSize = 14, HorizontalOptions = LayoutOptions.Center };
        var hintLabel = new Label { Text = "Tap the button to confirm everything works.", FontSize = 14, HorizontalOptions = LayoutOptions.Center };

        var checkButton = new Button { Text = "Check", HorizontalOptions = LayoutOptions.Center, WidthRequest = 100 };
        checkButton.Clicked += OnTapClicked;

        StatusLabel = new Label { Text = "Button tapped 0 time(s).", FontSize = 14, HorizontalOptions = LayoutOptions.Center, Margin = new Thickness(0, 5) };

        var goButton = new Button
        {
            Text = "Student lists",
            HorizontalOptions = LayoutOptions.Center,
            Margin = new Thickness(0, 15, 0, 0)
        };

        goButton.Clicked += async (s, e) => {
            await Shell.Current.GoToAsync(nameof(StudentsPage));
        };

        Content = new VerticalStackLayout
        {
            Padding = new Thickness(30),
            Spacing = 15,
            VerticalOptions = LayoutOptions.Center,
            Children = { titleLabel, subLabel, hintLabel, checkButton, StatusLabel, goButton }
        };
    }

    private void OnTapClicked(object sender, EventArgs e)
    {
        _count++;
        StatusLabel.Text = $"Button tapped {_count} time(s).";
    }
}
