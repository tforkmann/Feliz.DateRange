module Index

open Elmish
open Feliz
open Feliz.DateRange

type Model = { Txt: string }

type Msg = UpdateTxt of string

let init () = { Txt = "" }, Cmd.none

let update msg (model: Model) =
    match msg with
    | UpdateTxt txt -> { model with Txt = txt }, Cmd.none

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

let view (model: Model) (dispatch: Msg -> unit) =
    Html.div [
        prop.style [ style.height 600; style.width 600 ]
        prop.children [
            DateRangeCanvas()
        ]
    ]
