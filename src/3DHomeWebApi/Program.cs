using System;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace DHomeWebApi
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var config = new HttpSelfHostConfiguration(new Uri(@"http://127.0.0.1:7777"));

			config.Routes.MapHttpRoute(
				"API Default", "api/{controller}/{id}",
				new { id = RouteParameter.Optional });

			using (HttpSelfHostServer server = new HttpSelfHostServer(config))
			{
				server.OpenAsync().Wait();
				Console.WriteLine("3DWebApi Server is Running...");
				Console.ReadLine();
			}
		}
	}
}