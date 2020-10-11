using System;
using System.Collections.Generic;
using System.Text;

namespace BinerySearchTreeNode
{
    public class BinerySearchTree<T> where T: IComparable<T>
    {
        private BineryTreeNode<T> root;

        public BinerySearchTree()
        {
            this.root = null;
        }

        public void Insert(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            this.root = Insert(value, null, root);
        }

        private BineryTreeNode<T> Insert (T value, BineryTreeNode<T> parentNode, BineryTreeNode<T> node)
        {
            if (node == null)
            {
                node = new BineryTreeNode<T>(value);
                node.parent = parentNode;
            }
            else
            {
                int compareTo = value.CompareTo(node.value);

                if (compareTo < 0)
                {
                    node.leftChild = Insert(value, node, node.leftChild);
                }
                else if (compareTo > 0)
                {
                    node.rightChild = Insert(value, node, node.rightChild);
                }
            }

            return node;
        }

        public BineryTreeNode<T> Find (T value)
        {
            BineryTreeNode<T> node = this.root;

            while(node != null)
            {
                int compareTo = value.CompareTo(node.value);

                if (compareTo < 0)
                {
                    node = node.leftChild;
                }
                else if (compareTo > 0)
                {
                    node = node.rightChild;
                }
                else
                {
                    break;
                }
            }

            return node;
        }

        public void Remove(T value)
        {
            BineryTreeNode<T> nodeToDelete = Find(value);

            if (nodeToDelete == null)
            {
                return;
            }

            Remove(nodeToDelete);
        }

        private void Remove(BineryTreeNode<T> nodeToDelete)
        {
            if (nodeToDelete.leftChild != null && nodeToDelete.rightChild != null)
            {
                BineryTreeNode<T> replacement = nodeToDelete.rightChild;

                while(replacement.leftChild != null)
                {
                    replacement = replacement.leftChild;
                }

                nodeToDelete.value = replacement.value;
                nodeToDelete = replacement;
            }

            BineryTreeNode<T> theChild = nodeToDelete.leftChild != null ? nodeToDelete.leftChild : nodeToDelete.rightChild;

            if (theChild !=null)
            {
                theChild.parent = nodeToDelete.parent;

                if (nodeToDelete.parent == null)
                {
                    root = theChild;
                }
                else
                {
                    if (nodeToDelete.parent.leftChild == nodeToDelete)
                    {
                        nodeToDelete.parent.leftChild = theChild;
                    }
                    else
                    {
                        nodeToDelete.parent.rightChild = theChild;
                    }
                }
            }
            else
            {
                if (nodeToDelete.parent == null)
                {
                    root = null;
                }
                else
                {
                    if (nodeToDelete.parent.leftChild == nodeToDelete)
                    {
                        nodeToDelete.parent.leftChild = null;
                    }
                    else
                    {
                        nodeToDelete.parent.rightChild = null;
                    }
                }
            }
        }
    }
}
