module Squirrel_xUnitTests.Tests

open System
open Squirrel_DomainLogic.WorldPos
open Xunit

//[<Fact>]
//let ``My test`` () =
//    Assert.True(true)

[<Theory>]
[<InlineData(4, 2, 4, 1, true)>]
[<InlineData(4, 2, 4, 0, false)>]
let ``Point Adjacency tests`` (x1, y1, x2, y2, expectedAdjacent) =
    // Arrange
    let pos1 = newPos x1 y1
    let pos2 = newPos x2 y2

    // Act; adjacent - s¹siaduj¹cy
    let isAdjacent = isAdjacentTo pos1 pos2

    // Assert
    Assert.Equal(expectedAdjacent, isAdjacent)