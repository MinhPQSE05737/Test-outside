<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    @*<title>@ViewBag.Title - My ASP.NET Application</title>*@
    @Styles.Render("~/Content/css")
    @Styles.Render("~/Style/css")
    @Scripts.Render("~/bundles/modernizr")

</head>
<body>
    <div class="container body-content">
        <div class="row">
            <div class="col-md-2 imagelogo">
                <img src="https://i.chungta.vn/2017/12/22/LogoFPT-2017-copy-3042-1513928399.jpg" width="100" height="100" alt="">
            </div>
            <div class="col-md-10">
                <img class="image" src="https://www.thuengay.vn/uploads/770x433/ccd6f193b865159bb0df870294a79ecd18d8cf362.png" style="width:100%;height:100px" alt="">
            </div>
        </div>
                
    </div>
     
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
