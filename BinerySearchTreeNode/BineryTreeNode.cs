using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BinerySearchTreeNode
{
    public class BineryTreeNode<T> : IComparable<BineryTreeNode<T>> where T : IComparable<T>
    {
        internal T value;
        internal BineryTreeNode<T> parent;
        internal BineryTreeNode<T> leftChild;
        internal BineryTreeNode<T> rightChild;

        public BineryTreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null values!");
            }

            this.value = value;
            this.parent = null;
            this.leftChild = null;
            this.rightChild = null;
        }

        public override string ToString()
        {
            return this.value.ToString();
        }

        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            BineryTreeNode<T> other = (BineryTreeNode<T>)obj;
            return this.CompareTo(other) == 0;
        }

        public int CompareTo(BineryTreeNode<T> other)
        {
            return this.value.CompareTo(other.value);
        }
    }
}
