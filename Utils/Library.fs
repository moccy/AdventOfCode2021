namespace Utils

open System.IO

module ProblemUtils =
    let readLines filepath = 
        File.ReadLines(filepath) |> Seq.cast<string>