//Example 3.2 - Example of higher-order functions

let negate x = -x
;;

List.map negate [1 .. 10]
;;

List.map (fun i -> -i) [1 .. 5]
;;


List.iter(fun i -> printfn "Value: %d" i) [1 .. 5]
;;
