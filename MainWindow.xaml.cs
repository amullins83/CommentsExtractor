using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace CommentsRegex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Comments = new ObservableCollection<string>();
            DataContext = this;
            InitializeComponent();
        }

        public ObservableCollection<string> Comments { get; private set; }

        private void extract_Click(object sender, RoutedEventArgs e)
        {
            Comments.Clear();
            CommentsExtractor.CommentsFromText(commentText.Text).
                ForEach(s => Comments.Add(s));
        }
    }
}
