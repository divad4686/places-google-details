// Learn more about F# at http://fsharp.org
open System
open System.Threading
open Suave
open FSharp.Data

type NugetStats = HtmlProvider<"https://www.nuget.org/packages/FSharp.Data">
[<EntryPoint>]
let main argv =
    let rawStats = NugetStats().Tables.``Version History``

    do rawStats.Rows |> Seq.iter (printfn "row = %A")
    
    let cts = new CancellationTokenSource()
    let conf = { defaultConfig with cancellationToken = cts.Token }
    let listening, server = startWebServerAsync conf (Successful.OK "Hello World")
    
    Async.Start(server, cts.Token)
    printfn "Make requests now"
    Console.ReadKey true |> ignore    
    cts.Cancel()
    
    0 // return an integer exit code
