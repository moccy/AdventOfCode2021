open System
open Utils.ProblemUtils

let lines = readLines "input.txt" 
            |> Seq.map(fun x -> x  |> Seq.map (fun y -> convertToBool y))

let gammaBits = 
    lines 
    |> Seq.transpose
    |> Seq.map (fun x -> x 
                        |> Seq.countBy id               // Get the count of each element, e.g. [(0, 5), (1, 10)]
                        |> Seq.sortByDescending snd     // Sort by the count e.g. [(0, 5), (1, 10)] -> [(1, 10), (0, 5)]
                        |> Seq.map fst                  // Select the key e.g. [(1, 10), (0, 5)] -> [1, 0]
                        |> Seq.head)                    // Select the first element in the sequence e.g. [1, 0] -> 1

let gamma = gammaBits |> Seq.map (fun x -> if x then "1" else "0") |> String.Concat 
let epsilon = gammaBits |> Seq.map (fun x -> if x then "0" else "1") |> String.Concat
let gammaDecimal = Convert.ToInt32(gamma, 2)
let epsilonDecimal = Convert.ToInt32(epsilon, 2)
let powerConsumption = gammaDecimal * epsilonDecimal

printfn "Gamma: %s" gamma
printfn "Gamma Decimal: %i" gammaDecimal
printfn "Epsilon: %s" epsilon
printfn "Epsilon Decimal: %i" epsilonDecimal
printfn "Power Consumption: %i" powerConsumption