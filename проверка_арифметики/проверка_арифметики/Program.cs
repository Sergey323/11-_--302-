using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace проверка_арифметики
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                {

            
                    Console.Write("ввведит строку ");
                    string stroka = Console.ReadLine();
                    Program p = new Program();
                    bool resh = p.prover_na_orifmet(stroka);
                    if (resh == true)
                    {
                        Console.Write("строка является арефметическим выражением");
                    }
                    else
                    {
                        Console.Write("строка не является арефметическим выражением");
                    }
            
                    Console.ReadLine();
            }
        }
        public bool prover_na_orifmet(string stroka)
        {
            if (stroka.Length < 2)
            {
                return false;
            }
            int schetchik=0;
            for(int i = 0; i < stroka.Length; i++)
            {
                switch (stroka[i])
                {
                    case '1':
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case '7':
                        break;
                    case '8':
                        break;
                    case '9':
                        break;
                    case '0':
                        break;
                    case '+':
                        break;
                    case '-':
                        break;
                    case '*':
                        break;
                    case '/':
                        break;
                    case ' ':
                        break;
                    case '%':
                        break;
                    case '^':
                        break;
                    default:
                        schetchik++;
                        break;
                }
            }
            if (schetchik > 0)
            {
                return false; 
            }
            else
            {
                return true;
            }
        }
    }
}
