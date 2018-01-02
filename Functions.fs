module Functions

let hello = "Hello World !!!"

let inline add a b = a + b

let rec fib n =
    match n with
    | x when x < 1 -> failwith("invalid arg")
    | 1 -> 1
    | 2 -> 1
    | _ -> fib(n-1) + fib(n-2)


let square x =
    let p = x in p * p