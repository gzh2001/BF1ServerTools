﻿using BF1ServerTools.SDK;

namespace BF1ServerTools.Views;

/// <summary>
/// AuthView.xaml 的交互逻辑
/// </summary>
public partial class AuthView : UserControl
{
    public AuthView()
    {
        InitializeComponent();
        this.DataContext = this;
        MainWindow.WindowClosingEvent += MainWindow_WindowClosingEvent;
    }

    private void MainWindow_WindowClosingEvent()
    {

    }
}