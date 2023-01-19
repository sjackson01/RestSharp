using RestSharp;
using System.Xml;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            /* Single Object 
            var client = new RestClient("https://my-json-server.typicode.com/typicode/demo/");
            var request = new RestRequest("profile/");
            var queryResult = client.Execute<Test>(request).Data;

            Console.WriteLine(queryResult.name);
            */
            
            /* List Object 
            var client = new RestClient("https://my-json-server.typicode.com/typicode/demo/");
            var request = new RestRequest("comments/");
            var queryResult = client.Execute<List<Test>>(request).Data;

            foreach (var test in queryResult)
            {
              Console.WriteLine(test.id);
              Console.WriteLine(test.body);
              Console.WriteLine(test.postId);
            }
            */
            
            
        }
    }

    public class Test // Object 
    {
        /* Single Object 
             {
               "name": "typicode"
             }
        */
        public string name { get; set; } // Single Object 

        /* List Object
         [
              {
                "id": 1,
                "body": "some comment",
                "postId": 1
              },
              {
                "id": 2,
                "body": "some comment",
                "postId": 1
              }
         ]
         */
        public int id { get; set; } // List Object Comments
        public string body { get; set; } // List Object Comments
        public int postId { get; set; } // List Object Comments 

    }


}
