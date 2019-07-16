# ApngMaker

``` main.cs
using System;
using PngParser;

namespace ApngMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Png png = new Png(@"original.png");
            png.Save(@"copy.png");

            Png[] pngs = new Png[3];
            for (int i = 0; i < 3; i++) pngs[i] = new Png(i.ToString() + ".png");

            Png[] frames = new Png[] { pngs[1], pngs[2] };
            pngs[0].SaveApng(@"anime.png", frames, 10, 60);
        }
    }
}
```
