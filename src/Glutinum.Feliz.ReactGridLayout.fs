namespace rec Glutinum.Feliz.ReactGridLayout

open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Browser.Types

type DOMHighResTimeStamp = System.Double

[<Erase>]
type ReactGridLayout =
    [<Import("WidthProvider", "react-grid-layout")>]
    static member inline WidthProvider(``component``: ReactElement) = nativeOnly

    static member inline ReactGridLayout(props: ReactGridLayout.IReactGridLayoutProps seq) =
        Interop.reactApi.createElement (import "default" "react-grid-layout", createObj !!props)

    static member inline Responsive(props: ReactGridLayout.IResponsiveProps seq) =
        Interop.reactApi.createElement (import "Responsive" "react-grid-layout", createObj !!props)

[<Erase>]
type WidthProvider =
    static member inline ReactGridLayout(props: ReactGridLayout.IReactGridLayoutProps seq) =
        Interop.reactApi.createElement (
            ReactGridLayout.WidthProvider(import "default" "react-grid-layout"),
            createObj !!props
        )

    static member inline Responsive(props: ReactGridLayout.IResponsiveProps seq) =
        Interop.reactApi.createElement (
            ReactGridLayout.WidthProvider(import "Responsive" "react-grid-layout"),
            createObj !!props
        )

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ResizeHandle =
    | s
    | w
    | e
    | n
    | sw
    | nw
    | se
    | ne

