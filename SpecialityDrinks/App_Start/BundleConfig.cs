using System.Web.Optimization;

namespace SpecialityDrinks
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                         "~/Scripts/DataTables/jquery.datatables.js",
                         "~/Scripts/DataTables/dataTables.responsive.js",
                         "~/Scripts/jquery.modal.js", 
                         "~/Scripts/respond.js",
                         "~/scripts/typeahead.bundle.js",
                          "~/Scripts/toastr.js",
                        "~/Scripts/toastrOptions.js"

                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

           // bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
           //,
           //          //"~/Scripts/DataTables/datatables.bootstrap.js" ,
           //           //"~/Scripts/bootstrap.js",
           //          ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/content/reset.css",

                      "~/content/datatables/css/jquery.dataTables.min.css",
                      "~/content/datatables/css/responsive.jqueryui.min.css",
                      "~/content/jquery.modal.css",
                        "~/content/typeahead.css",
                         "~/Content/toastr.css",
                      "~/Content/site.css"));
        }
    }
}
