module CS220.Quiz1.Math

open System

let f n =
  if n%2UL = 0UL then n/2UL
  else n*3UL+1UL

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let rec iter num n = 
    let result = f n
    if result = 1UL then num
    else iter (num+1) result
  iter 1 (uint64 n)
