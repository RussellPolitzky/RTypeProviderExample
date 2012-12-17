module SampleEntry

open Sample

// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    sample |> ignore
    printfn "%A" argv
    0 // return an integer exit code


