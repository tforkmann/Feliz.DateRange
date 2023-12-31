namespace Feliz.DateRange

open Fable.Core
open Fable.Core.JsInterop

[<Erase; RequireQualifiedAccess>]
module Interop =
    let inline mkDateRangePickerProp (key: string) (value: obj) : IDateRangePickerProp = unbox (key, value)
    let inline mkRangesProp (key: string) (value: obj) : IRangesProp = unbox (key, value)
    let inline mkStaticRangeProp (key: string) (value: obj) : IStaticRangeProp = unbox (key, value)
    let inline mkInputRangeProp (key: string) (value: obj) : IInputRangeProp = unbox (key, value)

    let DateRangePicker obj = import "DateRangePicker" "react-date-range"