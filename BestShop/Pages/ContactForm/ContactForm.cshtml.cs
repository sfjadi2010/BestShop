using BestShop.Data;
using BestShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

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

    [BindProperty]
    public List<SelectListItem> SubjectList { get; } = new List<SelectListItem>
    {
        new SelectListItem { Value = "", Text = "Please select a subject" },
        new SelectListItem { Value = "Order Inquiry", Text = "Order Inquiry" },
        new SelectListItem { Value = "Order Status", Text = "Order Status" },
        new SelectListItem { Value = "Refund Request", Text = "Refund Request" },
        new SelectListItem { Value = "Job Application", Text = "Job Application" },
        new SelectListItem { Value = "Other", Text = "Other" }
    };

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
