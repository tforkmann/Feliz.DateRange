namespace Feliz.DateRange

open Feliz
open Fable.Core.JsInterop
open Fable.Core
open System

[<Erase>]
type dateRangePicker =
    static member inline months (months:int) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "months" months
    static member inline showSelectionPreview (showSelectionPreview:bool) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "showSelectionPreview" showSelectionPreview
    static member inline color (color:string) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "color" color
    static member inline minDate (minDate:DateTimeOffset) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "minDate" minDate
    static member inline maxDate (maxDate:DateTimeOffset) : IDateRangePickerProp =
        Interop.mkDateRangePickerProp "maxDate" maxDate
    static member inline ranges (props: IRangesProp seq) : IDateRangePickerProp =
        (!!("ranges" ==> props))
    static member inline range props : IRangesProp = !!(createObj !!props)


[<Erase>]
type ranges =
    static member inline startDate(startDate: DateTimeOffset) : IRangesProp =
        Interop.mkRangesProp "startDate" startDate
    static member inline endDate(endDate: DateTimeOffset) : IRangesProp =
        Interop.mkRangesProp "endDate" endDate
    static member inline key(key: string) : IRangesProp =
        Interop.mkRangesProp "key" key


