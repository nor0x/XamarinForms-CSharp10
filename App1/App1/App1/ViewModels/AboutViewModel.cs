﻿namespace App1.ViewModels;

public class AboutViewModel : BaseViewModel
{
    public AboutViewModel()
    {
        Title = "About";
        OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
    }

    public ICommand OpenWebCommand { get; }
}