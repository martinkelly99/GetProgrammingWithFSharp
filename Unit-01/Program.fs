// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp
// See the 'F# Tutorial' project for more help.

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let message = from "F#" // Call the function
    let items =argv.Length
    printfn "Hello world %s" message
    printfn "Passed in %d items: %A" items argv
    0 // return an integer exit code
