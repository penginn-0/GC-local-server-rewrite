using System.Text;
using Application.Game.Server;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;

namespace MainServer.Controllers.Game;

[ApiController]
[Route("server")]
public class ServerController : BaseController<ServerController>
{
    [HttpGet("cursel.php")]
    public ActionResult<string> GetCursel()
    {
        return Ok("1\n");
    }

    [HttpGet("gameinfo.php")]
    public ActionResult<string> GetGameInfo()
    {
        return Ok("0\n" +
               "3\n" +
               "301000,test1\n" +
               "302000,test2\n" +
               "303000,test3");
    }

    [HttpGet("certify.php")]
    public async Task<ContentResult> Certify(string? gid, string? mac, 
        [FromQuery(Name = "r")]string? random, [FromQuery(Name = "md")]string? md5)
    {
        var host = Request.Host.Value;
        var command = new CertifyCommand(gid, mac, random, md5, host);
        var result = await Mediator.Send(command);
        var shiftJis = Encoding.GetEncoding(932);
        var originalBytes = Encoding.UTF8.GetBytes(result);
        var converted = Encoding.Convert(Encoding.Default, shiftJis, originalBytes);
        result = shiftJis.GetString(converted);
        //Response.ContentType = "text/plain; charset=shift_jis";

        return Content(result, "text/plain", shiftJis);
    }

    [HttpGet("data.php")]
    public async Task<ActionResult<string>> GetData(
        [FromQuery] string? MAC,
        [FromQuery(Name = "GID")] int GameID = -1)
    {

        if (GameID is -1 || MAC is null)
        {
            return BadRequest();
        }
        var query = new GetDataQuery(Request.Host.Value, Request.Scheme, GameID, MAC);
        return Ok(await Mediator.Send(query));
    }
}