// Page 63

let x = [1 .. 10];;

x |> List.iter (printfn "%d");;


// Forward Composition Operator (pg 65)
let square x = x * x;;
let toString (x : int) = x.ToString();;
let strLen (x : string) = x.Length;;
let forComp = square >> toString >> strLen;;

let pipeComp x = x |> square |> toString |> strLen;;

// Backward Composition Operator (pg 67)
let square x = x * x;;
let negate x = -x;;

(square << negate) 10;; // 100, applies the negate first, then squares it.
