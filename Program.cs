using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFC
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime hoy = new DateTime();
            hoy = DateTime.Now;
            string fech = ServiceGFH(hoy);
            
            Console.WriteLine(fech);
            

            string ServiceGFH(DateTime fecha)
            {
                string dia = "";
                int d = fecha.Day;
                if (d < 10)
                {
                     dia = "0" + fecha.Day.ToString();
                } else
                {
                    dia = fecha.Day.ToString();
                }
                string hora = fecha.Hour.ToString();
                string minutos = fecha.Minute.ToString();
                string anio = fecha.Year.ToString().Substring(2);
                string mes = fecha.Month.ToString();
               switch (mes)
                {
                    case "1":
                        mes = "ENE";
                        break;
                    case "2":
                        mes = "FEB";
                        break;
                    case "3":
                        mes = "MAR";
                        break;
                    case "4":
                        mes = "ABR";
                        break;
                    case "5":
                        mes = "MAY";
                        break;
                    case "6":
                        mes = "JUN";
                        break;
                    case "7":
                        mes = "JUL";
                        break;
                    case "8":
                        mes = "AGO";
                        break;
                    case "9":
                        mes = " SEP ";
                        break;
                    case "10":
                        mes = "OCT";
                        break;
                    case "11":
                        mes = "NOV";
                        break;
                    case "12":
                        mes = "DIC";
                        break;

                };

                string gfh = dia + " " + hora + minutos + mes + anio;

                return gfh;

            };
        }
    }
}
