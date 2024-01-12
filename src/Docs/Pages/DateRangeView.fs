module Docs.Pages.DateRangeView

open Feliz
open Feliz.Bulma
open Feliz.DateRange
open Docs.SharedView
open System
open Fable.DateFunctions
open Feliz.UseElmish
open Elmish
type Msg =
    | SetStartDate of DateTimeOffset
    | SetEndDate of DateTimeOffset

type State =
    { StartDate: DateTimeOffset
      EndDate: DateTimeOffset }

let init () =
    {
        StartDate = DateTimeOffset(2019, 1, 1, 0, 0, 0, TimeSpan.Zero)
        EndDate = DateTimeOffset(2019, 1, 31, 0, 0, 0, TimeSpan.Zero)
    },
    Cmd.none

let update msg (model: State) =
    match msg with
    | SetStartDate date -> { model with StartDate = date }, Cmd.none
    | SetEndDate date -> { model with EndDate = date }, Cmd.none
[<ReactComponent>]
let DateRangePicker (startDate, endDate, setStartDate, setEndDate) =
    let now = DateTime.Now

    DateRange.dateRangePicker [
        dateRangePicker.months 2
        dateRangePicker.showSelectionPreview true
        dateRangePicker.moveRangeOnFirstSelection false
        dateRangePicker.direction Direction.Horizontal
        dateRangePicker.locale DateTime.Locales.German
        dateRangePicker.onChange (fun handler ->
            setStartDate handler.range1.startDate
            setEndDate handler.range1.endDate)
        dateRangePicker.ranges [ dateRangePicker.range [ ranges.startDate startDate; ranges.endDate endDate ] ]
        dateRangePicker.staticRanges [|
            staticRanges.staticRange [
                staticRange.label "Letzer Monat"
                staticRange.range (fun _ -> {|
                    startDate = now.AddMonths(-1).StartOfMonth() |> DateTimeOffset
                    endDate = now.AddMonths(-1).EndOfMonth() |> DateTimeOffset
                |})
                staticRange.hasCustomRendering false
                staticRange.isSelected (fun range -> false)
            ]
            staticRanges.staticRange [
                staticRange.label "Nächster Monat"
                staticRange.range (fun _ -> {|
                    startDate = now.AddDays(1) |> DateTimeOffset
                    endDate = now.AddDays(30) |> DateTimeOffset
                |})
                staticRange.hasCustomRendering false
                staticRange.isSelected (fun range -> false)
            ]
        |]
        dateRangePicker.inputRanges [|
            inputRanges.inputRange [
                inputRange.label "Tage bis heute"
                inputRange.range (fun v -> {|
                    startDate = now.AddDays(-v) |> DateTimeOffset
                    endDate = now |> DateTimeOffset
                |})
                inputRange.getCurrentValue (fun v ->
                    ExternalDateFns.differenceInCalendarDays (now.EndOfDay() |> DateTimeOffset) v.startDate
                )
            ]
            inputRanges.inputRange [
                inputRange.label "Tage ab heute"
                inputRange.range (fun range -> {|
                    startDate = now |> DateTimeOffset
                    endDate = now.AddDays(range) |> DateTimeOffset
                |})
                inputRange.getCurrentValue (fun range ->
                    ExternalDateFns.differenceInCalendarDays range.endDate (now.StartOfDay() |> DateTimeOffset)
                )
            ]
        |]
    ]

let DateRange  (state: State) (dispatch: Msg -> unit) =
    Html.div [
        prop.style [ style.height 600; style.width 600 ]
        prop.children [
            DateRangePicker(
                state.StartDate,
                state.EndDate,
                (fun date -> dispatch (SetStartDate date)),
                (fun date -> dispatch (SetEndDate date))
            )
        ]
    ]


let code =
    """
    DateRange.dateRangePicker [
        dateRangePicker.months 2
        dateRangePicker.showSelectionPreview true
        dateRangePicker.moveRangeOnFirstSelection false
        dateRangePicker.direction Direction.Horizontal
        dateRangePicker.locale DateTime.Locales.German
        dateRangePicker.onChange (fun handler ->
            setStartDate handler.range1.startDate
            setEndDate handler.range1.endDate)
        dateRangePicker.ranges [ dateRangePicker.range [ ranges.startDate startDate; ranges.endDate endDate ] ]
        dateRangePicker.staticRanges [|
            staticRanges.staticRange [
                staticRange.label "Letzer Monat"
                staticRange.range (fun _ -> {|
                    startDate = now.AddMonths(-1).StartOfMonth() |> DateTimeOffset
                    endDate = now.AddMonths(-1).EndOfMonth() |> DateTimeOffset
                |})
                staticRange.hasCustomRendering false
                staticRange.isSelected (fun range -> false)
            ]
            staticRanges.staticRange [
                staticRange.label "Nächster Monat"
                staticRange.range (fun _ -> {|
                    startDate = now.AddDays(1) |> DateTimeOffset
                    endDate = now.AddDays(30) |> DateTimeOffset
                |})
                staticRange.hasCustomRendering false
                staticRange.isSelected (fun range -> false)
            ]
        |]
        dateRangePicker.inputRanges [|
            inputRanges.inputRange [
                inputRange.label "Tage bis heute"
                inputRange.range (fun v -> {|
                    startDate = now.AddDays(-v) |> DateTimeOffset
                    endDate = now |> DateTimeOffset
                |})
                inputRange.getCurrentValue (fun v ->
                    ExternalDateFns.differenceInCalendarDays (now.EndOfDay() |> DateTimeOffset) v.startDate
                )
            ]
            inputRanges.inputRange [
                inputRange.label "Tage ab heute"
                inputRange.range (fun range -> {|
                    startDate = now |> DateTimeOffset
                    endDate = now.AddDays(range) |> DateTimeOffset
                |})
                inputRange.getCurrentValue (fun range ->
                    ExternalDateFns.differenceInCalendarDays range.endDate (now.StartOfDay() |> DateTimeOffset)
                )
            ]
        |]
    ]
    """

let title = Html.text "DateRange"

[<ReactComponent>]
let DateRangeView () =
    let state,dispatch = React.useElmish(init, update, [||])
    Html.div [
        Bulma.content [
            codedView title code (DateRange state dispatch)
        ]
        fixDocsView "DateRange" false
    ]
