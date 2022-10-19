using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ManagerLib.Database;
using ManagerLib.Models;
using Newtonsoft.Json;

namespace ManagerLib.Manager
{
    public enum DisplayWeak
    { SHOW = 0, REMOVE_ALL_MATCH = 2, REMOVE_HIT_ONLY = 1 }

    public class APIProperties
    {
        public Uri API_LINK { get; set; }
        public int TIMEOUT { get; set; }
        public string TOKEN { get; set; }
        public DisplayWeak DISPLAY_WEAK { get; set; }
    }

    public static class APIManager
    {
        public static APIProperties GetAPIProperties(CommonContext context, int CompCode)
        {
            var token = context.ES_ACCESS_TOKEN.Where(l => l.COMP_CODE == CompCode).OrderByDescending(l => l.AUTO_SEQ_NO).FirstOrDefault();
            var API = new APIProperties();
            var code = context.cor_code.Where(l => l.cor_CodeNo == 2300 && l.cor_CodeKey == "1").FirstOrDefault();

            if (code != null && !String.IsNullOrEmpty(code.cor_Desc_Other))
            {
                API.API_LINK = new Uri(code.cor_Desc_Other);
                API.TIMEOUT = code.cor_ValueI1;
                API.DISPLAY_WEAK = (DisplayWeak)code.cor_ValueI2;
            }
            else
                return null;

            if (token == null || token.EXPIRES < DateTime.Now)
            {
                var result = Get<COMMON_ACCESS_TOKEN>(API, "refresh");

                API.TOKEN = result.access_token;

                var NewToken = new _ES_ACCESS_TOKEN()
                {
                    COMP_CODE = (Int16)CompCode,
                    ACCESS_TOKEN = result.access_token,
                    EXPIRES_IN = 600,
                    USERNAME = "",
                    CLIENT_ID = "",
                    ISSUED = DateTime.Now,
                    EXPIRES = DateTime.Now.AddMinutes(10),
                    STAMP_DTTM = DateTime.Now
                };
                context.ES_ACCESS_TOKEN.Add(NewToken);
                context.SaveChanges();
            }
            else
                API.TOKEN = token.ACCESS_TOKEN;

            return API;
        }

        public static T Get<T>(APIProperties API, string strRelativeUri)
        {
            HttpWebResponse response;
            HttpWebRequest request;

            request = (HttpWebRequest)WebRequest.Create(new Uri(API.API_LINK, strRelativeUri));
            request.Timeout = API.TIMEOUT;
            request.Method = "GET";

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                var stream = response.GetResponseStream();
                var reader = new StreamReader(stream, Encoding.GetEncoding("utf-8"));
                var jsonString = reader.ReadToEnd();

                var result = JsonConvert.DeserializeObject<T>(jsonString);

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: API GET/" + new Uri(API.API_LINK, strRelativeUri), ex);
            }
        }

        public static string Get(APIProperties API, string strRelativeUri)
        {
            HttpWebResponse response;
            HttpWebRequest request;

            request = (HttpWebRequest)WebRequest.Create(new Uri(API.API_LINK, strRelativeUri));
            request.Timeout = API.TIMEOUT;
            request.Method = "GET";

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                var stream = response.GetResponseStream();
                var reader = new StreamReader(stream, Encoding.GetEncoding("utf-8"));
                return reader.ReadToEnd();

            }
            catch (Exception ex)
            {
                throw new Exception("Error: API GET/" + new Uri(API.API_LINK, strRelativeUri), ex);
            }
        }

        public static T Post<T>(APIProperties API, string strRelativeUri, string content)
        {
            HttpWebResponse response;
            HttpWebRequest request;

            request = (HttpWebRequest)WebRequest.Create(new Uri(API.API_LINK, strRelativeUri));
            request.Timeout = API.TIMEOUT;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Headers["Authorization"] = "Bearer " + API.TOKEN;
            var data = Encoding.UTF8.GetBytes(content);
            request.ContentLength = data.Length;

            try
            {
                var stream = request.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();
                response = (HttpWebResponse)request.GetResponse();

                var reader = new StreamReader(response.GetResponseStream());
                var jsonString = reader.ReadToEnd();

                var result = JsonConvert.DeserializeObject<T>(jsonString);

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: API POST/" + new Uri(API.API_LINK, strRelativeUri), ex);
            }
        }
        public static string Post(APIProperties API, string strRelativeUri, string content)
        {
            HttpWebResponse response;
            HttpWebRequest request;

            request = (HttpWebRequest)WebRequest.Create(new Uri(API.API_LINK, strRelativeUri));
            request.Timeout = API.TIMEOUT;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Headers["Authorization"] = "Bearer " + API.TOKEN;
            var data = Encoding.UTF8.GetBytes(content);
            request.ContentLength = data.Length;

            try
            {
                var stream = request.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();
                response = (HttpWebResponse)request.GetResponse();

                var reader = new StreamReader(response.GetResponseStream());
                return reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: API POST/" + new Uri(API.API_LINK, strRelativeUri), ex);
            }
        }
    }
}
