// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
open System.Numerics
[<EntryPoint>]


let main argv = 
    let carimax a b =
        if a>b then a
        else b
    let carimin n m =
        if n<m then n
        else m
    let mutable inpline=Console.ReadLine()
    let mutable inps=inpline.Split ' '
    let mutable x = 0
    x <- int(inps.[0])
    let mutable y = 0
    y <- int(inps.[1])
    let rec gcd l s =
        let mutable ma = Math.Max(int(l),int(s))
        let mutable mi = Math.Min(int(l),int(s))
        if mi=0 then ma
        else gcd mi (ma%mi)
    let mutable res=0
    res <- gcd x y 
    printf "%d\n" res
    Console.ReadLine()
    0 // return an integer exit code
