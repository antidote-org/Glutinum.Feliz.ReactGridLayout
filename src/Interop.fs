namespace Glutinum.Feliz.ReactGridLayout

module Interop =

    let inline mkDelayedTypeProperty<'IDelayedTypeProperty>
        (name: string)
        (value: obj)
        : 'IDelayedTypeProperty
        =
        unbox (name, value)
