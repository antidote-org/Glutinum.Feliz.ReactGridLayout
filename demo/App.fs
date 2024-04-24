module Demo.App

open Demo
open Demo.Pages
open Demo.Pages.Index
open Demo.Pages.Basics
open Demo.Pages.NoDragging
open Demo.Pages.Messy
open Demo.Pages.GridProperty
// open Demo.Pages.StaticElement
// open Demo.Pages.DynamicAddRemove
// open Demo.Pages.LocalStorage
// open Demo.Pages.LocalStorageResponsive
// open Demo.Pages.MinMaxWh
// open Demo.Pages.DynamicMinMaxWh
// open Demo.Pages.NoVerticalCompact
// open Demo.Pages.PreventCollision
// open Demo.Pages.ErrorCase
// open Demo.Pages.Toolbox
// open Demo.Pages.DragFromOutside
// open Demo.Pages.Bounded
// open Demo.Pages.ResponsiveBootstrapStyle
// open Demo.Pages.Scale
// open Demo.Pages.AllowOverlap
// open Demo.Pages.ResizeHandler
// open Demo.Pages.Horizontal
open Feliz
open Feliz.Bulma
open Feliz.Router

[<ReactComponent>]
let App () =
    let (page, setPage) =
        Router.currentUrl ()
        |> Router.parseUrl
        |> React.useState

    let content =
        match page with
        | Router.Page.NotFound
        | Router.Page.Index -> Pages.Index()
        | Router.Page.Basics -> Pages.Basics()
        | Router.Page.NoDragging -> Pages.NoDragging()
        | Router.Page.Messy -> Pages.Messy()
        | Router.Page.GridProperty -> Pages.GridProperty()
        // | Router.Page.StaticElement -> Pages.StaticElement()
        // | Router.Page.DynamicAddRemove -> Pages.DynamicAddRemove()
        // | Router.Page.LocalStorage -> Pages.LocalStorage()
        // | Router.Page.LocalStorageResponsive -> Pages.LocalStorageResponsive()
        // | Router.Page.MinMaxWh -> Pages.MinMaxWh()
        // | Router.Page.DynamicMinMaxWh -> Pages.DynamicMinMaxWh()
        // | Router.Page.NoVerticalCompact -> Pages.NoVerticalCompact()
        // | Router.Page.PreventCollision -> Pages.PreventCollision()
        // | Router.Page.ErrorCase -> Pages.ErrorCase()
        // | Router.Page.Toolbox -> Pages.Toolbox()
        // | Router.Page.DragFromOutside -> Pages.DragFromOutside()
        // | Router.Page.Bounded -> Pages.Bounded()
        // | Router.Page.ResponsiveBootstrapStyle -> Pages.ResponsiveBootstrapStyle()
        // | Router.Page.Scale -> Pages.Scale()
        // | Router.Page.AllowOverlap -> Pages.AllowOverlap()
        // | Router.Page.ResizeHandler -> Pages.ResizeHandler()
        // | Router.Page.Horizontal -> Pages.Horizontal()

    React.fragment [
        Bulma.navbar [
            navbar.isFixedTop
            color.isPrimary
            prop.children [
                Bulma.navbarBrand.div [
                    Bulma.navbarItem.div [
                        color.hasTextBlack
                        text.hasTextWeightSemibold
                        prop.text "Glutinum.Feliz.ReactGridLayout"
                    ]
                ]
            ]
        ]

        Bulma.section [
            React.router [
                router.onUrlChanged (Router.parseUrl >> setPage)
                router.children content
            ]
        ]
    ]
