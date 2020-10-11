using System;
using System.Collections.Generic;
using System.Text;

namespace BineryTreeDemo
{
    public class BineryTreeNode<T>
    {
        private T value;
        private bool hasParent;
        private BineryTreeNode<T> leftChild;
        private BineryTreeNode<T> rightChild;

        public BineryTreeNode(T value, BineryTreeNode<T> leftChild, BineryTreeNode<T> rightChild)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null values!");
            }

            this.value = value;
            this.leftChild = leftChild;
            this.rightChild = rightChild;
        }

        public BineryTreeNode(T value) : this(value,null, null)
        {

        }

        public T Value 
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public BineryTreeNode<T> LeftChild
        {
            get { return this.leftChild; }
            set 
            {
                if (value == null)
                {
                    return;
                }

                if (value.hasParent)
                {
                    throw new ArgumentException("The node already has a parent!");
                }

                value.hasParent = true;
                this.leftChild = value;
            }
        }

        public BineryTreeNode<T> RightChild
        {
            get { return this.rightChild; }
            set
            {
                if (value == null)
                {
                    return;
                }

                if (value.hasParent)
                {
                    throw new ArgumentException("The node already has a parent!");
                }

                value.hasParent = true;
                this.rightChild = value;
            }
        }

    }
}
