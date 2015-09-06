// Methods and Properties (pg84)

type Vector =
  { X : float; Y: float; Z: float}
  member this.Length =
    sqrt <| this.X ** 2.0 + this.Y ** 2.0 + this.Z ** 2.0;;

let v = { X = 10.0; Y = 20.0; Z = 30.0 };;




// Sequence Expressions (pg 87-
