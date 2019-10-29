(*
	
	Takes a file and creates a word frequency table.
	
	Name: Saqib Zaidi Sahib
	
	UPI: ssah933
	
	AUID: 222479856
	
	COMPSCI 335 S2 2018 Assignment 1
	
*)

open System
open System.IO
open System.Text.RegularExpressions

[<EntryPoint>]
let main(args) =  
    try
        let mutable k = 3
        let path = args.[0]
        if args.Length = 2 then k <- System.Int32.Parse(args.[1])
        if k < 0 then k <- 0
        let text = File.ReadAllText path
        let rgx = new Regex @"[^A-Za-z]+"
        let words = rgx.Replace(text, " ").Trim().Split(' ')
        let mutable x = 
            words
            |> Seq.groupBy(fun w -> w.ToUpper())
            |> Seq.map(fun (k, s) -> (Seq.length s, k))
            |> Seq.sortBy(fun (c, k) -> (-c, k))         
        if Seq.length x > k then x <- Seq.take k x
        x |> Seq.iter(fun w -> printfn "%d %s\n" (fst w) (snd w))
        0
    with ex ->
      printfn "***Error: %s" ex.Message
      Environment.ExitCode <- 1
      0