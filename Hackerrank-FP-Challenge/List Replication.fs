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
    let x = Console.ReadLine()
    let arr = read_and_parse()
    let fin = List.length arr - 1
    for j = int(fin) downto  0 do
        for i in 1 .. int(x) do
            printf "%d\n" arr.[j]
