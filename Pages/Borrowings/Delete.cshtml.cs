﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ciciovan_Bogdan_Ionut_Lab2.Data;
using Ciciovan_Bogdan_Ionut_Lab2.Models;

namespace Ciciovan_Bogdan_Ionut_Lab2.Pages.Borrowings
{
    public class DeleteModel : PageModel
    {
        private readonly Ciciovan_Bogdan_Ionut_Lab2Context _context;

        public DeleteModel(Ciciovan_Bogdan_Ionut_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Borrowing Borrowing { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Borrowing = await _context.Borrowing
                .Include(b => b.Member)
                .Include(b => b.Book)
                .ThenInclude(book => book.Author)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Borrowing == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Borrowing = await _context.Borrowing.FindAsync(id);

            if (Borrowing != null)
            {
                _context.Borrowing.Remove(Borrowing);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
