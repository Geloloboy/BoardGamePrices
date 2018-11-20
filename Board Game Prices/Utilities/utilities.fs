module utilities

open canopy.classic
open OpenQA.Selenium
open System

open objectRepository

// WAIT FUNCTIONS
let waitUntilLoad _ = waitFor (fun _ -> element _divObj |> fun x -> x.Displayed)

// ELEMENT FUNCTIONS
let clickAndWaitUntilLoad clickObj =
    match box clickObj with
    | :? IWebElement as clickEl     -> clickEl
    | :? string as clickStr         -> element clickStr
    | _                             -> "Error: The entered object is not clickable" |> Exception |> raise
    |> click
    waitUntilLoad()