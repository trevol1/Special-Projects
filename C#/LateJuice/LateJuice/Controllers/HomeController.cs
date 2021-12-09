using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using LateJuice.Models;
using LateJuice.Services;

namespace LateJuice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISpotifyAccountService spotifyAccountService;
        private readonly IConfiguration configuration;
        private readonly ISpotifyService spotifyService;
        public HomeController(ISpotifyAccountService spotifyAccountService, IConfiguration configuration, ISpotifyService spotifyService)
        {
            this.spotifyAccountService = spotifyAccountService;
            this.configuration = configuration;
            this.spotifyService = spotifyService;
        }

        public  IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutMe()
        {
            return View();
        }

        public async Task<IActionResult> Spotify()
        {
            var newReleases = await GetReleases();
            return View(newReleases);
        }

        public async Task<IEnumerable<Release>> GetReleases()
        {
            try
            {
                var token = await spotifyAccountService.GetToken(configuration["Spotify:ClientId"], configuration["Spotify:ClientSecret"]);

                var newReleases = await spotifyService.GetNewReleases("IN", 24, token);

                return newReleases;
            }
            catch (Exception e)
            {
                Debug.Write(e);

                return Enumerable.Empty<Release>();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
