using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Protocol;
using Newtonsoft.Json;
using Rystem.OpenAi;
using Rystem.OpenAi.Completion;
using SharedProject.Models;
using static System.Net.Mime.MediaTypeNames;

namespace LegalDebt_ServerSideProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpenAIController : ControllerBase
    {
        private readonly IOpenAi openAi;

        public OpenAIController(IOpenAi openAi)
        {
            this.openAi = openAi;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string message)
        {
            var results = await openAi.Chat
                .RequestWithUserMessage(message)
                .SetMaxTokens(150)
                .WithModel(ChatModelType.Gpt35Turbo)
                .WithTemperature(0)
                .ExecuteAsync();
            return Ok(results.Choices[0].Message.Content);
        } 
    }
}
