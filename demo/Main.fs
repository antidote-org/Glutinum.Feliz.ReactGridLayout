module Demo.Main

open Feliz
open Browser.Dom
open Fable.Core.JsInterop

importSideEffects "./../node_modules/react-grid-layout/css/styles.css"
importSideEffects "./../node_modules/react-resizable/css/styles.css"
importSideEffects "./style.scss"

ReactDOM.createRoot(document.getElementById ("root")).render (App.App())
