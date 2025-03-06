Imports System.Web.Optimization

Module BundleConfig
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)
        bundles.Add(New ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryvalunobtrusive").Include("~/Scripts/jquery.validate.unobtrusive.min.js"))

        bundles.Add(New StyleBundle("~/Content/css").Include("~/Content/Style.css"))
    End Sub

End Module
