module Docs.Pages.DateRangeView

open Feliz
open Feliz.Bulma
open Feliz.DateRange
open Docs.SharedView

[<ReactComponent>]
let DateRangeCanvas () =
    DateRange.DateRangecanvas [
        DateRangeCanvas.value "https://www.google.com"
        DateRangeCanvas.size 600
        DateRangeCanvas.bgColor "#ffffff"
        DateRangeCanvas.fgColor "#000000"
        DateRangeCanvas.level "L"
        DateRangeCanvas.includeMargin false
        DateRangeCanvas.imageSettings [
            imageSettings.src "https://msuecar.azureedge.net/logos/favicon-32x32.png"
            imageSettings.height 24
            imageSettings.width 24
            imageSettings.excavate true
        ]
    ]

let DateRange =
    Html.div [
        prop.style [ style.height 800 ]
        prop.children [
            DateRangeCanvas()
        ]
    ]


let code =
    """
    DateRange.DateRangecanvas [
        DateRangeCanvas.value "https://www.google.com"
        DateRangeCanvas.size 600
        DateRangeCanvas.bgColor "#ffffff"
        DateRangeCanvas.fgColor "#000000"
        DateRangeCanvas.level "L"
        DateRangeCanvas.includeMargin false
        DateRangeCanvas.imageSettings [
            imageSettings.src "https://msuecar.azureedge.net/logos/favicon-32x32.png"
            imageSettings.height 24
            imageSettings.width 24
            imageSettings.excavate true
        ]
    ]
    """

let title = Html.text "QR Code"

[<ReactComponent>]
let DateRangeView () =
    Html.div [
        Bulma.content [
            codedView title code DateRange
        ]
        fixDocsView "DateRange" false
    ]