//let text ="Hello, world"
//text.Length

let greetPerson name age =
    sprintf "Hello, %s. You are %d years old" name age 

let greeting = greetPerson "Fred" 25

let countWords (text:string) =
    let words = text.Split(' ')
    let items = words.Length
    let filetext = sprintf "There are %d words in the string %s" items text
    System.IO.File.WriteAllText(@"c:\temp\writetext.txt", filetext)

countWords "This is a bunch of words"