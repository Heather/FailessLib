﻿[<AutoOpen>]
module Failess.CSSCore
open System
open System.ComponentModel

///Core stuff:
let failessVersion = "0.1.2"

///Settings:
let mutable pasteNewLine = false
let mutable obfuscation = false

(* if you want to use different tab size *)
let mutable tab = "    "


let inline (++) a b = sprintf "%s %s" a b
let inline s str = str.ToString()