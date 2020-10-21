using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using Concatenator.Mvvm;

namespace Concatenator.ViewModels
{
    class TextRegionViewModel : ObservableObject
    {
        private string content;
        public string Content
        {
            get => content; 
            set => SetProperty(ref content, value); 
        }
        public ICommand Concatenate => new RelayCommand(() =>
        {
            var pattern = @"([^\.!\?\s]+)(\s*)((\r\n)|\n)(\s*)";
            if (!string.IsNullOrWhiteSpace(Content))
            {
                try
                {
                    Content = Regex.Replace(Content, pattern, "$1 ");
                }
                catch { }
            }
        });
        public ICommand Copy => new RelayCommand(() =>
        {
            if(!string.IsNullOrEmpty(Content))
                Clipboard.SetText(Content);
        });
        public ICommand Clear => new RelayCommand(() =>
        {
            Content = string.Empty;
        });
    }
}
