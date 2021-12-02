open System
open Utils.ProblemUtils

let commandValues = readLines "input.txt" 
                    |> Seq.map (fun line -> line.Split " ") 
                    |> Seq.map (fun split -> (split.[0], split.[1])) 
                    |> Seq.map (fun (command, value) -> (command, Convert.ToInt32 value))

let part1 =
    commandValues
    |> Seq.fold (fun acc (command, value) -> match command with
                                             | "forward" -> {| horizontal = acc.horizontal + value; depth = acc.depth; |}
                                             | "up" -> {| horizontal = acc.horizontal; depth = acc.depth - value; |}
                                             | "down" -> {| horizontal = acc.horizontal; depth = acc.depth + value; |}
                                             | _ -> failwith "Invalid Command")
     {| horizontal = 0; depth = 0; |}
    
printfn "Part1: %i" (part1.horizontal * part1.depth)

let part2 = 
    commandValues
    |> Seq.fold (fun acc (command, value) -> match command with
                                             | "forward" -> {| horizontal = acc.horizontal + value; depth = acc.depth - acc.aim * value ; aim = acc.aim |}
                                             | "up" -> {| horizontal = acc.horizontal; depth = acc.depth; aim = acc.aim + value |}
                                             | "down" -> {| horizontal = acc.horizontal; depth = acc.depth; aim = acc.aim - value |}
                                             | _ -> failwith "Invalid Command")
     {| horizontal = 0; depth = 0; aim = 0 |}

printfn "Part2: %i" (part2.horizontal * part2.depth)
