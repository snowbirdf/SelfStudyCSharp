using System;

namespace InputAndOutput
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.Write を用いて、自分の名前を画面に表示せよ。
            Console.Write("I'm snowbird!");

            //Console.ReadLine を用いて文字列を1行読み込み、 Console.Write を用いて読んだ文字列をそのまま鸚鵡返しする
            var line = Console.ReadLine();

            Console.WriteLine(line);

            //おまけ： 1度読み込んだ文字列を2度ずつ鸚鵡返しするものを作成せよ
            var line2 = Console.ReadLine();
            for(var i = 0; i < 2; i++)
            {
                Console.WriteLine(line2);
            }
        }
    }
}
