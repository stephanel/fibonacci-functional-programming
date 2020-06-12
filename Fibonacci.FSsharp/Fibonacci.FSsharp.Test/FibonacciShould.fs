module Tests

open System
open Xunit
open Fibonacci

[<Fact>]
let ``Return 0 when input is 0`` () =
    let result = Calculer 0
    Assert.Equal(0, result)

[<Fact>]
let ``Return 1 when input is 1`` () =
    let result = Calculer 1
    Assert.Equal(1, result)

[<Fact>]
let ``Return 1 when input is 2`` () =
    let result = Calculer 2
    Assert.Equal(1, result)

[<Fact>]
let ``Return 2 when input is 3`` () =
    let result = Calculer 3
    Assert.Equal(2, result)

[<Fact>]
let ``Return 89 when input is 11`` () =
    let result = Calculer 11
    Assert.Equal(89, result)
    
[<Fact>]
let ``Return 610 when input is 15`` () =
    let result = Calculer 15
    Assert.Equal(610, result)
    