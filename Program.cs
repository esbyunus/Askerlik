using System.Diagnostics.Tracing;

namespace Askerlik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yasinizi giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Okuyor musunuz? (evet/hayir): ");
            string okul = Console.ReadLine().ToLower();

            if (yas > 18)
            {
                if (okul == "evet")
                {
                    Console.WriteLine("Askerlige cagrilmaz.");
                }
                else if (okul == "hayir")
                {
                    Console.WriteLine("Askerlige cagrilabilir");
                }
                else
                {
                    Console.WriteLine("Hatali yazim");
                }
            }
            else
            { 
                Console.WriteLine("Askerlige cagrilmaz");
            }
        }
    }
}