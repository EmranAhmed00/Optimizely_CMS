using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Optimizely_Project_Alloy.Models;
using Optimizely_Project_Alloy.Models.Pages;
using System.ComponentModel.DataAnnotations;

namespace Optimizely_Project_Alloy
{
    [SiteContentType(GUID = "0877D78B-8673-4CF9-9F78-3E50C30C4479",
        GroupName = Optimizely_Project_Alloy.Global.GroupNames.Specialized,
        DisplayName = "Find GDPR API Demo Page")]
    public class GDPRApiDemoPage : SitePageData, ISearchPage
    {
    }
}
