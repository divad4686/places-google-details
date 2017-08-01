[<AutoOpen>]
module ResultExtensions

let (>>=) x f =
    Result.bind f x

let (>=>) s1 s2 =
    s1 >> Result.bind s2

let tee f x =
    f x
    x