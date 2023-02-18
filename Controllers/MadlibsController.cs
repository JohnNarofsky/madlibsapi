using Microsoft.AspNetCore.Mvc;

namespace madlibsapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadlibsController : ControllerBase
    {

        private readonly ILogger<MadlibsController> _logger;

        public MadlibsController(ILogger<MadlibsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Game")]
        public Game Get(int GameId)
        {
            var retval = new Game()
            {
                Id = GameId,
                WordEntries = Enumerable.Range(0, 7).Select(Index =>
                {
                    return new WordEntry()
                    {
                        Id = Index,
                        Tag = Index + 1,
                        Type = (WordType)(new Random().Next(0, 4)),
                        Value = ""
                    };

                }).ToList(),
                Article = "{1} - {2} - {3} - {4} - {5} - {6} - {7}"
            };

            return retval;
        }
    }
}