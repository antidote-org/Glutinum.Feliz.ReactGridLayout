module Demo.Pages.Index

open Demo
open Demo.Pages
open Feliz
open Feliz.Bulma

let private routes = [
    "index", Router.Page.Index
    "basics", Router.Page.Basics
    "no-dragging", Router.Page.NoDragging
    "messy", Router.Page.Messy
    "grid-property", Router.Page.GridProperty
    // "static-element", Router.Page.StaticElement
    // "dynamic-add-remove", Router.Page.DynamicAddRemove
    // "local-storage", Router.Page.LocalStorage
    // "local-storage-responsive", Router.Page.LocalStorageResponsive
    // "min-max-wh", Router.Page.MinMaxWh
    // "dynamic-min-max-wh", Router.Page.DynamicMinMaxWh
    // "no-vertical-compact", Router.Page.NoVerticalCompact
    // "prevent-collision", Router.Page.PreventCollision
    // "error-case", Router.Page.ErrorCase
    // "toolbox", Router.Page.Toolbox
    // "drag-from-outside", Router.Page.DragFromOutside
    // "bounded", Router.Page.Bounded
    // "responsive-bootstrap-style", Router.Page.ResponsiveBootstrapStyle
    // "scale", Router.Page.Scale
    // "allow-overlap", Router.Page.AllowOverlap
    // "resize-handler", Router.Page.ResizeHandler
    // "horizontal", Router.Page.Horizontal
]

type Pages with

    [<ReactComponent>]
    static member Index() =
        Bulma.content [
            Bulma.title.h2 "Examples:"

            Html.ul [
                for (routeName, route) in routes do
                    Html.li [
                        Html.a [
                            route |> Router.toUrl |> prop.href
                            prop.text routeName
                        ]
                    ]
            ]
        ]
