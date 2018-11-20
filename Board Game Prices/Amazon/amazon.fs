module amazon

open canopy.classic
open canopy.runner.classic
open canopy.runner

open objectRepository
open utilities

let openAndNavigateToAmazonBGCategory _ =
    url strAmazonURL
    clickAndWaitUntilLoad _azShopAll
    elementWithText _azCategories "BoardGames"
    |> clickAndWaitUntilLoad

let runner _ =
    context "Running Price Scrape for Amazon"
    "Navigate to Amazon Boardgames" &&& fun _ -> openAndNavigateToAmazonBGCategory()
    "Scrape Prices"                 &&& fun _ -> ()
    "Compare Prices"                &&& fun _ -> ()
    "Generate items of Interest"    &&& fun _ -> ()