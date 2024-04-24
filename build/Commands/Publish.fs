module EasyBuild.Commands.Publish

open Spectre.Console.Cli
open SimpleExec
open EasyBuild.Workspace
open EasyBuild.Commands.Demo
open BlackFox.CommandLine

type PublishSettings() =
    inherit CommandSettings()

type PublishCommand() =
    inherit Command<PublishSettings>()
    interface ICommandLimiter<PublishSettings>

    override __.Execute(context, settings) =

        DemoCommand().Execute(context, DemoSettings()) |> ignore

        Command.Run(
            "npx",
            CmdLine.empty
            |> CmdLine.appendRaw "gh-pages"
            |> CmdLine.appendPrefix "-d" VirtualWorkspace.demo.dist.``.``
            |> CmdLine.toString
        )

        0
