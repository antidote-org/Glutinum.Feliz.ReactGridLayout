module Demo.Pages.Basics

open Demo.Pages
open Demo.Components
open Demo.Components.ExemplePage
open Glutinum.Feliz.ReactGridLayout
open Glutinum.Feliz.ReactGridLayout.ReactGridLayout
open Feliz
open Feliz.Bulma
open System
open Glutinum.Feliz.Victory
open Fable.Core.JsInterop

open type Glutinum.Feliz.Victory.Exports

type private Data =
    {
        x: int
        y: int
        y0: int
    }

let private data =
    [
        {
            x = 1
            y = 2
            y0 = 0
        }
        {
            x = 2
            y = 3
            y0 = 1
        }
        {
            x = 3
            y = 5
            y0 = 1
        }
        {
            x = 4
            y = 4
            y0 = 2
        }
        {
            x = 5
            y = 6
            y0 = 2
        }
    ]

let private layouts =
    [
        Layout(i = "bar-chart", x = 0, y = 0, w = 6, h = 6)
        Layout(i = "area-chart", x = 6, y = 0, w = 6, h = 6)
        Layout(i = "amount", x = 0, y = 6, w = 4, h = 5, minW = 4, minH = 5)
    ]
    |> ResizeArray

let private content =
    [
        Html.div [
            prop.key "bar-chart"
            prop.children [
                VictoryChart [
                    victoryChart.custom "domainPadding" {| x = 20 |}
                    victoryChart.children [
                        VictoryBar [
                            VictoryBar.data data
                            VictoryBar.barRatio 0.6
                        ]
                    ]
                ]
            ]
        ]
        Html.div [
            prop.key "area-chart"
            prop.children [
                VictoryChart [
                    victoryChart.children [
                        VictoryArea [
                            VictoryArea.data data
                            VictoryArea.labels (fun o ->
                                let data = unbox<Data> o?datum
                                string data.y
                            )
                        ]
                    ]
                ]
            ]
        ]
        Html.div [
            prop.key "amount"
            prop.style [
                style.display.flex
                style.justifyContent.center
                style.alignItems.center
            ]
            prop.children [
                Bulma.card [
                    Bulma.cardContent [
                        Bulma.title.h2 [
                            prop.text "Amount"
                        ]
                        Bulma.title.h1 [
                            prop.text "1000"
                        ]
                    ]
                ]
            ]
        ]
    ]

type Pages with

    [<ReactComponent>]
    static member Basics() =
        let count = 20

        Components.ExemplePage(
            "Basics",

            WidthProvider.ReactGridLayout [
                ReactGridLayoutProps.layout layouts
                ReactGridLayoutProps.children content
                ReactGridLayoutProps.className "layout"
                ReactGridLayoutProps.rowHeight 30
                ReactGridLayoutProps.cols 12
                ReactGridLayoutProps.maxRows 20
            ]
        )
