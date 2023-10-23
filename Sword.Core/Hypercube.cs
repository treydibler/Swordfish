using System.Text;
using MathNet.Numerics.Random;

namespace Sword.Core;

public interface IHypercube
{
    void Render();
    void RenderFinal();
}

public class Hypercube : IHypercube
{
    public UInt32[][] State { get; set; }
    
    
    public const UInt32 BATMAN = 0x0000000F;
    
    public uint CursorColumn { get; set; }
    public uint CursorRow { get; set; }
    public uint CursorDepth { get; set; }
    
    public Hypercube(UInt32[][] state)
    {
        State = state;
    }

    public void Render()
    {
        for (var i = 0; i < State.Length; i++)
        {
            if (i % 4 == 0 && i > 0)
            {
                Console.WriteLine();    
            }
            
            for (var j = 0; j < State[i].Length; j++)
            {
                var result = BitConverter.GetBytes(State[i][j]);
                Console.Write($"{Convert.ToHexString(result)}  ");
            }
            Console.WriteLine();
        }
    }

    public void RenderFinal()
    {
        throw new NotImplementedException();
    }

    public void Render(UInt32[][] state)
    {
        for (var i = 0; i < state.Length; i++)
        {
            if (i % 4 == 0 && i > 0)
            {
                Console.WriteLine();    
            }
            
            for (var j = 0; j < state[i].Length; j++)
            {
                var result = BitConverter.GetBytes(state[i][j]);
                Console.Write($"{Convert.ToHexString(result)}  ");
            }
            Console.WriteLine();
        }
    }

    public void Hash()
    {
        for (var i = 0; i < State.Length; i++)
        {
            for (var j = 0; j < State[i].Length; j++)
            {
                StringBuilder sb = new StringBuilder();
                
                for (var s1 = 0; s1 < SHAQ.ScheduleA.Length - 1; s1++)
                {
                    State[i][j] = BATMAN ^ SHAQ.ScheduleA[s1];
                    sb.Append($"{State[i][j]}\t");
                }
                
                for (var s2 = 0; s2 < SHAQ.ScheduleB.Length - 1; s2++)
                {
                    State[i][j] = BATMAN ^ SHAQ.ScheduleB[s2];
                    sb.Append($"{State[i][j]}\t");
                }
                
                for (var s3 = 0; s3 < SHAQ.ScheduleC.Length - 1; s3++)
                {
                    State[i][j] = BATMAN ^ SHAQ.ScheduleC[s3];
                    sb.Append($"{State[i][j]}\t");
                }
                
                for (var s4 = 0; s4 < SHAQ.ScheduleD.Length - 1; s4++)
                {
                    State[i][j] = BATMAN ^ SHAQ.ScheduleD[s4];
                    sb.Append($"{State[i][j]}\t");
                }
                
                for (var s5 = 0; s5 < SHAQ.ScheduleE.Length; s5++)
                {
                    State[i][j] = BATMAN ^ SHAQ.ScheduleE[s5];
                    sb.Append($"{State[i][j]}\t");
                }
                
                for (var s6 = 0; s6 < SHAQ.ScheduleF.Length; s6++)
                {
                    State[i][j] = BATMAN ^ SHAQ.ScheduleF[s6];
                    sb.Append($"{State[i][j]}\t");
                }
                
                for (var s7 = 0; s7 < SHAQ.ScheduleG.Length; s7++)
                {
                    State[i][j] = BATMAN ^ SHAQ.ScheduleG[s7];
                    sb.Append($"{State[i][j]}\t");
                }
                
                for (var s8 = 0; s8 < SHAQ.ScheduleH.Length; s8++)
                {
                    State[i][j] = BATMAN ^ SHAQ.ScheduleH[s8];
                    sb.Append($"{State[i][j]}\t");
                }
                
                Console.WriteLine(sb.ToString());
            }
        }
    }
}