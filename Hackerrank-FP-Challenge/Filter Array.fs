//Enter your code here. Read input from STDIN. Print output to STDOUT
open System
let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> null do
            arr <- Int32.Parse(buff)::arr
            buff <- Console.ReadLine()
    arr
let main =
    let batas= Console.ReadLine() |> int
    let mutable arr= read_and_parse()
    let mutable arrres=[]
    let szarr=List.length arr - 1
    for i=0 to szarr do
        if arr.[i] < batas then arrres<-arr.[i]::arrres
    let szres = List.length arrres - 1
    for x=0 to int(szres) do
        printf "%d\n" arrres.[x]
    
    Console.ReadLine()
    0
