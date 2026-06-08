using System;
using Microsoft.Maui.Controls;
using SchoolApp.ViewModels;

namespace SchoolApp;

public partial class MainPage : ContentPage
{
    private int _count = 0;

    public MainPage()
    {
        InitializeComponent();

        // Твой BindingContext для визитки Ansar
        BindingContext = new Person();
    }

    // Твоя рабочая кнопка счетчика "Check"
    private void OnTapClicked(object sender, EventArgs e)
    {
        _count++;
        StatusLabel.Text = $"Button tapped {_count} time(s).";
    }

    // Твоя рабочая кнопка перехода на страницу студентов
    private async void OnOpenStudentsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(StudentsPage));
    }

private void OnShoutClicked(object sender, EventArgs e)
    {
        if (BindingContext is Person p)
            p.Name = p.Name.ToUpper();
    }
}