[<AutoOpen>]
module Failess.CSSObfuscation

open System
open System.Text.RegularExpressions

///<TODO>
/// Better obfuscation
/// -> better logic for spaces
/// -> remove all the comments
///</TODO>

let obfuscate (css : seq<string>) =
    String.Join(" ", css)
        .Replace(System.Environment.NewLine, " ")
        .Replace("  ", " ")
        .Replace("  ", " ")