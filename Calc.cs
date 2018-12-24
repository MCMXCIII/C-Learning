class Calc
	{
		static void Main(string[] args)
		{

			int num1;
			int num2;
			string operand;
			float answer;


			Console.Write("First Number:");

			num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("What operation do you want to do?(+,-,*,/):"

			operand = Console.Readline();

			Console.Write("Second Number:");

			num2 = Convert.ToInt32(Console.ReadLine());

			switch (operand)
			{
				case "-":
					answer = num1 - num2;

					break;
				case "+":
					answer = num1 + num2;

					break;

				case "/":
					answer = num1 / num2;

					break;

				case "*":
					answer = num1 * num2;

					break;

				default:
					answer = 0;

					break;
			}

			Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());

			Console.ReadLine();
		}
}
