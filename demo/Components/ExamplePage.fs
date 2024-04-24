module Demo.Components.ExemplePage

open Demo
open Demo.Components
open Feliz
open Feliz.Bulma

type Components with

    [<ReactComponent>]
    static member ExemplePage(title : string, content : ReactElement) =
        React.fragment [
            Bulma.title.h2 title

            Html.p []

            content
        ]
