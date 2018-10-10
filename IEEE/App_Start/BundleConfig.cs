using System.Web;
using System.Web.Optimization;

namespace IEEE
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
						"~/Scripts/jquery.validate*"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  //"~/Scripts/bootstrap.js",
					  //"~/Scripts/respond.js"

					  // JavaScript Libraries
					  "~/Content/lib/jquery/jquery.min.js",
					  "~/Content/lib/jquery/jquery-migrate.min.js",
					  "~/Content/lib/bootstrap/js/bootstrap.bundle.min.js",
					  "~/Content/lib/easing/easing.min.js",
					  "~/Content/lib/superfish/hoverIntent.js",
					  "~/Content/lib/superfish/superfish.min.js",
					  "~/Content/lib/wow/wow.min.js",
					  "~/Content/lib/waypoints/waypoints.min.js",
					  "~/Content/lib/counterup/counterup.min.js",
					  "~/Content/lib/owlcarousel/owl.carousel.min.js",
					  "~/Content/lib/isotope/isotope.pkgd.min.js",
					  "~/Content/lib/lightbox/js/lightbox.min.js",
					  "~/Content/lib/touchSwipe/jquery.touchSwipe.min.js",

					  // Contact Form JavaScript File
					  "~/Content/contactform/contactform.js",

					  // Template Main Javascript File
					  "~/Content/js/main.js"
					  ));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  //"~/Content/bootstrap.css",
					  //"~/Content/site.css",

					  // Bootstrap CSS File
					  "~/Content/lib/bootstrap/css/bootstrap.min.css",

					  // Main Stylesheet File
					  "~/Content/css/style.css",
					  
					  // Libraries CSS Files
					  "~/Content/lib/font-awesome/css/font-awesome.min.css",
					  "~/Content/lib/animate/animate.min.css",
					  "~/Content/lib/ionicons/css/ionicons.min.css",
					  "~/Content/lib/owlcarousel/assets/owl.carousel.min.css",
					  "~/Content/lib/lightbox/css/lightbox.min.css"
					  ));
		}
	}
}
