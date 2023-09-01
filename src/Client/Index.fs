module Index

open Elmish
open Feliz
open Feliz.DateRange
open System

type Model = { Txt: string }

type Msg = UpdateTxt of string

let init () = { Txt = "" }, Cmd.none

let update msg (model: Model) =
    match msg with
    | UpdateTxt txt -> { model with Txt = txt }, Cmd.none

[<ReactComponent>]
let DateRangePicker () =
    DateRange.dateRangePicker [
        dateRangePicker.months 2
        dateRangePicker.showSelectionPreview true
        dateRangePicker.ranges [
            dateRangePicker.range [
                ranges.startDate (DateTimeOffset(2019, 1, 1, 0, 0, 0, TimeSpan.Zero))
                ranges.endDate (DateTimeOffset(2019, 1, 31, 0, 0, 0, TimeSpan.Zero))
                ranges.key "January 2019"
            ]
        ]
    ]

let view (model: Model) (dispatch: Msg -> unit) =
    Html.div [
        prop.style [ style.height 600; style.width 600 ]
        prop.children [ DateRangePicker() ]
    ]
