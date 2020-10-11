using System;
using System.Collections.Generic;
using System.Text;

namespace BineryTreeDemo
{
    public class BineryTree<T>
    {
        private BineryTreeNode<T> root;

        public BineryTree(T value, BineryTree<T> leftChild, BineryTree<T> rightChild)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null values!");
            }

            BineryTreeNode<T> leftChildNode = leftChild != null ? leftChild.root : null;
            BineryTreeNode<T> rightChildNode = rightChild != null ? rightChild.root : null;

            this.root = new BineryTreeNode<T>(value, leftChildNode, rightChildNode);
        }

        public BineryTree(T value) : this(value, null, null)
        {

        }

        public BineryTreeNode<T> Root
        {
            get => this.root;
        }

        private void PrintInorder(BineryTreeNode<T> root, string spaces)
        {
            if (root == null)
            {
                return;
            }


            PrintInorder(root.LeftChild, spaces + "   ");


            Console.WriteLine(spaces + root.Value);

          

            PrintInorder(root.RightChild, spaces + "   ");
        }

        public void PrintInorder()
        {
            PrintInorder(this.root, string.Empty);

            Console.WriteLine();
        }

    }
}
