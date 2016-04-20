open System

(*USER CODE BEGIN*)
let f arr =
    let mutable sumodd=0
    for x in arr do
        if x%2<>0 then sumodd<-sumodd+x
    sumodd
(*USER CODE END*)

let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> null do
            arr <- Int32.Parse(buff)::arr
            buff <- Console.ReadLine()
    arr

let main =    
    let arr = read_and_parse()
    printf "%A" <| f arr
