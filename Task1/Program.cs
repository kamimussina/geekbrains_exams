Console.Clear();
            int Prompt(string message)
            {
              Console.Write(message);
              int result = Convert.ToInt32(Console.ReadLine());
              return result;
            }
            
            int NaturalNumber(int n, int m)
            {
              if (n == m) return n;
              else Console.Write($"{NaturalNumber(n, m + 1)}, ");
              return m;
            }
            
            int n = Prompt("Input N: ");
            int m = Prompt("Input M: ");
            if (n < 1 || m < 1) 
            {
              Console.WriteLine("Error: Enter a natural number!");
              return;
            }
            if (n < m)
            {
              Console.WriteLine("Error: N must be more than M. Try again!");
              return;
            }
Console.WriteLine(NaturalNumber(n, m));