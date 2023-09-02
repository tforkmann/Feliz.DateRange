# Feliz Binding for [react-date-range](https://github.com/hypeserver/react-date-range)

[![Feliz.DateRange on Nuget](https://buildstats.info/nuget/Feliz.DateRange)](https://www.nuget.org/packages/Feliz.DateRange/)
[![Docs](https://github.com/tforkmann/Feliz.DateRange/actions/workflows/Docs.yml/badge.svg)](https://github.com/tforkmann/Feliz.DateRange/actions/workflows/Docs.yml)

## Installation
Install the nuget package
```
dotnet paket add Feliz.DateRange
```

and install the npm package

```
npm install --save react-date-range
```

or use Femto:
```
femto install Feliz.DateRange
```

## Start test app

- Start your test app by cloning this repository and then execute:
```
dotnet run
```

## Example DateRange
Here is an example DateRange
```fs
[<ReactComponent>]
let DateRangePicker (startDate,endDate,setStartDate,setEndDate) =
    DateRange.dateRangePicker [
        dateRangePicker.months 2
        dateRangePicker.showSelectionPreview true
        dateRangePicker.moveRangeOnFirstSelection false
        dateRangePicker.direction Direction.Horizontal
        dateRangePicker.locale DateTime.Locales.German
        dateRangePicker.onChange (fun handler ->
            setStartDate handler.range1.startDate
            setEndDate handler.range1.endDate
        )
        dateRangePicker.ranges [
            dateRangePicker.range [
                ranges.startDate startDate
                ranges.endDate endDate
            ]
        ]
    ]
```

You can find more examples [here](https://tforkmann.github.io/Feliz.DateRange/)