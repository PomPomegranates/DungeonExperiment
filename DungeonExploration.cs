using System;

/* 
The intent of this is to try and work out how to run a program that is 
constantly searching for input on the command line, and breaks/runs different methods based on the input.
*/

public class DungeonExploration
{
    public static void Main(string[] args) 
	{
		/* This should be the place where an infinite loop can run 
		* 
		* 
		*/
        new Dict<string, string[]> adjacentRooms =  {"RoomA":{"RoomB"}, "RoomB":{"RoomA","RoomC"}, "RoomC":{"RoomB", "RoomD"}, "RoomD":{"RoomC"}};
		runMenu("Type EXIT to leave");
		//double firstNumber = getNumberInput("Enter your First Number:");
		//double secondNumber = getNumberInput("Enter your Second Number:");
		//int chosenOperation = getOperationChoice();
		//if ((chosenOperation == 4)&& (firstNumber == 0 ||secondNumber == 0)){
		//	Console.WriteLine("Invalid Choice, you cannot divide by Zero");
		//} else{
		//	Console.WriteLine("Result:"+ performOperation(firstNumber, secondNumber, chosenOperation));
		//}

    }

    private static void readMap(currentRoom)
    {

    }


    private static void runMenu(string message){
            bool continuous = true;
            Console.WriteLine(message);
            while (continuous){
                string input = Console.ReadLine();
                if (input == "ENTER"){
                    Console.WriteLine("Let's begin");
                } else if (input == "EXIT"){
                    continuous = false;
                }

            }
    }
    

    private static 

	private static double getNumberInput(string message) 
	{
		/* write a method here which prints a message to the user, 
		* prompting them for a number, and then returns that number
		*/
		Console.WriteLine(message);
        double num1 = Int32.Parse(Console.ReadLine());
		return num1;
	}

	private static int getOperationChoice() 
	{
		/* write a method here which prints a message to the user, 
		* prompting them to choose an operation (like add, multiply, etc)
		*  and then returns the integer which corresponds to their choice
		*/
		Console.WriteLine("Select operation: 1. Add  2. Subtract  3. Multiply  4. Divide");
        int choice = Int32.Parse(Console.ReadLine());
		return choice;

	}

	private static double performOperation(double num1, double num2, int choice) 
	{
		/* write a method here which uses a switch case to perform the operation which 
		*  corresponds to the "choice" integer (e.g. 1 = Add)
		*  and then returns the result of that operation
		*/
		//double answer = 0;

		switch (choice)
		{
			
			case 1:
			//addition
			return (num1 + num2);
		

			case 2:
			//subtraction
			return (num1 - num2);
			

			case 3:
			//multiplication
			return (num1 * num2);
			

			case 4:
			//division
			//if (num1 == 0||num2 == 0)
			return(num1/num2);
			
			
		}
		return 0;
		

	}
}