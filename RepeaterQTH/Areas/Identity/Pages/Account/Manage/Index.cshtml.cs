using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RepeaterQTH.Data;

namespace RepeaterQTH.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = "Phone number")]
            public string PhoneNumber { get; set; }

            public string Callsign {  get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var dbUser = await _userManager.GetUserAsync(User);
            var userName = dbUser.UserName;
            var phoneNumber = dbUser.PhoneNumber;
            var callsign = dbUser.Callsign;

            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                Callsign = callsign
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }
            if (Input.Callsign != user.Callsign)
            {
                user.Callsign = Input.Callsign;
            }
            if (Input.PhoneNumber != user.PhoneNumber)
            {
                user.PhoneNumber = Input.PhoneNumber;
            }
            var success = await _userManager.UpdateAsync(user);
            if (!success.Succeeded)
            {
                StatusMessage = "Unexpected error when trying to update user.";
                return RedirectToPage();
            }
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
