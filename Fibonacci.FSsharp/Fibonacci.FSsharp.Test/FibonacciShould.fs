module ``Fibonacci Should``

open System
open Xunit
open Fibonacci

[<Trait("Category", "UnitTests")>]
[<Theory>]
[<InlineData(0, 0)>]
[<InlineData(1, 1)>]
[<InlineData(2, 1)>]
[<InlineData(3, 2)>]
[<InlineData(4, 3)>]
[<InlineData(5, 5)>]
[<InlineData(6, 8)>]
[<InlineData(7, 13)>]
[<InlineData(8, 21)>]
[<InlineData(9, 34)>]
[<InlineData(10, 55)>]
[<InlineData(11, 89)>]
[<InlineData(12, 144)>]
[<InlineData(13, 233)>]
[<InlineData(14, 377)>]
[<InlineData(15, 610)>]
[<InlineData(16, 987)>]
let ``Return the sum of the two previous number`` (input: int, expected: int) =
    let result = Calculer input
    Assert.Equal(expected, result)

    