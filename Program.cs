namespace OOP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Value  type!");
			//Console.WriteLine("Reverence   type!");
			//// we can declare type using class ||  struct || Enum
			//// class Ref Type ( have no determine value )
			//// Enum  && struct Value Type  stored in stack (have determine value)
			//car c=new car();
			//// c is Referenc or Address 
			//// new car();   
			//// to use local variable you have to initial it 
			//int? v= null;
			//v = 4;
			//Console.WriteLine(v);
			for (int i = 0; i < 100; i++)
			{
				Console.WriteLine($"{i+1} I Love Shrouk ");
			}
		}
	}
	class car
	{

	}
}
