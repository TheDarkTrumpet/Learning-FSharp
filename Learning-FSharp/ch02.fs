// Caching
open System.Collections.Generic
let rec fibonacci_Generic n =
  let cache = Dictionary<_, _>()
  let rec fibonacciX = function
    | n when n = 0I -> 0I
    | n when n = 1I -> 1I
    | n -> fibonacciX (n - 1I) + fibonacciX (n - 2I)
  if cache.ContainsKey(n) then cache.[n]
  else
    let result = fibonacciX n
    cache.[n] <- result
    result

let rec TowerOfHanoi f x t n =
  if n > 0 then
    TowerOfHanoi f t x (n - 1)
    printfn "Iteration (%d) move disk from %c to %c" n f t
    TowerOfHanoi x f t (n - 1)

;;

// Alternate Option
// Research Paper: http://cs.cornell.edu/~kozen/papers/theory.pdf
let rec TowerOfHanoiRec n s f =
  match n with
    | 0 -> [ ]
    | _ -> let t = (6 - s - f)
           (TowerOfHanoiRec (n-1) s t) @ [s, f] @ (TowerOfHanoiRec(n-1) t f)

// The @ symbol concatenates 2 lists (See ch03 of Expert F# 3.0)
           

;;
// Lazy Searching
           

// Sorting
let listPrint = function
  | [] -> []
  | n::ns -> printfn "n => %i" n
             ns
