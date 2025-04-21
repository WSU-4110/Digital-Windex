var target = Argument("target", "Default");

Task("Clean")
    .Does(() =>
{
    var binDirs = GetDirectories("./**/bin");
    var objDirs = GetDirectories("./**/obj");
    var allDirs = binDirs.Concat(objDirs);
    CleanDirectories(allDirs);
});

Task("Restore")
    .IsDependentOn("Clean")
    .Does(() =>
{
    NuGetRestore("./DigitalWindex.sln");
});

Task("Build")
    .IsDependentOn("Restore")
    .Does(() =>
{
    MSBuild("./DigitalWindex.sln", settings =>
    {
        settings.SetConfiguration("Release");
        settings.UseToolVersion(MSBuildToolVersion.Default);
        settings.SetPlatformTarget(PlatformTarget.MSIL);
    });
});

Task("Test")
    .IsDependentOn("Build")
    .Does(() =>
{
    DotNetTest("./Digital_Windex_UI_Tests_Kaavya/Digital_Windex_UI_Tests_Kaavya.csproj", new DotNetTestSettings
    {
        Configuration = "Release",
        NoBuild = true
    });
});

Task("Default")
    .IsDependentOn("Test");

RunTarget(target);
