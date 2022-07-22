namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //logical operators: and (&&), or  (||), not (!) 
            //relational operators: ==, !=, >=, <=, <, >,
            //arithmetic operators: +, -, *, /, %
            //assignement operator: = 

            /* buraya
             * yazdigin her sey
             * commente 
             * alinir.  
             */

            /* 
             * p    q   ve (&&) (*)
             * 1    1   1   
             * 1    0   0   
             * 0    1   0   
             * 0    0   0   
             * 
             * 
             * p    q   veya (||) (+)
             * 1    1   1   
             * 1    0   1   
             * 0    1   0   
             * 0    0   0
             */

            var number = 11;
            if (number == 10)
            {
                Console.WriteLine("Number is 10.");
            }
            else
            {
                Console.WriteLine("Number is not 10.");

            }

            string numberText = number == 10 ? "Number is 10." : "Number is not 10."; // ternary operator
            Console.WriteLine(numberText);

            number = 20;
            if (number == 10)
                Console.WriteLine("Number is 10.");
            else if (number == 20) // 10 degil ama 20 demek 
                Console.WriteLine("Number is 20.");
            else
                Console.WriteLine("Number is not 10 or 20");

            number = 50;
            switch (number)
            {
                case 10: Console.WriteLine("Number is 10.");
                    break;
                case 20: Console.WriteLine("Number is 20.");
                    break; 
                default: Console.WriteLine("Number is not 10 or 20");
                    break; 

            }

            number = 100;
            if (number >= 0 && number <= 100)
                Console.WriteLine("Number is from 0 to 100");
            else if (number > 100 && number <= 200)
                Console.WriteLine("Number is from 100 to 200");
            else
                Console.WriteLine("Number is not from 100 to 200");
            
            //ücüncü kisimda else yazdigimizda yanina gelen kosul su: 
            //else if (!(number >= 0 && number <= 200))
            //Console.WriteLine("Number is not from 100 to 200"); 
            //yazmak zorunda degiliz. otomatik tamamliyo!!1







        }
    }
}