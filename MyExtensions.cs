using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_9___Extension_Methods_and_This
{
    public static class MyExtensions
    {
        //viskas ka cia darome turi buti static ir property ir metodai
        //visuose metoduose turime parasyti THIS 

        public static bool IsPositive(this int number)
        {
            return number > 0;
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }


        public static bool IsLarger(this int number, int number2)
        {
            return number < number2;
        }


        public static bool AreSpaces(this string content)
        {
            return content.Contains(" ");
        }


        public static string MakeEmail(this string fullname, string yearOfBirth, string domain)
        {
            return fullname + yearOfBirth + "@" + domain;
        }


        public static T FindAndReturnIfEqual<T>(this List<T> list, T kazkas)//negali buti object, nes kartasi pavadinimas
        {//generic metodai turi tureti <T> pries skliaustelius

            if (list.Contains(kazkas))
            {
                return kazkas;
            }
            else return default;//default, jei int - tai 0, jei string - null;


        }



        //<T> tipo objektą kaip parametrą ir grąžintų tokį patį, jeigu sąraše jis egzistuoja.



        public static int WordCount(string str)
        {
            var wordsArray = str.Split(new char[] { ' ', '.', '?', '!', ':' }, StringSplitOptions.RemoveEmptyEntries);
            return wordsArray.Length;
        }

        public static int WordCount2(this string str)//this leidzia iskviesti tiesiai is objekto
        {
            var wordsArray = str.Split(new char[] { ' ', '.', '?', '!', ':' }, StringSplitOptions.RemoveEmptyEntries);
            return wordsArray.Length;
        }

        public static bool IsNegative(this int integer)
        {
            return integer < 0;
        }


        public static bool IsAdult(this int integer)
        {
            return integer < 0;
        }
    }
}
