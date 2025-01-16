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
    static member inline editableDateInputs(editableDateInputs: bool) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "editableDateInputs" editableDateInputs
    static member inline color(color: string) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "color" color
    static member inline locale(locale: ILocale) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "locale"  locale

    static member inline minDate(minDate: DateTimeOffset) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "minDate" minDate

    static member inline maxDate(maxDate: DateTimeOffset) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "maxDate" maxDate

    static member inline staticRanges(props: IStaticRangesProp []) : IDateRangePickerProp =
        (!!("staticRanges" ==> props))
    static member inline inputRanges(props: IInputRangesProp []) : IDateRangePickerProp =
        (!!("inputRanges" ==> props))
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
    static member inline staticRange props : IStaticRangesProp = !!(createObj !!props)
[<Erase>]
type staticRange =

    static member inline label(label: string) : IStaticRangeProp =
        Interop.mkStaticRangeProp "label" label
    static member inline range(range: unit -> {| startDate: DateTimeOffset; endDate: DateTimeOffset |}) : IStaticRangeProp =
        Interop.mkStaticRangeProp "range" range
    static member inline hasCustomRendering(hasCustomRendering: bool) : IStaticRangeProp =
        Interop.mkStaticRangeProp "hasCustomRendering" hasCustomRendering
    static member inline isSelected
        (handler :
            {|
                range1: {| startDate: DateTimeOffset; endDate: DateTimeOffset |}
                range2: {| startDate: DateTimeOffset; endDate: DateTimeOffset |}
            |}
            -> bool): IStaticRangeProp =
        !!("isSelected" ==> handler)

[<Erase>]
type inputRanges =
    static member inline inputRange props : IInputRangesProp = !!(createObj !!props)
[<Erase>]
type inputRange =

    static member inline label(label: string) : IInputRangeProp =
        Interop.mkInputRangeProp "label" label
    static member inline range(range: int -> {| startDate: DateTimeOffset; endDate: DateTimeOffset |}) : IInputRangeProp =
        Interop.mkInputRangeProp "range" range
    static member inline getCurrentValue(range: {| startDate: DateTimeOffset; endDate: DateTimeOffset |} ->int) : IInputRangeProp =
        Interop.mkInputRangeProp "getCurrentValue" range
    static member inline rangeColors(colors: string []) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "rangeColors" colors
    static member inline maxRange(date: DateTimeOffset) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "maxRange" date
    static member inline dragSelectionEnabled (dragSelectionEnabled: bool) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "dragSelectionEnabled" dragSelectionEnabled
    static member inline months(months: int) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "months" months
    static member inline showSelectionPreview(showSelectionPreview: bool) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "showSelectionPreview" showSelectionPreview
    static member inline showMonthAndYearPickers(showMonthAndYearPickers: bool) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "showMonthAndYearPickers" showMonthAndYearPickers
    static member inline showMonthArrow(showMonthArrow: bool) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "showMonthArrow" showMonthArrow
    static member inline moveRangeOnFirstSelection(moveRangeOnFirstSelection: bool) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "moveRangeOnFirstSelection" moveRangeOnFirstSelection
    static member inline color(color: string) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "color" color
    static member inline date(date: DateTimeOffset) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "date" date
    static member inline locale(locale: ILocale) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "locale" locale
