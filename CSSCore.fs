[<AutoOpen>]
module Failess.CSSCore
open System
open System.ComponentModel

///Settings:
let mutable pasteNewLine = false

///Core stuff:
let failessVersion = "0.0.1"

let inline (+++) a b = sprintf "%s%s" a b
let inline (++) a b = sprintf "%s %s" a b

let inline s str = str.ToString()