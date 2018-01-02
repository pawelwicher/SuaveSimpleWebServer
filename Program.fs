open System
open Suave
open Suave.Filters
open Suave.Operators
open Suave.Successful

let hello = "Hello World !!!"

let square x =
    let p = x in p * p

let rec fib n =
    match n with
    | x when x < 1 -> failwith("invalid arg")
    | 1 -> 1
    | 2 -> 1
    | _ -> fib(n-1) + fib(n-2)

let app =
    choose
        [ GET >=> choose
            [
                path "/" >=> OK hello
                pathScan "/square/%d" (fun n -> OK ((square n).ToString()) )
                pathScan "/fib/%d" (fun n -> OK ((fib n).ToString()) )
            ]
        ]

[<EntryPoint>]
let main argv =
    startWebServer defaultConfig app
    0