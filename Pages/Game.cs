using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesGame.Models;
using RazorPagesGame.Services;
namespace RazorPagesGame.Pages
{
    public class GameModel : PageModel
    {
        public List<Game> Games = new();
        [BindProperty]
        public Game NewGame { get; set; } = new();

        public void OnGet()
        {
            Games = GameService.GetAll();
        }
        
        // public string GlutenFreeText(Game Game)
        // {
        //     return Game.IsGlutenFree ? "Gluten Free": "Not Gluten Free";
        // }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            GameService.Add(NewGame);
            return RedirectToAction("Get");
        }

        public IActionResult OnPostDelete(int id)
        {
            GameService.Delete(id);
            return RedirectToAction("Get");
        }
    }
}
