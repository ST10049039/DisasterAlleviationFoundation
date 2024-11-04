using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace DisasterAlleviationFoundation.Pages
{
    public class IncidentReportModel : PageModel
    {
        [BindProperty]
        public IncidentModel Incident { get; set; }

        public class IncidentModel
        {
            [Required(ErrorMessage = "Location is required.")]
            public string Location { get; set; }

            [Required(ErrorMessage = "Description is required.")]
            public string Description { get; set; }

            [Required(ErrorMessage = "Date is required.")]
            public DateTime Date { get; set; }  // Ensure this property is added

            [Required(ErrorMessage = "Severity is required.")]
            public string Severity { get; set; } // Ensure this property is added
        }


        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // Store incident details in the database
                return RedirectToPage("IncidentSuccess");
            }

            return Page();
        }
    }
}
