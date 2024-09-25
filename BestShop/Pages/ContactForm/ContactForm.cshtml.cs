using BestShop.Data;
using BestShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BestShop.Pages.ContactForm;

public class ContactFormModel : PageModel
{
    private readonly BestShopDbContext _context;

    public ContactFormModel(BestShopDbContext context)
    {
        _context = context;
    }

    public void OnGet()
    {
    }

    [BindProperty]
    public Message Message { get; set; } = default!;

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        Message.CreatedAt = DateTime.Now;
        Message.ModifiedAt = DateTime.Now;
        _context.Messages.Add(Message);
        await _context.SaveChangesAsync();

        return RedirectToPage("/Index");
    }
}
