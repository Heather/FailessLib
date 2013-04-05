Failess - CSS EDSL <embedded domain specific language> in F#
============================================================

Actual readme file: https://github.com/Heather/Failess


example of FailessLib usage with Devil unicode extension:

``` fsharp
fieldset << [
    ★  [    
        margin -/ [em 1.0; px 0]
        padding -- em 1.0
        Border.set (px 1) Border.Solid "#ccc" 
        ]
    ☆ p @ margin -/ px4 2 12 10 10
    ⠂ "login" ++ label 
        >< ⠂ "register" ++ label 
        >< ⠂ "changePassword" ++ label 
            @ Display.block 
    ]
⠂ loginDisplay << [
    ★  [
        fontSize       -- em 1.1
        padding        -- px 10
        Display.block
        TextAlign.right
        Color.white 
        ]
    ☆ a << [
        ⠅ link     @ Color.white
        ⠅ visited  @ Color.white
        ⠅ hover    @ Color.white
        ] ]
Border.set (px 1) Border.Solid "#ccc" |> fun ➷ ->
    input << [
        ⠂ "textEntry "      -|[ ➷; width -- px 320 ]
        ⠂ "passwordEntry"   -|[ ➷; width -- px 320 ]
        ]
```

