﻿namespace FsWithTests

//---------------------------------------------------------------
// About Let
//
// The let keyword is one of the most fundamental parts of F#.
// You'll use it in almost every line of F# code you write, so
// let's get to know it well! (no pun intended)
//---------------------------------------------------------------

[<Test(Sort = 2)>]
module ``about let`` =




    [<Test>]
    let ``let binds a name to a value``() =
        let x = 50
        
        AssertEquality x __
    









    (* In F#, values created with let are inferred to have a type like
       "int" for integer values, "string" for text values, and "bool" 
       for true or false values. *)
    [<Test>]
    let ``let infers the types of values where possible``() =
        let x = 50
        let typeOfX = x.GetType()

        let y = "a string"
        let expectedType = y.GetType()

        AssertEquality typeOfX typeof<FILL_ME_IN>
        >>= AssertEquality expectedType typeof<FILL_ME_IN>










    [<Test>]
    let ``you can make types explicit``() =
        let (x:int) = 42
        let typeOfX = x.GetType()

        let y:string = "forty two"
        let typeOfY = y.GetType()

        AssertEquality typeOfX typeof<FILL_ME_IN>
        >>= AssertEquality typeOfY typeof<FILL_ME_IN>

        (* You don't usually need to provide explicit type annotations types for 
           local varaibles, but type annotations can come in handy in other 
           contexts as you'll see later. *)
    








    [<Test>]
    let ``floats and ints``() =
        let x = 20
        let typeOfX = x.GetType()

        let y = 20.0
        let typeOfY = y.GetType()

        //you don't need to modify these
        AssertEquality typeOfX typeof<int>
        >>= AssertEquality typeOfY typeof<float>

        // If you're coming from another .NET language, float is F# slang for the double type.






    [<Test>]
    let ``modifying the value of variables``() =
        let mutable x = 100
        x <- 200

        AssertEquality x __









    [<Test>]
    let ``you cannot modify a let bound value if it is not mutable``() =
        let x = 50
        
        //What happens if you uncomment the following?
        //
        //x <- 100

        //NOTE: Although you can't modify immutable values, it is possible
        //      to reuse the name of a value in some cases using "shadowing".
        let x = 100
         
        AssertEquality x 100