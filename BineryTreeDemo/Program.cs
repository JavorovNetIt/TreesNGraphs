using System;

namespace BineryTreeDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BineryTree<int> tree = new BineryTree<int>(14, 
                    new BineryTree<int>(19,
                        new BineryTree<int>(23),
                        new BineryTree<int>(6,
                            new BineryTree<int>(10),
                            new BineryTree<int>(21))),
                    new BineryTree<int>(15,
                        new BineryTree<int>(3),
                        null)
                );

            tree.PrintInorder();
        }
    }
}
