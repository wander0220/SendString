using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendString
{
    class Program
    {
        public delegate void SendString(string messenge);
        static void Main(string[] args)
        {
            SendString sayHello, sayGoodbye, multiDelegate;
            sayHello = Hello;
            sayGoodbye = Goodbye;

            multiDelegate = sayHello + sayGoodbye;
            multiDelegate("윤인성");

            Console.WriteLine();multiDelegate -= sayGoodbye; //sayGoodbye 연결 해제
            multiDelegate("윤인성");
        }

        private static void Goodbye(string messenge)
        {
            Console.WriteLine("안녕하세요~ " + messenge + "씨...!");
        }

        private static void Hello(string messenge)
        {
            Console.WriteLine("안녕히가세요~ " + messenge + "씨...!");
        }
    }
}
