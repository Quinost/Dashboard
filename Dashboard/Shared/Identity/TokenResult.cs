﻿using System;

namespace Dashboard.Shared
{
    public class TokenResult
    {
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiry { get; set; }
        public string AccessToken { get; set; }
    }
}