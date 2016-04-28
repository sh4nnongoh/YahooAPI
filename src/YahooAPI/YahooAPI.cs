using System.Net; // WebClient
using System.Globalization; // CultureInfo

namespace YahooAPI
{
    public class YahooAPI
    {
        private static readonly WebClient webClient = new WebClient();

        private const string UrlTemplate = "http://finance.yahoo.com/d/quotes.csv?s={0}&f={1}";

        private static double ParseDouble(string value)
        {
            return double.Parse(value.Trim(), CultureInfo.InvariantCulture);
        }

        private static string[] GetDataFromYahoo(string symbol, string fields)
        {
            // string request = string.Format(UrlTemplate, symbol, fields);

            // string rawData = webClient.DownloadString(request).Trim();

            // return rawData.Split(',');
            return new string[]{"Some string from yahoo!" };
        }

        public double GetBid(string symbol)
        {
            //return ParseDouble(GetDataFromYahoo(symbol, "b3")[0]);
            return 1.0;
        }

        public double GetAsk(string symbol)
        {
            //return ParseDouble(GetDataFromYahoo(symbol, "b2")[0]);
            return 2.0;
        }

        public string GetCapitalization(string symbol)
        {
            //return GetDataFromYahoo(symbol, "j1")[0];
            return "Get Capitalization";
        }

        public string[] GetValues(string symbol, string fields)
        {
            //return GetDataFromYahoo(symbol, fields);
            return new string[] { "Some value from yahoo!" };
        }
    }
}
