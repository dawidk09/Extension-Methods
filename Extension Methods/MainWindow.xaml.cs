using System.Collections.Generic;
using System.Windows;


namespace ExtensionMethods
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FillOutTheList();
        }

        List<string> words;

        private void FillOutTheList()
        {
             words = new List<string>
            {
            "Ala",
            "has",
            "a cat",
            "Ala has a cat.",
            "one two four"
            };

            foreach (string word in words)
            {
                wordList.Items.Add(word);
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            wordList.Items.Add(newSentence.Text);
            words.Add(newSentence.Text);
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            wordList.Items.Clear();
            FillOutTheList();
        }

        private void CapitalizeFirstLetters_Checked(object sender, RoutedEventArgs e)
        {
            wordList.Items.Clear();
            foreach (string sentence in words)
            {
                wordList.Items.Add(sentence.CapitalizeFirstLetter());
            }
        }

        private void FindNumberOfWords_Checked(object sender, RoutedEventArgs e)
        {
            wordList.Items.Clear();
            foreach (string sentence in words)
            {
                wordList.Items.Add(sentence.FindNumberOfWords());
            }
        }

        private void FindMostFrequentLetter_Checked(object sender, RoutedEventArgs e)
        {
            wordList.Items.Clear();
            foreach (string sentence in words)
            {
                wordList.Items.Add(sentence.FindMostFrequentLetter());
            }
        }

        private void IsSentence_Checked(object sender, RoutedEventArgs e)
        {
            wordList.Items.Clear();
            foreach (string sentence in words)
            {
                wordList.Items.Add(sentence.IsSentence());
            }
        }

        private void RemoveVowels_Checked(object sender, RoutedEventArgs e)
        {
            wordList.Items.Clear();
            foreach (string sentence in words)
            {
                wordList.Items.Add(sentence.RemoveVowels());
            }
        }

        private void CountChars_Checked(object sender, RoutedEventArgs e)
        {
            wordList.Items.Clear();
            foreach (string sentence in words)
            {
                wordList.Items.Add(sentence.CountChars());
            }
        }

        private void CapitalizeEveryOtherLetter_Checked(object sender, RoutedEventArgs e)
        {
            wordList.Items.Clear();
            foreach (string sentence in words)
            {
                wordList.Items.Add(sentence.CapitalizeEveryOtherLetter());
            }
        }
    }
}
