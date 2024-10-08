﻿

using System.ComponentModel.Design;
using System.Linq;

namespace CSharpSelection
{
	public static class SelectionExercises
	{

		// Q1
		public static string FizzBuzz(int number)
		{
			string result = Convert.ToString(number);
			if ((number % 5 == 0) && (number % 3 == 0))
			{
				result = "FizzBuzz";
			}
			else if (number % 5 == 0)
			{
				result = "Buzz";
			}
			else if (number % 3 == 0)
			{
				result = "Fizz";
			}
			return result;
		}

		public static string FizzBuzzAlt(int number)
		{
			string result = string.Empty;
			if (number % 3 == 0)
			{
				result = "Fizz";
			}
			if (number % 5 == 0)
			{
				result += "Buzz";
			}
			return result == string.Empty ? Convert.ToString(number) : result;
		}

		// Q2
		public static bool IsVowel(char letter)
		{
			bool result = false;
			letter = Char.ToLower(letter);
			switch (letter)
			{
				case ('a'):
				case ('e'):
				case ('i'):
				case ('o'):
				case ('u'):
					result = true;
					break;
			}
			return result;
		}

		// Q3
		public static void DiceRoll()
		{
			Random random = new();
			int dice1 = random.Next(0, 7);
			int dice2 = random.Next(0, 7);
			int dice3 = random.Next(0, 7);
			Console.WriteLine($"You rolled a {dice1}, a {dice2} and a {dice3}");
			if ((dice1 == dice2) && (dice2 == dice3))
			{
				Console.WriteLine("Three of a kind");
			}
			else if ((dice1 == dice2) || (dice2 == dice3) || (dice1 == dice3))
			{
				Console.WriteLine("You have a pair");
			}
			else
			{
				Console.WriteLine("Sorry you lose");
			}
		}

		// Q4
		public enum AngleType
		{
			Acute,
			RightAngle,
			Obtuse,
			Straight,
			Reflex,
			Other
		}
		public static AngleType ClassifyAngle(int angle)
		{
			AngleType angleType = AngleType.Other;
			if (angle > 0)
			{
				if (angle < 90)
				{
					angleType = AngleType.Acute;
				}
				else if (angle == 90)
				{
					angleType = AngleType.RightAngle;
				}
				else if (angle < 180)
				{
					angleType = AngleType.Obtuse;
				}
				else if (angle == 180)
				{
					angleType = AngleType.Straight;
				}
				else if (angle < 360)
				{
					angleType = AngleType.Reflex;
				}
			}
			return angleType;
		}

		public enum Choice
		{
			Rock,
			Paper,
			Scissors
		}
		public static void RockPaperScissors(Choice userChoice)
		{
			Random random = new();
			Choice computerChoice = (Choice)random.Next(0, 3);
			Console.WriteLine($"You chose {userChoice}");
			Console.WriteLine($"The computer chose {computerChoice}");
			if (userChoice == computerChoice)
			{
				Console.WriteLine($"You drew. {userChoice} draws with {computerChoice}.");
			}
			else if ((userChoice == Choice.Rock && computerChoice == Choice.Scissors) ||
				(userChoice == Choice.Paper && computerChoice == Choice.Rock) ||
				(userChoice == Choice.Scissors && computerChoice == Choice.Paper))
			{
				Console.WriteLine($"You won. {userChoice} beats {computerChoice}.");
			}
			else
			{
				Console.WriteLine($"You lost. {userChoice} loses to {computerChoice}.");
			}
		}


		public enum TriangleType
		{
			Equilateral,
			Isosceles,
			Scalene
		}
		public static TriangleType ClassifyTriangle(double side1, double side2, double side3)
		{
			TriangleType triangleType = TriangleType.Scalene;
			if ((side1 == side2) && (side2 == side3))
			{
				triangleType = TriangleType.Equilateral;
			}
			else if ((side1 == side2) || (side2 == side3) || (side1 == side3))
			{
				triangleType = TriangleType.Isosceles;
			}
			return triangleType;
		}

		public static void ConcertSale()
		{
			Console.Write("Please enter the price in £: ");
			if (!Decimal.TryParse(Console.ReadLine(), out decimal price))
			{
				Console.WriteLine("Sorry, price is not valid");
			}
			else
			{
				Console.Write("Please enter the number of tickets: ");
				if (!Int32.TryParse(Console.ReadLine(), out int ticketNumber))
				{
					Console.WriteLine("Sorry, the number of tickets is not valid");
				}
				else
				{
					decimal total = price * ticketNumber;
					Console.WriteLine($"The total cost is {total:C}");
				}
			}
		}

		public static bool EligibleFor18To30(DateTime dateOfBirth)
		{
			DateTime today = DateTime.Today;
			int age = 0;
			if (dateOfBirth.Year < today.Year)
			{
				age = today.Year - dateOfBirth.Year;
				DateTime birthday = new (today.Year, dateOfBirth.Month, dateOfBirth.Day);
				if (birthday > today)
				{
					age -= 1;
				}
			}
			return (age >= 18 && age <= 30);
		}
		
	}
}
