using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;
using System.Text;
using System.Web.Script.Serialization;

namespace Infrastructure.Web.FacebookAPI
{

    public class User
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string gender { get; set; }
        public string id { get; set; }
        public string picture { get; set; }
        public string email { get; set; }
        public string birthday { get; set; }

    }




    public class OAuth
    {
        private const string _url = "https://graph.facebook.com/oauth/authorize?type=web_server&client_id={0}&redirect_uri={1}&scope=email";//,user_birthday,user_hometown,user_relationships";//,user_relationship_status
        private string key = "";
        private string secret = "";

        public OAuth(string Key, string Secret)
        {
            this.key = Key;
            this.secret = Secret;
        }

        public string UrlRedirect(string urlProcess)
        {
            return string.Format(_url, key, urlProcess);
        }



        public User UserData(string code, string urlProcess)
        {
            string url = "https://graph.facebook.com/oauth/access_token?client_id={0}&redirect_uri={1}&client_secret={2}&code={3}";
            try
            {
                WebRequest request = WebRequest.Create(string.Format(url, key, urlProcess, secret, code));
                WebResponse response = request.GetResponse();
                using (var stream = response.GetResponseStream())
                {
                    Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
                    using (StreamReader streamReader = new StreamReader(stream, encode))
                    {
                        string accessToken = streamReader.ReadToEnd().Replace("access_token=", "");
                        streamReader.Close();
                        response.Close();
                        using (var wc = new System.Net.WebClient())
                        {
                            var data = wc.DownloadString("https://graph.facebook.com/me?access_token=" + accessToken);
                            User user = null;

                            JavaScriptSerializer jsSer = new JavaScriptSerializer();
                            // deserialize user
                            user = jsSer.Deserialize<User>(data);

                            if (user != null)
                            {
                                user.picture = user.link.Replace("www.", "graph.") + "/picture";

                                //string familyData = wc.DownloadString("https://graph.facebook.com/me/family?access_token=" + accessToken);

                                //// deserialize user family entries
                                //FamilyUserEntriesResponse familyResponse = jsSer.Deserialize<FamilyUserEntriesResponse>(familyData);
                                //user.familyEntries = familyResponse.data;

                                //// get family user obj for each family member
                                //foreach (FamilyUserEntry fue in user.familyEntries)
                                //{
                                //    string famEntryUser = wc.DownloadString("https://graph.facebook.com/" + fue.id + "?access_token=" + accessToken);
                                //    fue.user = jsSer.Deserialize<User>(famEntryUser);
                                //    if (fue.user != null)
                                //    {
                                //        fue.user.picture = fue.user.link.Replace("www.", "graph.") + "/picture";
                                //    }
                                //}

                            }
                            return user;
                        }
                    }
                }
            }
            catch (Exception ex) { return null; }
        }
    }
}
