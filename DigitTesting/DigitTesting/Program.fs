// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

let add x y = x + y

[<EntryPoint>]
let main argv = 
    printfn "Hallow Word"
    let sum = add 3
    printfn "%i" (sum 7)
    0 // return an integer exit code 
