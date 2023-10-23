// See https://aka.ms/new-console-template for more information

using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using Sword.Core;

// UInt32[][] map = new UInt32[][]
// {
//     SHAQ.ScheduleA,
//     SHAQ.ScheduleB,
//     SHAQ.ScheduleC,
//     SHAQ.ScheduleD,
//     SHAQ.ScheduleE,
//     SHAQ.ScheduleF,
//     SHAQ.ScheduleG,
//     SHAQ.ScheduleH,
// };

Console.WriteLine($"Initial State : \n");


UInt32[][] State = new UInt32[][]
{
    new UInt32[]
    {
        0x6a09, 0xe667,
        0xbb67, 0xae85,
        0x3c6e, 0xf372,
        0xa54f, 0xf53a,
        0x510e, 0x527f,
        0x9b05, 0x688c,
        0x1f83, 0xd9ab,
        0x5be0, 0xcd19        
    }
};

var cube = new Hypercube(State);

Console.WriteLine();
Console.WriteLine();


bool IsCanceled = false;
int frame = 0;
while (!IsCanceled)
{
    Console.WriteLine($"[Frame {frame}]");
    Console.WriteLine();
    cube.Render();
    cube.Hash();
    var read = Console.ReadKey();
    frame++;
    Console.Clear();
}

cube.RenderFinal();

