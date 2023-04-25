using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Shell.Security;
using EPiServer.Web.Routing;
using Optimizely_Project_Alloy.Models.Pages;
using Optimizely_Project_Alloy.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Optimizely_Project_Alloy.Controllers
{
    public class LoginPageController : PageControllerBase<LoginPage>
    {
        protected Injected<UIUserManager> UIUserManager;

        protected Injected<UIUserProvider> UIUserProvider;

        public ActionResult Index(LoginPage currentPage)
        {
            var model = new LoginPageViewModel(currentPage);
            return View(model);
        }

        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginPage currentPage, [FromBody] LoginFormPostbackData loginData)
        {
            var model = new LoginPageViewModel(currentPage);
            if (ModelState.IsValid)
            {
                bool isValid = UISignInManager.Service.SignIn(UIUserProvider.Service.Name,
                    loginData.Username, loginData.Password);

                if (isValid)
                {
                    return Redirect(UrlResolver.Current.GetUrl(ContentReference.StartPage));
                }

                model.Message = "Incorrect user name or password, Please try again!";
            }
            return View(model);
        }
    }
}