using System.Collections.Generic;
using HoneyDoService.Models;
using HoneyDoService.Services;
using Microsoft.AspNetCore.Mvc;

namespace HoneyDoService.Controllers
{
    [Route("api/honeydoitems")]
    [ApiController]
    public class HoneyDoItemController : ControllerBase
    {
        private readonly IDataRepository<HoneyDoItem> _dataRepository;

        public HoneyDoItemController(IDataRepository<HoneyDoItem> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/HoneyDoItems
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<HoneyDoItem> honeyDoItems = _dataRepository.GetAll();
            return Ok(honeyDoItems);
        }

        // GET: api/HoneyDoItems/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            HoneyDoItem honeyDoItem = _dataRepository.Get(id);

            if (honeyDoItem == null)
            {
                return NotFound("The HoneyDoItem record couldn't be found.");
            }

            return Ok(honeyDoItem);
        }

        // POST: api/HoneyDoItems
        [HttpPost]
        public IActionResult Post([FromBody] HoneyDoItem honeyDoItem)
        {
            if (honeyDoItem == null)
            {
                return BadRequest("HoneyDoItem is null.");
            }

            _dataRepository.Add(honeyDoItem);
            return CreatedAtRoute(
                  "Get",
                  new { Id = honeyDoItem.Id },
                  honeyDoItem);
        }

        // PUT: api/HoneyDoItems/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] HoneyDoItem honeyDoItem)
        {
            if (honeyDoItem == null)
            {
                return BadRequest("HoneyDoItem is null.");
            }

            HoneyDoItem honeyDoItemToUpdate = _dataRepository.Get(id);
            if (honeyDoItemToUpdate == null)
            {
                return NotFound("The HoneyDoItem record couldn't be found.");
            }

            _dataRepository.Update(honeyDoItemToUpdate, honeyDoItem);
            return NoContent();
        }

        // DELETE: api/HoneyDoItems/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            HoneyDoItem honeyDoItem = _dataRepository.Get(id);
            if (honeyDoItem == null)
            {
                return NotFound("The HoneyDoItem record couldn't be found.");
            }

            _dataRepository.Delete(honeyDoItem);
            return NoContent();
        }
    }
}