module ReactGridLayout =

    [<Erase>]
    [<Interface>]
    type CoreProps<'IDelayedTypeProperty> =
        static member inline className(value: string) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "className" value

        static member inline style(value: obj) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "style" value

        static member inline width(value: float) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "width" value

        static member inline autoSize(value: bool) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "autoSize" value

        static member inline draggableCancel(value: string) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "draggableCancel" value

        static member inline draggableHandle(value: string) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "draggableHandle" value

        static member inline compactType(value: CoreProps.compactType) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "compactType" value

        static member inline rowHeight(value: float) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "rowHeight" value

        static member inline droppingItem(value: CoreProps.droppingItem) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "droppingItem" value

        static member inline verticalCompact(value: bool) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "verticalCompact" value

        static member inline maxRows(value: float) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "maxRows" value

        static member inline isDraggable(value: bool) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "isDraggable" value

        static member inline isResizable(value: bool) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "isResizable" value

        static member inline isBounded(value: bool) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "isBounded" value

        static member inline useCSSTransforms(value: bool) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "useCSSTransforms" value

        static member inline transformScale(value: float) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "transformScale" value

        static member inline allowOverlap(value: bool) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "allowOverlap" value

        static member inline preventCollision(value: bool) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "preventCollision" value

        static member inline isDroppable(value: bool) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "isDroppable" value

        static member inline resizeHandles(value: ResizeArray<ResizeHandle>) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "resizeHandles" value

        static member inline resizeHandle(value: U2<obj, obj>) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "resizeHandle" value

        static member inline onDragStart(value: ItemCallback) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "onDragStart" value

        static member inline onDrag(value: ItemCallback) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "onDrag" value

        static member inline onDragStop(value: ItemCallback) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "onDragStop" value

        static member inline onResizeStart(value: ItemCallback) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "onResizeStart" value

        static member inline onResize(value: ItemCallback) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "onResize" value

        static member inline onResizeStop(value: ItemCallback) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "onResizeStop" value

        static member inline onDrop(value: ResizeArray<Layout> -> Layout -> Event -> unit) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty>
                "onDrop"
                (System.Func<_, _, _, _> value)

        static member inline onDropDragOver
            (value: DragOverEvent -> CoreProps<'IDelayedTypeProperty>)
            =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty>
                "onDropDragOver"
                (System.Func<_, _> value)

        static member inline innerRef(value: IRefValue<HTMLDivElement>) =
            Interop.mkDelayedTypeProperty<'IDelayedTypeProperty> "innerRef" value

    type IReactGridLayoutProps = interface end

    [<Erase>]
    [<Interface>]
    type ReactGridLayoutProps =
        inherit CoreProps<IReactGridLayoutProps>

        static member inline children(value: ReactElement list) =
            Interop.mkDelayedTypeProperty<IReactGridLayoutProps> "children" value

        static member inline cols(value: float) =
            Interop.mkDelayedTypeProperty<IReactGridLayoutProps> "cols" value

        static member inline margin(value: float * float) =
            Interop.mkDelayedTypeProperty<IReactGridLayoutProps> "margin" value

        static member inline containerPadding(value: float * float) =
            Interop.mkDelayedTypeProperty<IReactGridLayoutProps> "containerPadding" value

        static member inline layout(value: ResizeArray<Layout>) =
            Interop.mkDelayedTypeProperty<IReactGridLayoutProps> "layout" value

        static member inline onLayoutChange(value: ResizeArray<Layout> -> unit) =
            Interop.mkDelayedTypeProperty<IReactGridLayoutProps>
                "onLayoutChange"
                (System.Func<_, _> value)

    type IResponsiveProps = interface end

    [<Erase>]
    [<Interface>]
    type ResponsiveProps =
        inherit CoreProps<IResponsiveProps>

        static member inline breakpoint(value: string) =
            Interop.mkDelayedTypeProperty<IResponsiveProps> "breakpoint" value

        static member inline breakpoints(value: ResponsiveProps.breakpoints) =
            Interop.mkDelayedTypeProperty<IResponsiveProps> "breakpoints" value

        static member inline children(value: ReactElement) =
            Interop.mkDelayedTypeProperty<IResponsiveProps> "children" value

        static member inline cols(value: ResponsiveProps.cols) =
            Interop.mkDelayedTypeProperty<IResponsiveProps> "cols" value

        static member inline containerPadding(value: U2<obj, obj>) =
            Interop.mkDelayedTypeProperty<IResponsiveProps> "containerPadding" value

        static member inline layouts(value: Layouts) =
            Interop.mkDelayedTypeProperty<IResponsiveProps> "layouts" value

        static member inline margin(value: U2<obj, obj>) =
            Interop.mkDelayedTypeProperty<IResponsiveProps> "margin" value

        static member inline onBreakpointChange(value: string -> float) =
            Interop.mkDelayedTypeProperty<IResponsiveProps>
                "onBreakpointChange"
                (System.Func<_, _> value)

        static member inline onLayoutChange(value: ResizeArray<Layout> -> Layouts) =
            Interop.mkDelayedTypeProperty<IResponsiveProps>
                "onLayoutChange"
                (System.Func<_, _> value)

        static member inline onWidthChange
            (value: float -> (float * float) -> float -> (float * float))
            =
            Interop.mkDelayedTypeProperty<IResponsiveProps>
                "onWidthChange"
                (System.Func<_, _, _, _> value)

    type IWidthProviderProps = interface end

    [<Erase>]
    [<Interface>]
    type WidthProviderProps =

        static member measureBeforeMount(value: bool) =
            Interop.mkDelayedTypeProperty<IWidthProviderProps> "measureBeforeMount" value

    [<AllowNullLiteral>]
    [<Interface>]
    type ItemCallback =
        [<Emit("$0($1...)")>]
        abstract member Invoke:
            layout: ResizeArray<Layout> *
            oldItem: Layout *
            newItem: Layout *
            placeholder: Layout *
            event: MouseEvent *
            element: HTMLElement ->
                unit

    [<AllowNullLiteral>]
    [<Global>]
    type Layout
        [<ParamObject; Emit("$0")>]
        (
            i: string,
            x: int,
            y: int,
            w: int,
            h: int,
            ?minW: int,
            ?maxW: int,
            ?minH: int,
            ?maxH: int,
            ?moved: bool,
            ?``static``: bool,
            ?isDraggable: bool,
            ?isResizable: bool,
            ?resizeHandles: ResizeArray<ResizeHandle>,
            ?isBounded: bool
        )
        =
        member val i: string = nativeOnly with get, set
        member val x: int = nativeOnly with get, set
        member val y: int = nativeOnly with get, set
        member val w: int = nativeOnly with get, set
        member val h: int = nativeOnly with get, set
        member val minW: int option = nativeOnly with get, set
        member val maxW: int option = nativeOnly with get, set
        member val minH: int option = nativeOnly with get, set
        member val maxH: int option = nativeOnly with get, set
        member val moved: bool option = nativeOnly with get, set
        member val ``static``: bool option = nativeOnly with get, set
        member val isDraggable: bool option = nativeOnly with get, set
        member val isResizable: bool option = nativeOnly with get, set
        member val resizeHandles: ResizeArray<ResizeHandle> option = nativeOnly with get, set
        member val isBounded: bool option = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type Layouts =
        [<EmitIndexer>]
        abstract member Item: P: string -> ResizeArray<Layout> with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type DragOverEvent =
        abstract member altKey: bool with get
        abstract member button: float with get
        abstract member buttons: float with get
        abstract member clientX: float with get
        abstract member clientY: float with get
        abstract member ctrlKey: bool with get
        abstract member metaKey: bool with get
        abstract member movementX: float with get
        abstract member movementY: float with get
        abstract member offsetX: float with get
        abstract member offsetY: float with get
        abstract member pageX: float with get
        abstract member pageY: float with get
        abstract member relatedTarget: EventTarget option with get
        abstract member screenX: float with get
        abstract member screenY: float with get
        abstract member shiftKey: bool with get
        abstract member x: float with get
        abstract member y: float with get
        abstract member getModifierState: keyArg: string -> bool

        abstract member initMouseEvent:
            typeArg: string *
            canBubbleArg: bool *
            cancelableArg: bool *
            viewArg: Window *
            detailArg: float *
            screenXArg: float *
            screenYArg: float *
            clientXArg: float *
            clientYArg: float *
            ctrlKeyArg: bool *
            altKeyArg: bool *
            shiftKeyArg: bool *
            metaKeyArg: bool *
            buttonArg: float *
            relatedTargetArg: EventTarget option ->
                unit

        abstract member detail: float with get
        abstract member view: Window option with get
        abstract member which: float with get

        abstract member initUIEvent:
            typeArg: string *
            ?bubblesArg: bool *
            ?cancelableArg: bool *
            ?viewArg: Window option *
            ?detailArg: float ->
                unit

        abstract member bubbles: bool with get
        abstract member cancelBubble: bool with get, set
        abstract member cancelable: bool with get
        abstract member composed: bool with get
        abstract member currentTarget: EventTarget option with get
        abstract member defaultPrevented: bool with get
        abstract member eventPhase: float with get
        abstract member isTrusted: bool with get
        abstract member returnValue: bool with get, set
        abstract member srcElement: EventTarget option with get
        abstract member target: EventTarget option with get
        abstract member timeStamp: DOMHighResTimeStamp with get
        abstract member ``type``: string with get
        abstract member composedPath: unit -> ResizeArray<EventTarget>
        abstract member initEvent: ``type``: string * ?bubbles: bool * ?cancelable: bool -> unit
        abstract member preventDefault: unit -> unit
        abstract member stopImmediatePropagation: unit -> unit
        abstract member stopPropagation: unit -> unit
        abstract member NONE: obj with get
        abstract member CAPTURING_PHASE: obj with get
        abstract member AT_TARGET: obj with get
        abstract member BUBBLING_PHASE: obj with get
        abstract member nativeEvent: obj with get, set

    module CoreProps =

        [<Global>]
        [<AllowNullLiteral>]
        type droppingItem [<ParamObject; Emit("$0")>] (i: string, w: float, h: float) =

            member val i: string = nativeOnly with get, set
            member val w: float = nativeOnly with get, set
            member val h: float = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type onDropDragOver [<ParamObject; Emit("$0")>] (?w: float, ?h: float) =

            member val w: float option = nativeOnly with get, set
            member val h: float option = nativeOnly with get, set

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type compactType =
            | vertical
            | horizontal

    module ResponsiveProps =

        [<AllowNullLiteral>]
        [<Interface>]
        type breakpoints =
            [<EmitIndexer>]
            abstract member Item: P: string -> float with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type cols =
            [<EmitIndexer>]
            abstract member Item: P: string -> float with get, set
