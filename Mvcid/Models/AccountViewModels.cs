using Portal.Resource;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mvcid.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessageResourceType = typeof(PortalResource), ErrorMessageResourceName = "RegisterViewModel_Title_required")]
        [Display(ResourceType = typeof(PortalResource), Name = "RegisterViewModel_Title_label")]
        public int TitleId { get; set; }
        [Required(ErrorMessageResourceType = typeof(PortalResource),ErrorMessageResourceName ="RegisterViewModel_FirstName_required")]
        [Display(ResourceType = typeof(PortalResource),Name ="RegisterViewModel_FirstName_label")]
        public string FirstName { get; set; }
        [Required(ErrorMessageResourceType = typeof(PortalResource), ErrorMessageResourceName = "RegisterViewModel_SurName_required")]
        [Display(ResourceType = typeof(PortalResource), Name = "RegisterViewModel_SurName_label")]
        public string SurName { get; set; }
        [Display(ResourceType =typeof(PortalResource),Name ="RegisterViewModel_Number_label")]
        public string StreetNumber { get; set; }
        [Display(ResourceType = typeof(PortalResource), Name = "RegisterViewModel_Street_label")]
        public string Street { get; set; }
        [Required(ErrorMessageResourceType = typeof(PortalResource), ErrorMessageResourceName = "RegisterViewModel_City_required")]
        [Display(ResourceType = typeof(PortalResource), Name = "RegisterViewModel_City_label")]
        public string City { get; set; }
        [Display(ResourceType = typeof(PortalResource), Name = "RegisterViewModel_State_label")]
        public string State { get; set; }
        [Display(ResourceType = typeof(PortalResource), Name = "RegisterViewModel_PostalCode_label")]
        public string PostalCode { get; set; }
        [Display(ResourceType = typeof(PortalResource), Name = "RegisterViewModel_Country_label")]
        public string Country { get; set; }
        [Required(ErrorMessageResourceType = typeof(PortalResource), ErrorMessageResourceName = "RegisterViewModel_Captcha_required")]
        public string CaptchaInputText { get; set; }

 




        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessageResourceType = typeof(PortalResource),ErrorMessageResourceName ="ForgotPasswordViewModel_Email_Required")]
        [EmailAddress]
        [Display(ResourceType = typeof(PortalResource),Name ="ForgotPasswordViewModel_Email_label")]
        public string Email { get; set; }
    }
}
