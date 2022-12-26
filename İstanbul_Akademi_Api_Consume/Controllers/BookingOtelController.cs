using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace İstanbul_Akademi_Api_Consume.Controllers
{
    public class BookingOtelController : Controller
    {
        public async Task< IActionResult> Index()
        {
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/hotels/search?room_number=1&checkin_date=2023-01-27&checkout_date=2023-01-28&units=metric&order_by=popularity&adults_number=2&filter_by_currency=USD&locale=en-gb&dest_id=-1456928&dest_type=city&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&children_ages=5%2C0&children_number=2&page_number=0&include_adjacency=true"),
				Headers =
	{
		{ "X-RapidAPI-Key", "cb5ee15da1mshb46d59d679af3abp1fe84cjsn167590fdc0cc" },
		{ "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
	},
			};
			using (var response = await client.SendAsync(request))
			{
				response.EnsureSuccessStatusCode();
				var body = await response.Content.ReadAsStringAsync();
				Console.WriteLine(body);
			}
			return View();
        }
    }
}
