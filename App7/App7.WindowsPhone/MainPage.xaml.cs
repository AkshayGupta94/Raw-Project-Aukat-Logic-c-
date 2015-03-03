using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App7
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string he=myTextBox.Text;
            List<int> index = new List<int>();
            List<string> paperData = new List<string>();
            List<string> paperDataFinal = new List<string>();
            //lol.Source = new Uri("http://akshit.xyz/resultsggsipu");
            HttpClient client = new HttpClient();
            string a= await client.GetStringAsync("http://akshit.xyz/resultsggsipu/dbinteraction/dbConnection.php?"+he );
            for (int i = 0;i<a.Length ;i++)
            {
                if(a[i]=='s')
                {
                    if(a[i + 1] == '0')
                    {
                        index.Add(i);
                    }
                    if (a[i + 1] == '1')
                    {
                        index.Add(i);
                    }
                    if (a[i + 1] == '2')
                    {
                        index.Add(i);
                    }
                    if (a[i + 1] == '3')
                    {
                        index.Add(i);
                    }
                    if (a[i + 1] == '4')
                    {
                        index.Add(i);
                    }
                    if (a[i + 1] == '5')
                    {
                        index.Add(i);
                    }
                    if (a[i + 1] == '6')
                    {
                        index.Add(i);
                    }
                    if (a[i + 1] == '7')
                    {
                        index.Add(i);
                    }
                   
                }

            }
            int j = 9,k; 
            for(j=0; j<index.Count-1;j++)
            {
                paperData.Add(a.Substring(index[j] + 5, ((index[j + 1] - 8)-index[j])));
            }
            string test = a.Substring(index[j]+5);
            paperData.Add(test.Substring(0,test.Length-3));
            string mainData = a.Substring(0, index[0] - 11) + "}";
            Result hi = JsonConvert.DeserializeObject<Result>(mainData);
            Paper data = new Paper();
            
            data.s0 = new List<List<S0>>();
            
            foreach(string hell in paperData)
            {   k=0;
           
                for(j=0;j<hell.Length;j++)
                {
                    if(hell[j]=='}')
                    {
                        paperDataFinal.Add(hell.Substring(k, j-k+1));
                        k = j+2;
                    }
                }
                List<S0> fine = new List<S0>();
                foreach(string temp2 in paperDataFinal)
                {
                    S0 appy = new S0();
                    appy = JsonConvert.DeserializeObject<S0>(temp2);
                    fine.Add(appy);
                }
                paperDataFinal.Clear();
                data.s0.Add(fine);
            }
            topList.DataContext = data.s0;

       }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // string b = lol.Source.ToString();
        }
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }
    }
}
