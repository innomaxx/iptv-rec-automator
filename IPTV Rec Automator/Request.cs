
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IPTV_Rec_Automator
{
    class Request
    {
        private string url;

        public Request(string url)
        {
            if (!url.StartsWith("http"))
            {
                url = "http://" + url;
            }

            this.url = url;
        }

        public Request (Uri url)
        {
            this.url = url.ToString();
        }

        public string Get()
        {
            string body = String.Empty;

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse res = (HttpWebResponse)req.GetResponse())
            using (Stream stream = res.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                body = reader.ReadToEnd();
            }

            return body;
        }

        public bool Probe()
        {
            bool result = false;

            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse res = (HttpWebResponse)req.GetResponse())
                {
                    if (res.StatusCode == HttpStatusCode.OK)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        public Tuple<bool, string> ProbeExt()
        {
            Tuple<bool, string> result;

            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse res = (HttpWebResponse)req.GetResponse())
                {
                    if (res.StatusCode == HttpStatusCode.OK)
                    {
                        result = CreateTuple(true);
                    } else
                    {
                        result = CreateTuple(false, res.StatusCode.ToString());
                    }
                }
            } catch (Exception ex)
            {
                result = CreateTuple(false, ex.Message);
            }

            return result;
        }

        private Tuple <bool, string> CreateTuple (bool p1, string p2 = "")
        {
            return new Tuple<bool, string>(p1, p2);
        }
    }
}
