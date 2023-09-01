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
let DateRangeCanvas () =
    DateRange.DateRangecanvas [
        DateRangeCanvas.value "https://www.google.com"
        DateRangeCanvas.size 600
        DateRangeCanvas.bgColor "#ffffff"
        DateRangeCanvas.fgColor "#000000"
        DateRangeCanvas.level "L"
        DateRangeCanvas.includeMargin false
        DateRangeCanvas.imageSettings [
            imageSettings.src "https://msuecar.azureedge.net/logos/favicon-32x32.png"
            imageSettings.height 24
            imageSettings.width 24
            imageSettings.excavate true
        ]
    ]
```

You can find more examples [here](https://tforkmann.github.io/Feliz.DateRange/)