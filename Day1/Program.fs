open System
let from whom =
    sprintf "from %s" whom

let message = from "F#"
printfn "Hello World %s" message
let s = Console.ReadLine