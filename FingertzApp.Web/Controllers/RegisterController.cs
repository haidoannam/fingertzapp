using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FingertzApp.Web.Controllers
{
    using System.ComponentModel.DataAnnotations;

    using AutoMapper;

    using FingertzApp.Model.Models;
    using FingertzApp.Service.Contracts;
    using FingertzApp.Web.Models;

    public class RegisterController : Controller
    {
        /// <summary>
        /// The _user service.
        /// </summary>
        private IUserService _userService;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterController"/> class.
        /// </summary>
        /// <param name="userService">
        /// The user service.
        /// </param>
        public RegisterController(IUserService userService)
        {
            this._userService = userService;
        }
        
        //
        // GET: /Register/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// The index.
        /// </summary>
        /// <param name="form">
        /// The form.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(UserRegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var user = Mapper.Map<UserRegisterModel, User>(model);
                var result = this._userService.SaveUser(user);
            }
            //if fail

            return View(model);
       
            
           
        }

    }
}
