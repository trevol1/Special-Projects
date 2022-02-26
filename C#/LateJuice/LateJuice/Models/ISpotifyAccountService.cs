using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LateJuice.Services
{
    public interface ISpotifyAccountService
    {
        Task<string> GetToken(string clientId, string clientSecret);
    }
}