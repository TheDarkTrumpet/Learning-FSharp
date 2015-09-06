let rec TowerOfHanoi f x t n =
  if n > 0 then
    TowerOfHanoi f t x (n - 1)
    printfn "Iteration (%d) move disk from %c to %c" n f t
    TowerOfHanoi x f t (n - 1)

;;

// Alternate Option

let rec TowerOfHanoiRec n s f =
  match n with
    | 0 -> [ ]
    | _ -> let t = (6 - s - f)
           (TowerOfHanoiRec (n-1) s t) @ [s, f] @ (TowerOfHanoiRec(n-1) t f)
