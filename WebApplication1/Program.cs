using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
var app = builder.Build();

app.MapHub<MyHub>("myHub", options =>
{
    options.Transports = Microsoft.AspNetCore.Http.Connections.HttpTransportType.WebSockets;
});

app.Run();

internal class MyHub : Hub
{
    public override Task OnConnectedAsync()
    {
        return base.OnConnectedAsync();
    }

    public override Task OnDisconnectedAsync(Exception? exception)
    {
        return base.OnDisconnectedAsync(exception);
    }
}