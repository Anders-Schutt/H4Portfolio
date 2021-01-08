using Xamarin.Forms;

namespace H4Portfolio
{
    public partial class MainPage
    {
        public MainPage()
        {
            var webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://anders.nntq.net"
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            
            Content = new StackLayout
            {
                Children =
                {
                    webView
                }
            };
        }
    }
}