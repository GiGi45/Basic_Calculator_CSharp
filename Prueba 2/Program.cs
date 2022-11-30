namespace Girrafe
{
    class CV
    {

        public static int Menu()
        {
            Console.WriteLine("-1 para Salir");
            Console.WriteLine("Cualquier numero para Continuar");
            Console.WriteLine("Opcion a ingresar: ");
            int count = Convert.ToInt32(Console.ReadLine());
            return count;
        }

        public static void PrintNumbers(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i]+" "); }
        }

        public static void Operations(double[] arr)
        {
            Console.WriteLine("Enter a first number: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a second number: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the operator: ");
            string o = Console.ReadLine();
            double total = 0;
            int index = 0;
            switch (o)
            {
                case "+":
                    total = Math.Round(n1 + n2);
                    break;
                case "-":
                    total = Math.Round(n1 - n2);
                    break;
                case "*":
                    total = Math.Round(n1 * n2);
                    break;
                case "/":
                    total = Math.Round(n1 / n2);
                    break;
                default:
                    Console.WriteLine("No es un caracter valido");
                    break;
            }
            arr[index] = total;
            index++;
            Console.WriteLine($"El resultado es: {total} \n");
        }
        public static void Main()
        {
            try{
                Console.WriteLine("Welcome to my First Calculator");
                double[] arr = new double[20];
                int count = Menu();

                while (count != -1)
                {
                    Operations(arr);
                    count = Menu();
                }
                PrintNumbers(arr);
            }
            catch (Exception e){
                Console.WriteLine (e.Message);
            }                     
        }
    }
}