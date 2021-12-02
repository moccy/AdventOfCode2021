open System
open Utils.ProblemUtils

let lines = readLines "input.txt"

let part1 = 
    lines
    |> Seq.map (fun x -> Convert.ToInt32 x)
    |> Seq.windowed 2
    |> Seq.filter (fun x -> x.[0] < x.[1])
    |> Seq.length

let part2 =
    lines
    |> Seq.map (fun x -> Convert.ToInt32 x)
    |> Seq.windowed 3
    |> Seq.map (fun x -> Seq.sum x)
    |> Seq.windowed 2
    |> Seq.filter (fun x -> x.[0] < x.[1])
    |> Seq.length

printfn "Part 1: %i" part1
printfn "Part 2: %i" part2
