﻿using Dashboard.Server.Services.Interfaces;

namespace Dashboard.Server.Services.Workers;
public class BlackListWorker : BackgroundService
{
    private readonly IBlackListJWT _blackListJWT;

    public BlackListWorker(IBlackListJWT blackListJWT)
    {
        _blackListJWT = blackListJWT;
    }
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            _blackListJWT.RemoveExpiredToken();
            await Task.Delay(TimeSpan.FromMinutes(30));
        }
    }
}
