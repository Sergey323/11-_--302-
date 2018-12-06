using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace проверка_арифметики
{
    public class Program
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
            string str;
            Char[] znak=new Char[stroka.Length];
            for (int i = 0; i < stroka.Length; i++)
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
                        znak[0] = '+';
                        break;
                    case '-':
                        znak[1] = '-';
                        break;
                    case '*':
                        znak[2] = '*';
                        break;
                    case '/':
                        znak[3] = '/';
                        break;
                    case ' ':
                        break;
                    case '%':
                        znak[3] = '%';
                        break;







                    case '=':
                        string[] valid = stroka.Split('=');
                        if((chislo(valid[1])==true)||(Dubl(valid[1]) == true))
                        {
                            string[] id = new string[3];
                            foreach (Char da in znak)
                            {
                                if(da == 37)
                                {
                                    id = valid[0].Split('%');
                                    if (Convert.ToDouble(id[0]) % Convert.ToDouble(id[1]) == Convert.ToDouble(valid[1]))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        schetchik++;
                                        break;
                                    }
                                }
                                if (da == 42)
                                {
                                    id = valid[0].Split('*');
                                    if (Convert.ToDouble(id[0]) * Convert.ToDouble(id[1]) == Convert.ToDouble(valid[1]))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        schetchik++;
                                        break;
                                    }
                                }
                                if (da == 43)
                                {
                                    id = valid[0].Split('+');
                                    if (Convert.ToDouble(id[0]) + Convert.ToDouble(id[1]) == Convert.ToDouble(valid[1]))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        schetchik++;
                                        break;
                                    }
                                }
                                if (da == 47)
                                {
                                    id = valid[0].Split('/');
                                    if (Convert.ToDouble(id[0]) / Convert.ToDouble(id[1]) == Convert.ToDouble(valid[1]))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        schetchik++;
                                        break;
                                    }
                                }
                                if (da == 45)
                                {
                                    id = valid[0].Split('-');
                                    if (Convert.ToDouble(id[0]) - Convert.ToDouble(id[1]) == Convert.ToDouble(valid[1]))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        schetchik++;
                                        break;
                                    }
                                }
                                if (da == 94)
                                {
                                    id = valid[0].Split('^');
                                    if (Math.Pow(Convert.ToDouble(id[0]),Convert.ToDouble(id[1])) == Convert.ToDouble(valid[1]))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        schetchik++;
                                        break;
                                    }
                                }
                            }
                        }

                        break;
                        

                    case '^':
                        znak[4] = '^';
                        break;
                    case 'c':
                        str = Convert.ToString(stroka[i] + stroka[i + 1] + stroka[i + 2] + stroka[i + 3]);
                        if (str == "358" || str=="365")
                        {
                            i = i + 3;
                            schetchik++;
                            

                        }

                        else
                            schetchik++;
                        break;
                     case 's':
                        str = Convert.ToString(stroka[i] + stroka[i + 1] + stroka[i + 2] + stroka[i + 3]);
                        if (str == "370")
                        {
                            i = i + 3;
                            schetchik++;
                        }
                        break;
                    case 't':
                        str = Convert.ToString(stroka[i] + stroka[i + 1] + stroka[i + 2]);
                        if (str == "259")
                        {
                            i = i + 2;
                            schetchik++;
                        }
                        break;
                    case ')':
                        schetchik--;
                        break;
                    default:
                        schetchik++;
                        break;
                }
            }
            if (schetchik != 0)
            {
                return false; 
            }
            else
            {
                return true;
            }
        }

        public bool chislo(string test)
        {
            int num;
            bool isNum = int.TryParse(test, out num);
            if (isNum)
                return true;
            else
                return false;
        }


        public bool Dubl(string test)
        {
            double num;
            bool isNum = double.TryParse(test, out num);
            if (isNum)
                return true;
            else
                return false;
        }

    }
}
