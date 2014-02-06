<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />
    <title>@ViewData("Title")</title>
    @Styles.Render("~/Content/bootstrapcss")
</head>
<body>
<header class="navbar navbar-inverse navbar-fixed-top bs-docs-nav" role="banner">
  <div class="container">
    <div class="navbar-header">
      <button class="navbar-toggle" type="button" data-toggle="collapse" data-target=".bs-navbar-collapse">
        <span class="sr-only">Toggle navigation</span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
      </button>
      <a href="./" class="navbar-brand">myWorkouts</a>
    </div>
    <nav class="collapse navbar-collapse bs-navbar-collapse" role="navigation">
      <ul class="nav navbar-nav">
                <li>@Html.ActionLink("Home", "Index", "Home")</li>
                <li>@Html.ActionLink("Contact", "Contact", "Home")</li>
            </ul>
      <ul class="nav navbar-nav navbar-right">
            <li>@Html.ActionLink("About", "About", "Home")</li>
      </ul>
    </nav>
  </div>
</header>

<main class="bs-masthead" id="content" role="main">
 <div class="container">
 <div class="span9">
 <div class="row-fluid">
 @RenderBody()
 </div>
 </div>
 </div>
 </main>

 @RenderSection("Scripts", required:= False)

  
</body>
</html>
