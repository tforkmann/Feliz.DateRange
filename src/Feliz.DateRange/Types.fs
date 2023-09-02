namespace Feliz.DateRange

open Fable.Core
open System
/// This interface allows us to stop adding random props to the react-date-range.
type IDateRangeProp =
    interface
    end

type IDateRangePickerProp =
    interface
    end
type IRangesProp =
    interface
    end
type IStaticRangeProp =
    interface
    end


[<Erase>]
type Range = {
    StartDate: DateTimeOffset
    EndDate: DateTimeOffset
}

[<StringEnum;RequireQualifiedAccess>]
type Direction =
    | Horizontal
    | Vertical