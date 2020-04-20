using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("Welcome to GUESS game! There are 3 levels: Easy, Medium and Hard.\n");
            
            Console.Write("Type E to choose Easy, M to choose Medium and H to choose Hard: ");

            String level=Console.ReadLine();
            Random rnd= new Random();
            int numEnter= 0;
    
            // Function TryAgain = new Function();

            if(level.ToUpper()=="E"){
                Console.Write("Easy Level! You have 6 guesses. Enter a number between 1-10: ");
                 numEnter=int.Parse(Console.ReadLine());
                for (int i=1; i<=5; i++){
                    if(rnd.Next(10)!=numEnter){
                        Console.Write($"That was wrong! You have  {(6-i)} guess left. Guess again: ");
                        numEnter=int.Parse(Console.ReadLine());
                            if (i+1==6){
                                Console.WriteLine("Gameover");
                            };
                        
                        
                    
                    }
                    else{
                        Console.WriteLine("You got it right!");
                        i=6;
                    }}
                    
            }
            
            else if(level.ToUpper()=="M"){
                Console.Write("Medium Level! You have 4 guesses. Enter a number between 1-20: ");
                numEnter=int.Parse(Console.ReadLine());
                for(int i=1; i<=3; i++){
                    if(rnd.Next(20)!=numEnter){
                        Console.Write("That was wrong! You have " + (4-i) + " guess left. Guess again: ");
                        numEnter=int.Parse(Console.ReadLine());

                        if(i+1==4){
                            Console.WriteLine("Gameover");
                            
                        }
                        
                    }
                    else{
                        Console.WriteLine("You got it right!");
                        i=4;
                    }
               }
            }

            else if(level.ToUpper()=="H"){
                Console.WriteLine("Hard Level! You have 3 guesses. Enter a number from 1-50: ");
                numEnter=int.Parse(Console.ReadLine());
                for (int i=1; i<=2; i++){
                    if(rnd.Next(50)!=numEnter){
                        Console.Write("That was wrong! You have " + (3-i) +" guess left. Guess again: ");
                        numEnter=int.Parse(Console.ReadLine());
                            if (i+1==3){
                                Console.WriteLine("Gameover");
                            };
                        
                        
                    
                    }
                    else{
                        Console.WriteLine("You got it right!");
                        i=3;
                    }}
                    
        
            } 
            else{
                Console.WriteLine("You entered an invalid value: There are 3 levels, Easy, Medium and Hard");
                
            }

         }
    }
}

 /*  You are to build a number guessing game that has the following features:

            

            User is able to guess numbers against a number set by your program

            If user enters anything other than number, user should be told

            There are 3 levels, easy, medium and hard

            At easy, Users get a chance to guess the number between 1 - 10, and the user gets 6 guesses

            Medium, the users is required to guess the number between 1 - 20, and the user gets 4 guesses

            Hard, users are required to guess between 1 - 50, and they only get 3 guesses

            User should be able to set the level they want to play

            Users should see how many guesses they have left after each guess

            If user guesses right, user should be told "You got it right!"

            If the user guesses wrong, user should be told "That was wrong"

            If users uses all available guessing power and still unable to guess right, user should be told "Game over!"*/
