module Demo.Pages.GridProperty

open Demo.Pages
open Demo.Components
open Demo.Components.ExemplePage
open Glutinum.Feliz.ReactGridLayout
open Glutinum.Feliz.ReactGridLayout.ReactGridLayout
open Feliz
open Feliz.Bulma
open System

let private generateLayout (count : int) =
    [
        for index in 0..count - 1 do
            let w = Math.Ceiling(Random().NextDouble() * 4.0)
            let y = Math.Ceiling(Random().NextDouble() * 4.0) + 1.0

            Layout(
                i = string index,
                x = (index * 2) % 12,
                y = int (Math.Floor(float index / 6.0) * y),
                w = int w,
                h = int y
            )
    ]
    |> ResizeArray

let private generateDOM (layouts : ResizeArray<Layout>) =
    layouts
    |> Seq.toList
    |> List.mapi (fun index layout ->
        // Generate items with properties from the layout, rather than passing the layout directly
        Html.div [
            prop.key (string index)
            prop.custom("data-grid", layout)
            prop.children [
                Bulma.text.div [
                    text.hasTextCentered
                    helpers.isFlex
                    helpers.isJustifyContentCenter
                    helpers.isAlignItemsCenter
                    prop.style [
                        style.height (length.percent 100.0)
                    ]
                    text.hasTextWeightBold
                    prop.text (string index)
                ]
            ]
        ]
    )

type Pages with

    [<ReactComponent>]
    static member GridProperty() =
        let count = 20

        Components.ExemplePage(
            "GridProperty",

            WidthProvider.ReactGridLayout [
                ReactGridLayoutProps.children (generateDOM (generateLayout count))
                ReactGridLayoutProps.className "layout"
                ReactGridLayoutProps.rowHeight 30
                ReactGridLayoutProps.cols 12
            ]
        )
