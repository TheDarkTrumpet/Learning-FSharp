module Chapter02

// Must be both a float, which seems odd
let squareAndAdd (a: float) b = a * a + b;

let round x =
    if x >= 100 then 100
    elif x <= 0 then 0
    else x

let roundWithMatch x =
    match x with
    | _ when x > 100 -> 100
    | _ when x < 0   -> 0
    | _ -> x



//Note the difference between unit and int.  unit is basically void in F#
let add5 (x : int) =
    x + 5
;;

let newList = [5; 2; 3; 9]
;;

let new5List = List.map add5 newList