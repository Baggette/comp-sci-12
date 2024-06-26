﻿
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Web.Extensions;
using System.Web.Script.Serialization;
using System.IO;

namespace webapi_test
{


    internal class Program
    {
        static void Main(string[] args)
        {
            //not 100% sure if this is needed, could probably just use a method instead of a constructor
            var postApi = new postApi();
            //store the data in a constructor (at least thats what I think its called I dunno its late)
            string secret_key = File.ReadAllText(@"./api.txt");
            Console.WriteLine("Please enter a prompt");
            string prompt = Console.ReadLine();
            var data = new Data { api_key = , prompt = $"{prompt}", gemini = true };
            
            //api endpoint
            var url = "https://something-lfu0.onrender.com";
            //execute the thing that does the post request
            var task = postApi.SendData(url, data);
            //set the data in a variable
            var response = task.Result;
            var jss = new JavaScriptSerializer();

            var array = jss.Deserialize<object[]>(response);
            var dict = array[0] as Dictionary<string, object>;
            Console.WriteLine(dict["response"]);
            //print to console what the output was
            
        }
    }
}