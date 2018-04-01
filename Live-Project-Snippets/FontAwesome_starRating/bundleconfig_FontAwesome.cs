// Added FontAwsome files to project and bundled them to other Content files	

	
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/font-awesome").Include(
                       "~/Content/font-awesome.css",
                       "~/Content/font-awesome.min.css"));
        }
    }
}