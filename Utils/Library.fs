namespace Utils

open System.IO
module ProblemUtils =
    let readLines filepath = 
        File.ReadLines(filepath) |> Seq.cast<string>

    let convertToBool char =
        match char with
            | '1' -> true
            | '0' -> false
            | _ -> failwith "Character that isn't '1' or '0'"