using System.Web;
using System.Web.Optimization;

namespace Chimper
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Public/fonts").Include(
                "~/Public/fonts/icomoon/style.css",
                "~/Public/fonts/flaticon/font/flaticon.css"));
            bundles.Add(new StyleBundle("~/Public/css").Include(
                      "~/Public/css/bootstrap.min.css",
                      "~/Public/css/magnific-popup.css",
                      "~/Public/css/jquery-ui.css",
                      "~/Public/css/owl.carousel.min.css",
                      "~/Public/css/owl.theme.default.min.css",
                      "~/Public/css/bootstrap-datepicker.css",
                      "~/Public/css/aos.css",
                      "~/Public/css/style.css"));
        }
    }
}
