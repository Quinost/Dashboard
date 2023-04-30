namespace Dashboard.Infrastructure.Helpers
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
            if (accToken.Contains("bearer", StringComparison.CurrentCultureIgnoreCase))
            {
                var splited = token.Split(' ');
                if (splited.Count() != 2)
                    return;
                accToken = splited[1];
            }
            if (_accessToken.ContainsKey(token))
                return;

            _accessToken.Add(accToken, date);
        }

        public bool IsTokenOnBlackList(string token)
        {
            string accessToken = token;
            if (token.Contains("bearer", StringComparison.CurrentCultureIgnoreCase))
            {
                var splited = token.Split(' ');
                if (splited.Count() != 2)
                    return false;
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
