// From page 58

let rec factorial x =
  if x <= 1 then
    1
  else
    x * factorial (x - 1)

;;
    
// From page 60
let rec isOdd x =
  if x = 0 then false
  elif x = 1 then true
  else isEven(x - 1)
and isEven x =
  if x = 0 then true
  elif x = 1 then false
  else isOdd(x - 1)


