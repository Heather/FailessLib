[<AutoOpen>]
module Failess.Convert

open System
open System.Text.RegularExpressions

let inline toFailess css = 
    match css with
    | []    -> ""
    | [ s ] -> s
    | _     ->
        let block       = ref false
        let blockStart  = ref ""
        let blockQueue  = ref []
        String.Join(System.Environment.NewLine,
            [for s : string in css do
                if !block then
                    if s.Contains("}") then
                        block       := false
                        yield (!blockStart).Replace("{", "-| [")
                                           .Replace(".", "-.")
                                           .Replace(":", "%")
                                           .Replace(":", "%")
                                           .Replace(",", "$")
                        if (!blockQueue).Length > 0 then
                            yield String.Join
                                (System.Environment.NewLine, !blockQueue)
                        yield sprintf "%s]" tab
                        blockQueue := []
                    else
                        if s.Contains(":") then
                            let split = s.Split(':')
                            if split.Length > 1 then
                                let left    = ref split.[0]
                                let right   = ref split.[1]
                                for w in (!left).Split(' ','.',':') do
                                    if not <| String.IsNullOrEmpty w then
                                        if not ( CSSStrings
                                                 |> List.exists(fun cw -> cw = w) ) then
                                            left := (!left).Replace(w, (sprintf "\"%s\"" w))
                                let value s v n =
                                    let rspl = Regex.Split(s, v)
                                    if rspl.Length > 0 then right := sprintf "%s%s" n rspl.[0]
                                match !right with
                                | r when r.Contains("em") -> value r "em" "em"
                                | r when r.Contains("px") -> value r "px" "px"
                                | r when r.Contains("pt") -> value r "pt" "pt"
                                | r when r.Contains("%")  -> value r "%" "prc"
                                | _ -> ()
                                right := (!right).Replace(";","")
                                blockQueue  := 
                                    sprintf "%s%s --%s" tab !left !right
                                        :: !blockQueue
                        else
                            blockQueue  := 
                                sprintf "%s%s%s" tab tab s
                                    :: !blockQueue
                else if s.Contains("{") then
                    blockStart := s
                    for w in s.Split(' ','.',':','{') do
                        if not <| String.IsNullOrEmpty w then
                            if not ( CSSStrings |> List.exists(fun cw -> cw = w) ) then
                                blockStart := (!blockStart).Replace(w, (sprintf "\"%s\"" w)) 
                    block := true
            ])