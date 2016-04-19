// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System

[<EntryPoint>]
let main argv = 
    //input integer xin
    let xin =int(Console.ReadLine()) 
    
    //function fibonacci
    let rec fibonacci x=
        if x=0 then 0
        else if x=1 then 1
        else fibonacci(x-1) + fibonacci(x-2)  
    
    //assign to a variable
    let res=fibonacci(xin)
    
    //print
    printfn "%d" res
    
    //halt
    Console.ReadLine()
    
    0 // return an integer exit code
