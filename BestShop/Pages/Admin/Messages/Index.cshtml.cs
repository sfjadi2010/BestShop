using BestShop.Data;
using BestShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BestShop.Pages.Admin.Messages
{
    public class IndexModel : PageModel
    {
        private readonly BestShopDbContext _context;

        public IndexModel(BestShopDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<Message> Messages { get; set; } = default!;

        public async Task OnGet()
        {
            Messages = await _context.Messages.ToListAsync();
        }
    }
}
