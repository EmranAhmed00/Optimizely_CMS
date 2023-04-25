using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Optimizely_Project_Alloy.Models.Pages
{
   
    [ContentType(DisplayName = "Login Page",
         GUID = "A2FD3A3E-88E7-4372-8889-739BE42AF7BC",
         Description = "Login Page")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "page-type-thumbnail-article.png")]
    [AvailableContentTypes(Availability = Availability.Specific,
         IncludeOn = new[] { typeof(StartPage) },
         ExcludeOn = new[] { typeof(ContainerPage), typeof(ProductPage), typeof(StandardPage), typeof(ISearchPage), typeof(LandingPage) })]
    [Access(Access = EPiServer.Security.AccessLevel.Create, Roles = "WebAdmins")]
    public class LoginPage : StandardPage
    {

    }
}