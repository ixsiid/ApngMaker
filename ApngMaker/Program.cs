using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PngParser;

namespace ApngMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Png png = new Png(@"..\..\test\source\1.png");
            png.Save(@"..\..\test\copy_1.png");

            Png[] pngs = new Png[3];
            for (int i = 0; i < 3; i++) pngs[i] = new Png(@"..\..\test\source\" + (i+1).ToString() + ".png");

            Png[] frames = new Png[] { pngs[1], pngs[2] };
            pngs[0].SaveApng(@"..\..\test\anime.png", frames, 10, 60);
        }
    }
}
