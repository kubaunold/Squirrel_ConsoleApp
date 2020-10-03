﻿namespace Squirrel_DomainLogic

open Squirrel_DomainLogic.WorldPos

module Actors =

  [<AbstractClass>]
  type Actor(pos: WorldPos) =
    member this.Pos = pos
    abstract member Character: char

  type Squirrel(pos: WorldPos, hasAcorn: bool) =
    inherit Actor(pos)
    member this.HasAcorn = hasAcorn
    override this.Character = 'S'

  let createSquirrel pos = new Squirrel(pos, false)