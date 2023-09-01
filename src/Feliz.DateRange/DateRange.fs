namespace Feliz.DateRange

open Fable.Core.JsInterop
open Fable.Core
open Feliz

type Event = Browser.Types.Event

// The !! below is used to "unsafely" expose a prop into an IChartJSProp.
[<Erase>]
type DateRange =
    /// Creates a new ChartJS component.

    static member inline DateRangePicker(props: IDateRangePickerProp seq) =
        Interop.reactApi.createElement (Interop.DateRangePicker, createObj !!props)

    static member inline children(children: ReactElement list) =
        unbox<IDateRangeProp> (prop.children children)