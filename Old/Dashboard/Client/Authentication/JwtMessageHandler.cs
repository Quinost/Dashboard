﻿using Dashboard.Client.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Headers;

namespace Dashboard.Client.Authentication;

public class JwtMessageHandler : DelegatingHandler
{
    private readonly NavigationManager navigationManager;
    private readonly ITokenProvider tokenProvider;

    public JwtMessageHandler(NavigationManager _navigationManager, ITokenProvider _tokenProvider)
    {
        navigationManager = _navigationManager;
        tokenProvider = _tokenProvider;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var token = await tokenProvider.GetAccessToken();

        request.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);

        var retVal = await base.SendAsync(request, cancellationToken);

        if (retVal.StatusCode == System.Net.HttpStatusCode.Unauthorized)
        {
            //need to change for something better
            navigationManager.NavigateTo("/logout", true);
        }

        return retVal;
    }
}
