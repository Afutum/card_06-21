using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_06_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cardNum = new int[4];

            for(int i = 0; i < cardNum.Length; i++)
            {
                Console.Write("カードの番号を入力してください ＞");
                cardNum[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
