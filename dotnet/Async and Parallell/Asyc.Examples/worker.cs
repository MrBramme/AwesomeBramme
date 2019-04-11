using System;
using System.Threading.Tasks;

namespace Asyc.Examples
{
    public class Worker
    {
        private readonly string _name;
        public Worker(string name)
        {
            _name = name;
        }

        public async Task<string> Run()
        {
            await Task.Run(() =>
                {
                    Console.WriteLine($"{DateTime.Now:HH:mm:ss} {_name}: Starting run with a 2 second sleep");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine($"{DateTime.Now:HH:mm:ss} {_name}: Sleeping another 2 seconds");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine($"{DateTime.Now:HH:mm:ss} {_name}: Done");
                }
            );
            return _name;
        }
    }
}
