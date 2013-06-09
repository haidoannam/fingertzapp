// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RegisterModel.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the RegisterModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace FingertzApp.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The register model.
    /// </summary>
    public class UserRegisterModel
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }
        
        /// <summary>
        /// Gets or sets the company name.
        /// </summary>
        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the short name.
        /// </summary>
        [Display(Name = "Shortname (URL)")]
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or sets the url access.
        /// </summary>
        [Display]
        public string UrlAccess { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }

}