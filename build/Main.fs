module EasyBuild.Main

open Spectre.Console.Cli
open EasyBuild.Commands.Demo
open EasyBuild.Commands.Release
open SimpleExec

[<EntryPoint>]
let main args =

    Command.Run("dotnet", "husky install")

    let app = CommandApp()

    app.Configure(fun config ->
        config.Settings.ApplicationName <- "./build.sh"

        config.AddCommand<DemoCommand>("demo") |> ignore
        config.AddCommand<ReleaseCommand>("release") |> ignore
    )

    app.Run(args)
