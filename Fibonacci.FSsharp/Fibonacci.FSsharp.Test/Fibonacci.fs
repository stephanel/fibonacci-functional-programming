module Fibonacci

// 1 1 3 

let rec private fib(n: int, a: int, b: int) =
    if n = 0 then
        a
    else if n = 1 then
        b
    else
        fib(n-1, b, a+b)

let Calculer (n: int) = fib(n, 0, 1)

