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
using System.Collections.ObjectModel;
using SilverlightApplication1.Model;
using System.Windows.Data;
using System.Windows.Threading;
using System.Xml;
using System.Windows.Browser;
using System.ServiceModel.Syndication;
using System.Windows.Media.Imaging;

namespace SilverlightApplication1.Views
{
    public partial class Search : Page
    {
        const string SEARCH_URI = "http://search.twitter.com/search.atom?q={0}&since_id= {1}";
        private string _lastId = "0";
        private bool _gotLatest = false;
        ObservableCollection<TwitterSearchResult> searchResults = new ObservableCollection<TwitterSearchResult>();
        PagedCollectionView pcv;
        DispatcherTimer _timer;

        public Search()
        {
            InitializeComponent();

            //　 set　interval　value　for　Timer　tick
            double interval = 30.0;

            _timer = new DispatcherTimer();
#if　DEBUG
            interval = 10.0;
#endif
            _timer.Interval = TimeSpan.FromSeconds(interval);
            _timer.Tick += new EventHandler(OnTimerTick);

            //　initialize　 our　PagedCollectionView　with　the　ObservableCollection
            //　and　add　default　sort
            pcv = new PagedCollectionView(searchResults);
            pcv.SortDescriptions.Add(new System.ComponentModel.SortDescription("PublishDate", System.ComponentModel.ListSortDirection.Descending));
            Loaded += new RoutedEventHandler(Search_Loaded);
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            SearchForTweetsEx();
        }

        void Search_Loaded(object sender, RoutedEventArgs e)
        {
            SearchResults.ItemsSource = pcv;　//　bind　the　DataGrid
            _timer.Start();　//　start　the　timer
            SearchForTweetsEx();　//　do　the　 initial　search
        }

        private void SearchForTweets(object sender, RoutedEventArgs e)
        {
            SearchForTweetsEx();
        }

        ///　 <summary>
        ///　Method　that　actually　 does　the　work　to　search　Twitter
        ///　 </summary>
        private void SearchForTweetsEx()
        {
            if (!string.IsNullOrEmpty(SearchTerm.Text))
            {
                _timer.Stop();　//　stop　the　timer　in　case　the　search　takes　 longer　than　the　interval
                //ActivityIndicator.IsActive = true;　//　set　the　visual　indicator 　80
                //　do　the　work　to　 search　twitter　and　handle　the　completed　event
                WebClient proxy = new WebClient();
                proxy.OpenReadCompleted += new OpenReadCompletedEventHandler(OnReadCompleted);
                proxy.OpenReadAsync(new Uri(string.Format(SEARCH_URI, HttpUtility.UrlEncode(SearchTerm.Text), _lastId)));
            }
        }

        ///　<summary>
        ///　Method　that　fires　after　our　SearchForTweetsEx　 runs　and　gets　a　result
        ///　 </summary>
        void OnReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                _gotLatest = false;　//　reset　the　latest　 detector
                XmlReader rdr = XmlReader.Create(e.Result);　//　load　stream　into　a　 reader

                SyndicationFeed feed = SyndicationFeed.Load(rdr);　//　load　syndicated　feed　 (Atom)

                //　parse　each　 item　adding　it　to　our　ObservableCollection
                foreach (var item in feed.Items)
                {
                    searchResults.Add(new TwitterSearchResult() { Author = item.Authors[0].Name, ID = GetTweetId(item.Id), Tweet = item.Title.Text, PublishDate = item.PublishDate.DateTime.ToLocalTime(), Avatar = new BitmapImage(item.Links[1].Uri) });
                    _gotLatest = true;　//　reset　the　fact　that　we　already　have 　the　max　id　needed
                }

                rdr.Close();　//　close 　the　reader
            }
            else
            {
                //　initialize　our　ErrorWindow　with　exception　 details
                ChildWindow errorWindow = new ErrorWindow(e.Error);
                errorWindow.Show();
            }
            //ActivityIndicator.IsActive = false;　//　reset　the　 UI
            _timer.Start();　//　reset　the　 timer
        }

        ///　 <summary>
        ///　Parses　out　the　Tweet　ID 　from　the　tweet
        ///　</summary>
        ///　<param　 name="twitterId"></param>
        ///　 <returns></returns>
        private string GetTweetId(string twitterId)
        {
            string[] parts = twitterId.Split(":".ToCharArray());
            if (!_gotLatest)
            {
                _lastId = parts[2].ToString();
            }
            return parts[2].ToString();
        }

        // 当用户导航到此页面时执行。
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            this.SearchButton.Content = "Clicked!";
            this.SearchButton.Background = new SolidColorBrush(Colors.Red);
        }

    }
}
