using System;
using System.Collections.Generic;
using System.Text;

namespace TreesDemo
{
    public class Tree<T>
    {
        private TreeNode<T> root;

        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value");
            }

            this.root = new TreeNode<T>(value);
        }

        public Tree(T value, params Tree<T>[] children) : this(value)
        {
            foreach (var child in children)
            {
                this.root.AddChild(child.root);
            }
        }

        public TreeNode<T> Root { get => this.root; }

        private void PrintDFS(TreeNode<T> root, string spaces)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(spaces + root.Value);

            TreeNode<T> child = null;

            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                PrintDFS(child, spaces + "   ");
            }
        }

        public void PrindDFS()
        {
            PrintDFS(this.root, string.Empty);
        }
    }
}
