using LabAspApi.Models;
using LabAspApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LabAspApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly TestService _testService;

        public TestController(TestService testService)
        {
            _testService = testService;
        }

        // GET: api/test
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestEntity>>> GetTests()
        {
            var result = await _testService.GetTestsAsync();
            return Ok(result);
        }

        // GET: api/test/1
        [HttpGet("{id}")]
        public async Task<ActionResult<TestEntity>> GetTest(int id)
        {
            var result = await _testService.GetTestAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // POST: api/test
        [HttpPost]
        public async Task<ActionResult<TestEntity>> PostTest(TestEntity testEntity)
        {
            var id = await _testService.CreateTestAsync(testEntity);
            testEntity.Id = id;
            return CreatedAtAction(nameof(GetTest), new { id = id }, testEntity);
        }

        // PUT: api/test/1
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTest(int id, TestEntity testEntity)
        {
            if (id != testEntity.Id)
            {
                return BadRequest();
            }

            var affectedRows = await _testService.UpdateTestAsync(id, testEntity.Test);

            if (affectedRows == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

        // PATCH: api/test/1
        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchTest(int id, [FromBody] string newTestValue)
        {
            var affectedRows = await _testService.UpdateTestAsync(id, newTestValue);

            if (affectedRows == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

        // DELETE: api/test/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTest(int id)
        {
            var affectedRows = await _testService.DeleteTestAsync(id);

            if (affectedRows == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}