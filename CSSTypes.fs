[<AutoOpen>]
module Failess.CSSTypes

open System
open System.ComponentModel

type Background =
    | NoRepeat 
    | Center
    override this.ToString() =
        match this with
        | NoRepeat  -> "no-repeat"
        | Center    -> "center"
type Border =
    | None
    | Solid
    override this.ToString() =
        match this with
        | None  -> "none"
        | Solid -> "solid"
type Clear =
    | Both
    override this.ToString() =
        match this with
        | Both -> "both"
type Color =
    | White
    | Black
    | Red
    override this.ToString() =
        match this with
        | White -> "white"
        | Black -> "black"
        | Red   -> "red"
type Cursor =
    | Default
    | Pointer
    override this.ToString() =
        match this with
        | Default -> "default"
        | Pointer -> "pointer"
type Display =
    | Block
    | Inline
    override this.ToString() =
        match this with
        | Block -> "block"
        | Inline -> "inline"
type FontWeight =
    | Bold
    override this.ToString() =
        match this with
        | Bold -> "bold"
type FontVariant =
    | SmallCaps
    override this.ToString() =
        match this with
        | smallCaps -> "small-caps"
type Float =
    | Left
    | Right
    override this.ToString() =
        match this with
        | Left -> "left"
        | Right -> "right"
type LineHeight =
    | Normal
    override this.ToString() =
        match this with
        | Normal -> "normal"
type ListStyle =
    | None
    override this.ToString() =
        match this with
        | None -> "none"
type Overflow =
    | Hidden
    override this.ToString() =
        match this with
        | hidden -> "hidden"
type Position =
    | Absolute
    | Relative
    override this.ToString() =
        match this with
        | Absolute -> "absolute"
        | Relative -> "relative"
type TextDecoration =
    | None
    override this.ToString() =
        match this with
        | None -> "none"
type TextAlign =
    | Center
    | Left
    | Right
    override this.ToString() =
        match this with
        | Center    -> "center"
        | Left      -> "left"
        | Right     -> "right"
type WhiteSpace =
    | NoWrap
    override this.ToString() =
        match this with
        | NoWrap -> "nowrap"
