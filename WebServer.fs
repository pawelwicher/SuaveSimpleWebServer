module WebServer

open System
open Suave
open Suave.Filters
open Suave.Operators
open Suave.Successful
open Functions

let app =
    choose
        [ GET >=> choose
            [ 
                path "/hello" >=> OK hello
                pathScan "/fib/%d" (fun n -> OK ((fib n).ToString()) )
            ]
        ]

let start = startWebServer defaultConfig app

