namespace Feliz.DateRange

open Feliz
open Fable.Core.JsInterop
open Fable.Core
open System
open Fable.DateFunctions
open System
open Browser.Types
open Fable.Core
open Feliz
open Browser.Dom
open Fable.Core.JsInterop
[<Erase>]
type dateRangePicker =
    static member inline months(months: int) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "months" months

    static member inline showSelectionPreview(showSelectionPreview: bool) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "showSelectionPreview" showSelectionPreview
    static member inline moveRangeOnFirstSelection(moveRangeOnFirstSelection: bool) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "moveRangeOnFirstSelection" moveRangeOnFirstSelection
    static member inline direction(direction: Direction) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "direction" direction

    static member inline color(color: string) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "color" color
    static member inline locale(locale: ILocale) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "locale"  locale

    static member inline minDate(minDate: DateTimeOffset) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "minDate" minDate

    static member inline maxDate(maxDate: DateTimeOffset) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "maxDate" maxDate

    static member inline staticRanges(props: IStaticRangeProp []) : IDateRangePickerProp =
        (!!("staticRanges" ==> props))
    static member inline ranges(props: IRangesProp seq) : IDateRangePickerProp = (!!("ranges" ==> props))

    static member inline range props : IRangesProp = !!(createObj !!props)

    static member inline onChange
        (handler :
        {|
            range1: {| startDate: DateTimeOffset; endDate: DateTimeOffset |}
            range2: {| startDate: DateTimeOffset; endDate: DateTimeOffset |}
        |}
         -> unit)
        : IDateRangePickerProp =
        !!("onChange" ==> handler)


[<Erase>]
type ranges =
    static member inline startDate(startDate: DateTimeOffset) : IRangesProp =
        Interop.mkRangesProp "startDate" startDate

    static member inline endDate(endDate: DateTimeOffset) : IRangesProp = Interop.mkRangesProp "endDate" endDate
    static member inline key(key: string) : IRangesProp = Interop.mkRangesProp "key" key

[<Erase>]
type staticRanges =
    static member inline label(label: string) : IStaticRangeProp =
        Interop.mkStaticRangeProp "label" label

    static member inline range(range: {| startDate: DateTimeOffset; endDate: DateTimeOffset |}) : IStaticRangeProp =
        Interop.mkStaticRangeProp "range" range
    static member inline hasCustomRendering(hasCustomRendering: bool) : IStaticRangeProp =
        Interop.mkStaticRangeProp "hasCustomRendering" hasCustomRendering
    //make isSelected a function that takes a handler and returns a bool
    static member inline isSelected(handler: unit -> bool) : IStaticRangeProp =
        Interop.mkStaticRangeProp "isSelected" handler
