using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api1.Network
{
    public class Email
    {
        public static RestResponse SendSimpleMessage()
        {
            RestClient client = new RestClient();
            client.BaseUrl = "https://api.mailgun.net/v2";
            client.Authenticator = new HttpBasicAuthenticator(
                "api", "key-3ounjw71qfo0ef64y50pmsszcyb6cxo0");
            RestRequest request = new RestRequest();
            request.AddParameter("domain",
                                "app1046.mailgun.org", ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", "Admin <postmaster@app1046.mailgun.org>");
            request.AddParameter("to", "mr.khassenov@mail.ru");
            request.AddParameter("subject", "Hello");
            request.AddParameter("text", "Тестовое сообщение");
            request.Method = Method.POST;
            var result = (RestResponse) client.Execute(request);
            return result;
        }
    }
}