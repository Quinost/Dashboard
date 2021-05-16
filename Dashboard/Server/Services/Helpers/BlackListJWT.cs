using Dashboard.Server.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dashboard.Server.Services.Helpers
{
    public class BlackListJWT : IBlackListJWT
    {
        private Dictionary<string, DateTime> _accessToken { get; set; }

        public BlackListJWT()
        {
            _accessToken = new Dictionary<string, DateTime>();
        }

        public void AddToken(string token, DateTime date)
        {
            string accToken = token;
            if (accToken.Contains("bearer"))
            {
                var splited = token.Split(' ');
                accToken = splited[1];
            }
            if (_accessToken.ContainsKey(token))
                return;

            _accessToken.Add(accToken, date);
        }

        public bool IsTokenOnBlackList(string token)
        {
            string accessToken = token;
            if (token.Contains("bearer"))
            {
                var splited = token.Split(' ');
                accessToken = splited[1];
            }

            return _accessToken.Any(x => x.Key == accessToken);
        }


        public void RemoveExpiredToken()
        {
            var now = DateTime.UtcNow;
            var expiredTokens = _accessToken.Where(v => v.Value < now);
            foreach (var token in expiredTokens)
            {
                _accessToken.Remove(token.Key);
            }
        }
    }
}
