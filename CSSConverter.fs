[<AutoOpen>]
module Failess.Convert

open System

let inline ToFailess css = 
    match css with
    | [] -> ""
    | [ _ ] -> ""
    | _ ->
        let block       = ref false
        let blockStart  = ref ""
        let blockQueue  = ref []
        String.Join(System.Environment.NewLine,
            [for s : string in css do
                if !block then
                    if s.Contains("}") then
                        block       := false
                        yield (!blockStart).Replace("}", "-| [")
                        yield String.Join(System.Environment.NewLine, !blockQueue)
                        yield sprintf "%s]" tab
                    else
                        let st = sprintf "%s%s%s" tab tab s
                        if s.Contains(":") then
                            let sxt = st.Replace(":", "--")
                            blockQueue  := sxt :: !blockQueue
                        else
                            blockQueue  := st :: !blockQueue
                else
                    if s.Contains("{") then
                        blockStart  := s
                        block       := true
            ])