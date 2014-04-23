using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace SilverlightApplication1.Views
{
    public partial class 数据与通信之WebClient : Page
    {
        public 数据与通信之WebClient()
        {
            InitializeComponent();
        }

        // 当用户导航到此页面时执行。
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            List<Book> books = new List<Book>() { 
                new Book("Professional ASP.NET 3.5"),
                new Book("ASP.NET AJAX In Action"),
                new Book("Silverlight In Action"),
                new Book("ASP.NET 3.5 Unleashed"),
                new Book("Introducing Microsoft ASP.NET AJAX")
            };

            Books.ItemsSource = books;
        }

        void Books_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Uri endpoint = new Uri(String.Format("http://localhost:25748/BookHandler.ashx?No={0}", Books.SelectedIndex));

            WebClient client = new WebClient();
            client.DownloadStringCompleted += new DownloadStringCompletedEventHandler(client_DownloadStringCompleted);

            client.DownloadStringAsync(endpoint);
        }

        void client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                lblPrice.Text = "价格：" + e.Result;
            }
            else
            {
                lblPrice.Text = e.Error.Message;
            }
        }

    }




    public class Book
    {
        public Book(string bookName)
        {
            Name = bookName;
        }
        public string Name { get; set; }
    }
}
