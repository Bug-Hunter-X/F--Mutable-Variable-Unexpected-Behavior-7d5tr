let x = 10
let y = 20

let add x y = 
    let newX = x + y
    (newX, y)

let (newX, result) = add x y
printf "%d %d" newX result