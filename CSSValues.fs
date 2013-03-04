[<AutoOpen>]
module Failess.CSSValues
open System.Globalization

let nfi = new NumberFormatInfo()
nfi.NumberDecimalSeparator <- "."

let inline rgb(r,g,b) = sprintf "rgb(%d, %d, %d)" r g b
let inline url(u) = sprintf "url(%s)" u

let inline internal mk2 arg v1 v2 =
    [arg v1; arg v2]
let inline internal mk3 arg v1 v2 v3 =
    [arg v1; arg v2; arg v3]
let inline internal mk4 arg v1 v2 v3 v4 =
    [arg v1; arg v2; arg v3; arg v4]

let inline em (v : double) = v.ToString(nfi) +++ "em"
let inline emm vv = [for v in vv -> em v]

let inline em2 v1 v2 = mk2 em v1 v2
let inline em3 v1 v2 v3 = mk3 em v1 v2 v3
let inline em4 v1 v2 v3 v4 = mk4 em v1 v2 v3 v4

let inline prc v = s v +++ "%"
let inline prcc vv = [for v in vv -> prc v]

let inline prc2 v1 v2 = mk2 prc v1 v2
let inline prc3 v1 v2 v3 = mk3 prc v1 v2 v3
let inline prc4 v1 v2 v3 v4 = mk4 prc v1 v2 v3 v4

let inline pt v = s v +++ "pt"
let inline ptt vv = [for v in vv -> pt v]

let inline pt2 v1 v2 = mk2 pt v1 v2
let inline pt3 v1 v2 v3 = mk3 pt v1 v2 v3
let inline pt4 v1 v2 v3 v4 = mk4 pt v1 v2 v3 v4

let inline px v = s v +++ "px"
let inline pxx vv = [for v in vv -> px v]

let inline px2 v1 v2 = mk2 px v1 v2
let inline px3 v1 v2 v3 = mk3 px v1 v2 v3
let inline px4 v1 v2 v3 v4 = mk4 px v1 v2 v3 v4