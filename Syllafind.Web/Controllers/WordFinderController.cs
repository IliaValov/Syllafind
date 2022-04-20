using Microsoft.AspNetCore.Mvc;
using Syllafind.Service;
using Syllafind.Service.Models;
using System.Net;

namespace Syllafind.Web.Controllers
{
    [Route("api/WordFinder")]
    public class WordFinderController : Controller
    {
        private readonly WordFinderAlgorithm wordFinderAlgorithm;

        public WordFinderController(WordFinderAlgorithm wordFinderAlgorithm)
        {
            this.wordFinderAlgorithm = wordFinderAlgorithm;
        }

        
        [HttpPost]
        [Route("FindWord")]
        [ProducesResponseType (typeof(string),200)]
        public async Task<IActionResult> FindWord([FromBody] WordFilter wordFilter)
        {
            return Ok(this.wordFinderAlgorithm.FindWords(wordFilter));
        }
    }
}
