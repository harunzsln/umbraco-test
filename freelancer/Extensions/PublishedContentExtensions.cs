namespace freelancer.Extensions
{
    public static class PublishedContentExtensions
    {
        public static HomePage? GetHomePage(this IPublishedContent publishedContent) 
        {
            return publishedContent.AncestorOrSelf<HomePage>();

        }

        public static SiteSettings? GetSiteSettings(this IPublishedContent publishedContent) 
        { 
            var homePage = publishedContent.GetHomePage();
            if(homePage == null) return null;
            return homePage.FirstChild<SiteSettings>();
           
        }

    }
}