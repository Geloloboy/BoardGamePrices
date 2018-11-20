open OpenQA.Selenium

open canopy.classic
open canopy.types
open canopy.runner.classic
open System
open OpenQA.Selenium.Chrome

let launchChrome _ =
    new ChromeOptions()
    |> fun x -> x.AddArguments(["--start-maximized"; "--incognito"; "--disable-extensions"; "--disable-cache"]); x
    |> ChromeWithOptions
    |> start
    pin FullScreen

[<EntryPoint>]
let main argv =
    launchChrome()
    match argv.[0].ToLower() with
    | "amazon"  -> amazon.runner()
    | "ebay"    -> ()
    | _         -> "Error: The entered site is not yet supported" |> Exception |> raise
    run()
    quit()
    0 // return an integer exit code