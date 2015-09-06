// Page 68 in F# Book

let isOdd x = (x % 2 = 1)

;;

let describeNumber x =
  match isOdd x with
    | true -> printfn "%d is odd" x
    | false -> printfn "%d is even" x

    ;;
    
let testAnd x y =
  match x, y with
    | true, true -> true
    | _, _ -> false

    ;;
    
// Match Failure - pg 69
    // Default Argument (pg70)

let greet name =
  match name with
    | "Robert" -> printfn "Hello, Bob"
    | "William" -> printfn "Hello, Bill"
    | x -> printfn "Hello, %s!" x        //Default match rule

    ;;

// Literal Matching
[<Literal>]
let Bill = "Bill Gates";;

let greet2 name =
  match name with
    | Bill -> "Hello Bill"
    | x -> sprintf "Hello %s!" x
    ;;


    // high-low game, page 72
open System

let highLowGame () =
  let rng = new Random()
  let secretNumber = rng.Next() % 100

  let rec highLowGameStep () =

    printfn "Guess the secret number: "
    let guessStr = Console.ReadLine()

    let guess = Int32.Parse(guessStr)
    match guess with
      | _ when guess > secretNumber ->
        printfn "The secret number is lower."
        highLowGameStep()
      | _ when guess = secretNumber ->
        printfn "You've guessed Correctly!"
        ()
      | _ when guess < secretNumber ->
        printfn "The secret number is higher."
        highLowGameStep()
      | _ -> ()

  highLowGameStep()
