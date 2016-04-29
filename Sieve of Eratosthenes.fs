open System
[<EntryPoint>]
let main argv = 
    let sieve n =
        if n = 2 then Console.WriteLine(2)
        else if n<2 then Console.WriteLine("INVALID!") 
        else
            let mutable res = []
            let mutable arr = Array.create (n-1) 0
            for i=2 to n do
                arr.[i-2]<-i
            let mutable sz = arr.Length
            let mutable ctr = 0
            let mutable primepos=0
            let mutable currprime =0
            while ctr< sz do
                if arr.[primepos] <> -1 then
                    res<-arr.[primepos]::res
                    currprime <- arr.[primepos]
                    ctr<-ctr + 1
                else
                    let mutable found :bool =false
                    let mutable x=primepos
                    while not(found)&&x<sz do
                        if arr.[x] <> -1 then
                            primepos <- x
                            res<- arr.[primepos]::res
                            currprime <- arr.[x]
                            ctr <- ctr + 1
                            found <- true
                        else x<- x + 1
                let mutable u = primepos
                while u < sz do
                    if arr.[u] <> -1 then
                        arr.[u] <- -1
                        if u <> primepos then ctr <- ctr + 1
                    u <- u + currprime
            for item=res.Length-1 downto 0 do
                Console.WriteLine(res.[item])        
    Console.WriteLine("Enter a number n, where n>=2 :")  
    let mutable size = Console.ReadLine() |> int
    sieve(size)
    Console.ReadLine()
    0
