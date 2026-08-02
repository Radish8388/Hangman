using System.Windows;

namespace Hangman
{
    /// <summary>
    /// Interaction logic for ChooseLanguage.xaml
    /// </summary>
    public partial class ChooseLanguage : Window
    {
        public int LanguageId { get; set; }
        public ChooseLanguage()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            if (AE.IsChecked == true) LanguageId = 0;
            if (BE.IsChecked == true) LanguageId = 1;
            DialogResult = true;
        }
    }
}
