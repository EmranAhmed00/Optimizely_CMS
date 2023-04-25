using EPiServer.Core;

namespace Optimizely_Project_Alloy.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
