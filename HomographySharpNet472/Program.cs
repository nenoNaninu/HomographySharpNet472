using HomographySharp;
using System;
using System.Collections.Generic;

namespace HomographySharpNet472
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var srcList = new List<Point2<double>>(4);
            var dstList = new List<Point2<double>>(4);

            srcList.Add(new Point2<double>(-152, 394));
            srcList.Add(new Point2<double>(218, 521));
            srcList.Add(new Point2<double>(223, -331));
            srcList.Add(new Point2<double>(-163, -219));
            dstList.Add(new Point2<double>(-666, 431));
            dstList.Add(new Point2<double>(500, 300));
            dstList.Add(new Point2<double>(480, -308));
            dstList.Add(new Point2<double>(-580, -280));

            var homo = Homography.Find(srcList, dstList);

            {
                var result = homo.Translate(-152, 394);
                Console.WriteLine(Math.Abs(result.X - -666) < 0.001);
                Console.WriteLine(Math.Abs(result.Y - 431) < 0.001);
            }

            {
                var result = homo.Translate(218, 521);
                Console.WriteLine(Math.Abs(result.X - 500) < 0.001);
                Console.WriteLine(Math.Abs(result.Y - 300) < 0.001);
            }

            {
                var result = homo.Translate(223, -331);
                Console.WriteLine(Math.Abs(result.X - 480) < 0.001);
                Console.WriteLine(Math.Abs(result.Y - -308) < 0.001);
            }

            Console.WriteLine(homo);
        }
    }
}

