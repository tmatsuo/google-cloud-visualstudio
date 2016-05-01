﻿using System.Windows;
using System.Windows.Controls;

namespace GoogleCloudExtension.Controls
{
    public class HintedLabel : Control
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
        nameof(Text), typeof(string), typeof(HintedLabel));

        public static readonly DependencyProperty HintProperty = DependencyProperty.Register(
        nameof(Hint), typeof(string), typeof(HintedLabel));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public string Hint
        {
            get { return (string)GetValue(HintProperty); }
            set { SetValue(HintProperty, value); }
        }

        static HintedLabel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HintedLabel),
                new FrameworkPropertyMetadata(typeof(HintedLabel)));
        }
    }
}