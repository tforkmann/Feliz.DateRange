namespace Feliz.DateRange

open Fable.Core
open Fable.Core.JsInterop
open Browser.Types

[<Erase; RequireQualifiedAccess>]
module Interop =
    let inline mkDateRangePickerProp (key: string) (value: obj) : IDateRangeCanvasProp = unbox (key, value)
    let inline mkImageSettingsPropProp (key: string) (value: obj) : IImageSettingsProp = unbox (key, value)

    let DateRangePicker obj = import "DateRangePicker" "react-date-range"