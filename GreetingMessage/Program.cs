using System;
using Fmessage = Formal.Message;
using Cmessage = Casual.Message;
Console.WriteLine("=== 인사 테스트 ===");
Console.WriteLine("[격식체]");
Fmessage fmessage = new Fmessage();
fmessage.SayHello("홍길동");
fmessage.SayBye("홍길동");
Console.WriteLine();
Console.WriteLine("[비격식체]");
Cmessage cmessage = new Cmessage();
cmessage.SayHello("철수");
cmessage.SayBye("철수");
namespace Formal
{
    class Message
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"[{name}]님, 안녕하십니까!");
        }
        public void SayBye(string name)
        {
            Console.WriteLine($"[{name}]님, 안녕히 가십시오");
        }
    }
}

namespace Casual
{
    class Message
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"안녕, {name}!");
        }
        public void SayBye(string name)
        {
            Console.WriteLine($"잘 가, {name}");
        }
    }
}