﻿using System.Text;
using Application.Game.Card.Management;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Game.Server;

public record GetDataQuery(string Host, string Scheme, int GameID, string MAC) : IRequest<string>;

public class GetDataQueryHandler : IRequestHandler<GetDataQuery, string>
{
    private readonly IEventManagerService eventManagerService;

    public GetDataQueryHandler(IEventManagerService eventManagerService)
    {
        this.eventManagerService = eventManagerService;
    }

    public Task<string> Handle(GetDataQuery request, CancellationToken cancellationToken)
    {
        var response = "count=0\n" +
                       "nexttime=180";
        if (!eventManagerService.UseEvents())
        {
            return Task.FromResult(response);
        }
        
        var urlBase = $"{request.Scheme}://{request.Host}/events/";
        var dataString = new StringBuilder();
        var events = eventManagerService.GetEvents();
        var count = 0;
        foreach (var pair in events.Where((E) => E.GameID == request.GameID || E.GameID == -1).Select((@event, i) => new {Value = @event, Index = i}))
        {
            var value = pair.Value;
            var index = pair.Index;
            var fileUrl = $"{urlBase}" +
                $"{pair.Value.GameID switch {-1 => "",_ => pair.Value.GameID+"/" }}" +
                $"{value.Name}";
            var eventString = $"{index},{fileUrl},{value.NotBefore},{value.NotAfter},{value.Md5},{value.Index}";
            dataString.Append(eventString).Append('\n');
            count++;
        }

        response = $"count={count}\n" +
                   "nexttime=1\n" +
                   $"{dataString}";

        return Task.FromResult(response);
    }
}