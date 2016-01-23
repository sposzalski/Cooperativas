using System.Web;
using System.Web.Optimization;

namespace Quilmes.Cooperativas.Portal
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            #if !DEBUG
            BundleTable.EnableOptimizations = true;
            #endif

                                             
            bundles.Add(new StyleBundle("~/Content/css/clientStyles")
              .Include("~/assets/plugins/bootstrap/css/bootstrap.min.css")
              .Include("~/assets/css/style.css")
              .Include("~/assets/css/headers/header-default.css")
              .Include("~/assets/css/footers/footer-v1.css")
              .Include("~/assets/plugins/animate.css")
              .Include("~/assets/plugins/line-icons/line-icons.css")
              .Include("~/assets/plugins/font-awesome/css/font-awesome.min.css")
              .Include("~/assets/plugins/fancybox/source/jquery.fancybox.css")
              .Include("~/assets/plugins/revolution-slider/rs-plugin/css/settings.css")
              .Include("~/assets/css/theme-colors/default.css")
              .Include("~/assets/css/theme-skins/dark.css")
              .Include("~/assets/css/custom.css"));


            bundles.Add(new ScriptBundle("~/bundles/scripts/basicScripts")
                .Include("~/assets/plugins/jquery/jquery.min.js")
                //.Include("~/assets/plugins/jquery/jquery-migrate.min.js")
                .Include("~/assets/plugins/bootstrap/js/bootstrap.min.js")

                .Include("~/assets/plugins/back-to-top.js")
                .Include("~/assets/plugins/smoothScroll.js")
                .Include("~/assets/plugins/jquery.parallax.js")
                .Include("~/assets/plugins/fancybox/source/jquery.fancybox.pack.js")
                .Include("~/assets/plugins/owl-carousel/owl-carousel/owl.carousel.js")
                .Include("~/assets/plugins/revolution-slider/rs-plugin/js/jquery.themepunch.tools.min.js")
                .Include("~/assets/plugins/revolution-slider/rs-plugin/js/jquery.themepunch.revolution.min.js")

                .Include("~/assets/js/custom.js")

                .Include("~/assets/js/app.js")
                .Include("~/assets/js/plugins/fancy-box.js")
                .Include("~/assets/js/plugins/owl-carousel.js")
                .Include("~/assets/js/plugins/revolution-slider.js")
                .Include("~/assets/js/plugins/revolution-slider.js")
                .Include("~/assets/js/plugins/style-switcher.js")                
                );

        }
    }
}
