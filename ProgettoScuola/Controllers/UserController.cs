using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProgettoScuola.Helper;
using ProgettoScuola.Models;
using ProgettoScuola.Utils;

namespace ProgettoScuola.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : Controller
{
    private readonly SchoolContext _context;

    public UserController(SchoolContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        var users = await _context.Users.BuildQuery(
            null,
            null,
            (string?)null,
            false,
            1,
            10);
        return Ok(new
        {
            data = users,
            pagination = new
            {
                totalPages = users.TotalPages,
                currentPage = users.PageIndex,
                totalItems = users.TotalItems
            }
        });
    }
    
    
    [HttpGet("parents")]
    public async Task<IActionResult> GetAllParentsWithStudent(
        [FromQuery]int page = 1, 
        [FromQuery]int size = 3,
        [FromQuery]string filters = null,
        [FromQuery]string orderFields = null)
    {
        List<KeyValuePair<string, string>> filterList = null;
        List<Tuple<string, bool>> orderFieldsList = null;

        // if (!string.IsNullOrEmpty(filters))
        // {
        //     filterList = JsonConvert.DeserializeObject<List<KeyValuePair<string, string>>>(filters);
        // }
        //
        // if (!string.IsNullOrEmpty(orderFields))
        // {
        //     orderFieldsList = JsonConvert.DeserializeObject<List<Tuple<string, bool>>>(orderFields);
        // }
        
        
        var parents = await QueryHelper.BuildQuery(
            _context.Parents, 
            q => q
                .Include(p => p.Registry)
                .Include(p => p.Student.Registry),
            filters,
            orderFields,
            false,
            page, 
            size);

    
        return Ok(new
        {
            data = parents,
            pagination = new
            {
                totalPages = parents.TotalPages,
                currentPage = parents.PageIndex,
                totalItems = parents.TotalItems
            }
        });
    }

}