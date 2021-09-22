using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapWithNext
{
    class SwapNext
    {
        string newStr;

        public SwapNext(string newStr)
        {
            this.newStr = newStr;
        }

        public void SwapWNext(string newStr)
        {
            char[] characters = new char[] { 'a','b','c','d','e','f','g',
                                             'h','i','j','k','l','m','n',
                                             'o','p','q','r','s','t','u',
                                             'v','w','x','y','z','a'};
            char[] strArr = new char[newStr.Length];

            for(int i=0; i < newStr.Length; i++)
            {
                strArr[i] = newStr[i];
            }

            char[] newStrArr = new char[newStr.Length];
            char temp = 'a';

            for (int i = 0; i < strArr.Length; i++)
            {
                for (int j = 0; j < characters.Length-1; j++)
                {
                    if (strArr[i] == characters[j])
                    {
                        temp = characters[j + 1];
                    }
                }
                newStrArr[i] = temp;
            }

            Console.WriteLine("New string: ");
            for (int i = 0; i < newStrArr.Length; i++)
            {
                Console.Write(newStrArr[i]); 
            }
            Console.WriteLine();
        }
    }
}
