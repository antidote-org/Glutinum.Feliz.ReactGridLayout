namespace Demo

open Feliz.Router
open System

[<RequireQualifiedAccess>]
module Router =

    [<RequireQualifiedAccess>]
    type Page =
        | Index
        | Basics
        | NoDragging
        | Messy
        | GridProperty
        | StaticElement
        | DynamicAddRemove
        | LocalStorage
        | LocalStorageResponsive
        | MinMaxWh
        | DynamicMinMaxWh
        | NoVerticalCompact
        | PreventCollision
        | ErrorCase
        | Toolbox
        | DragFromOutside
        | Bounded
        | ResponsiveBootstrapStyle
        | Scale
        | AllowOverlap
        | ResizeHandler
        | Horizontal
        | NotFound

    let parseUrl =
        function
        | []
        | [ "index" ] -> Page.Index
        | [ "basics" ] -> Page.Basics
        | [ "no-dragging" ] -> Page.NoDragging
        | [ "messy" ] -> Page.Messy
        | [ "grid-property" ] -> Page.GridProperty
        | [ "static-element" ] -> Page.StaticElement
        | [ "dynamic-add-remove" ] -> Page.DynamicAddRemove
        | [ "local-storage" ] -> Page.LocalStorage
        | [ "local-storage-responsive" ] -> Page.LocalStorageResponsive
        | [ "min-max-wh" ] -> Page.MinMaxWh
        | [ "dynamic-min-max-wh" ] -> Page.DynamicMinMaxWh
        | [ "no-vertical-compact" ] -> Page.NoVerticalCompact
        | [ "prevent-collision" ] -> Page.PreventCollision
        | [ "error-case" ] -> Page.ErrorCase
        | [ "toolbox" ] -> Page.Toolbox
        | [ "drag-from-outside" ] -> Page.DragFromOutside
        | [ "bounded" ] -> Page.Bounded
        | [ "responsive-bootstrap-style" ] -> Page.ResponsiveBootstrapStyle
        | [ "scale" ] -> Page.Scale
        | [ "allow-overlap" ] -> Page.AllowOverlap
        | [ "resize-handler" ] -> Page.ResizeHandler
        | [ "horizontal" ] -> Page.Horizontal
        | _ -> Page.NotFound

    let toUrl (page: Page) =
        match page with
        | Page.Index -> Router.format []
        | Page.Basics -> Router.format [ "basics" ]
        | Page.NoDragging -> Router.format [ "no-dragging" ]
        | Page.Messy -> Router.format [ "messy" ]
        | Page.GridProperty -> Router.format [ "grid-property" ]
        | Page.StaticElement -> Router.format [ "static-element" ]
        | Page.DynamicAddRemove -> Router.format [ "dynamic-add-remove" ]
        | Page.LocalStorage -> Router.format [ "local-storage" ]
        | Page.LocalStorageResponsive -> Router.format [ "local-storage-responsive" ]
        | Page.MinMaxWh -> Router.format [ "min-max-wh" ]
        | Page.DynamicMinMaxWh -> Router.format [ "dynamic-min-max-wh" ]
        | Page.NoVerticalCompact -> Router.format [ "no-vertical-compact" ]
        | Page.PreventCollision -> Router.format [ "prevent-collision" ]
        | Page.ErrorCase -> Router.format [ "error-case" ]
        | Page.Toolbox -> Router.format [ "toolbox" ]
        | Page.DragFromOutside -> Router.format [ "drag-from-outside" ]
        | Page.Bounded -> Router.format [ "bounded" ]
        | Page.ResponsiveBootstrapStyle -> Router.format [ "responsive-bootstrap-style" ]
        | Page.Scale -> Router.format [ "scale" ]
        | Page.AllowOverlap -> Router.format [ "allow-overlap" ]
        | Page.ResizeHandler -> Router.format [ "resize-handler" ]
        | Page.Horizontal -> Router.format [ "horizontal" ]
        | Page.NotFound -> Router.format [ "not-found" ]
