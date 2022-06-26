using ResourceWiki.Database;
using ResourceWiki.UI.Actions;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace ResourceWiki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Subject> subjects = new List<Subject>();
        List<TextMatter> textmatter = new List<TextMatter>();
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            SearchDatabase db = new SearchDatabase();
            subjects = db.SearchStuff(SearchQuery.Text);
            SearchResults.ItemsSource = subjects;
            SearchResults.DisplayMemberPath = "Chapter";
        }
        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            ShowResults ReSo = new ShowResults();
            textmatter = ReSo.DisplayStuff(SearchResults.Text);
            TextContent.ItemsSource = textmatter;
            TextContent.DisplayMemberPath = "Text";
        }

        private void TextContent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TextContent.DisplayMemberPath = "Text";
        }

        private void SearchQuery_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SearchResults_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
