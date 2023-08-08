using System;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text.Json;
using HotelProjectUILayer.Dtos.FolowersDto;

namespace HotelProjectUILayer.ViewComponents.Dashboard
{
	public class _DashboardSocialMedia:ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fumutcan-guncu%2F"),
                Headers =
    {
        { "X-RapidAPI-Key", "7e7a205358msh8d9e1bf83dcd427p16ee8ejsna82d433e3c1d" },
        { "X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request2))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonSerializer.Deserialize<ResulttLinkedinFollowersDto>(body);
                ViewBag.Linkendin = values.data.followers_count;
            }


            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/canguncu16"),
                Headers =
    {
        { "X-RapidAPI-Key", "7e7a205358msh8d9e1bf83dcd427p16ee8ejsna82d433e3c1d" },
        { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonSerializer.Deserialize<ResultInstagramFollowersDto>(body);
                return View(values);
            }

            
            
            
        }
	}
}



