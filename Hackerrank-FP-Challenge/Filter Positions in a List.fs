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
    let arr = read_and_parse()
    let len = (List.length arr)-1
    if len%2<>0 then
        for i = len downto 0 do
            if i%2=0 then 
                printf "%d\n" arr.[i]
    else
        for i = len downto 0 do
            if i%2<>0 then 
                printf "%d\n" arr.[i]
