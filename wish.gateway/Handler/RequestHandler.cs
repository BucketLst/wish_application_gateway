using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;

namespace wish.gateway
{
    public class RequestHandler
    {
        public RequestHandler(){
        }

        public static async Task<string> ProcessRepositories()
        {
        var client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
        client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

        var stringTask = client.GetStringAsync("http://localhost:5050/api/wishlist/getallwishes");

        return await stringTask;        
        }
    }
}