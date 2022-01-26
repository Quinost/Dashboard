using System;

namespace Dashboard.Server.Services.Interfaces
{
    public interface IBlackListJWT
    {
        void AddToken(string token, DateTime date);
        bool IsTokenOnBlackList(string token);
        void RemoveExpiredToken();
    }
}
