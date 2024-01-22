using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
namespace PoPRefactoring;

public class PopProject
{
    public static void Main(string[] args)
    {
        const string MsgInputDay = "Introdueix el dia";
        const string MsgInputMonth = "Introdueix el mes";
        const string MsgInputYear = "Introdueix l'any";
        const string MsgIncorectFormat = "El format no és correcte";
        const string MsgCorrectFormat = "La data és correcta";
        int dia, mes, any;
        bool validat;
        Console.WriteLine(MsgInputDay);
        dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(MsgInputMonth);
        mes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(MsgInputYear);
        any = Convert.ToInt32(Console.ReadLine());
        validat = Valida(dia, mes, any);
        if (validat)
        {
            Console.WriteLine(MsgCorrectFormat);
        } else
        {
            Console.WriteLine(MsgIncorectFormat);
        }
    }

    public static bool Valida(int day, int month, int year)
    {

        if (day < 1 || day > 31)

            return false;

        if (month < 1 || month > 12)

            return false;

        // determinem la quantitat de dies del mes:

        int totalDaysMonth = 0;

        switch (month)
        {

            case 1:

            case 3:

            case 5:

            case 7:

            case 8:

            case 10:

            case 12: totalDaysMonth = 31; break;

            case 4:

            case 6:

            case 9:

            case 11: totalDaysMonth = 30; break;

            case 2: // verifica l'any de traspàs

                if ((year % 400 == 0) ||

                ((year % 4 == 0) && (year % 100 != 0)))
                    totalDaysMonth = 29;

                else totalDaysMonth = 28;

                break;

        }

        if (day > totalDaysMonth)

            return false;

        else return true;

    }
}
