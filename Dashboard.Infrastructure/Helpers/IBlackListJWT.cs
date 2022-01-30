namespace Dashboard.Infrastructure.Helpers
{
    public interface IBlackListJWT
    {
        void AddToken(string token, DateTime date);
        bool IsTokenOnBlackList(string token);
        void RemoveExpiredToken();
    }
}
