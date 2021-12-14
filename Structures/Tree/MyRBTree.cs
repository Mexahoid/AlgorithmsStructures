using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures.Tree
{
    public class MyRBTree<T> where T : IComparable<T>
    {
        public bool IsEmpty => _count == 0;
        private int _count;

        private class TreeNode
        {
            public T Value { get; set; }

            public bool Black { get; set; }

            public TreeNode Parent { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

            public bool Nil { get; set; }

            public TreeNode(T val, bool isBlack)
            {
                Black = isBlack;
                Value = val;

                Left = new TreeNode();
                Right = new TreeNode();
                Nil = false;

                /* if (!val.Equals(default(T)))
                 {
                     Left = new TreeNode(default, true);
                     Right = new TreeNode(default, true);
                 }*/
            }

            private TreeNode()
            {
                Black = true;
                Nil = true;
            }
        }

        private TreeNode _root;

        public MyRBTree()
        {
            _count = 0;
        }


        private void RotateLeft(TreeNode x)
        {
            var y = x.Right;
            x.Right = y.Left;
            if (y.Left != null && !y.Left.Nil)
                y.Left.Parent = x;

            if (y != null && !y.Nil)
                y.Parent = x.Parent;

            if (x.Parent != null)
            {
                if (x == x.Parent.Left)
                    x.Parent.Left = y;
                else
                    x.Parent.Right = y;
            }
            else
            {
                _root = y;
            }

            y.Left = x;
            if (x != null && !x.Nil)
                x.Parent = y;
        }

        private void RotateRight(TreeNode x)
        {
            var y = x.Left;
            x.Left = y.Right;
            if (y.Right != null && !y.Right.Nil)
                y.Right.Parent = x;

            if (y != null && !y.Nil)
                y.Parent = x.Parent;

            if (x.Parent != null)
            {
                if (x == x.Parent.Right)
                    x.Parent.Right = y;
                else
                    x.Parent.Left = y;
            }
            else
            {
                _root = y;
            }

            y.Right = x;
            if (x != null && !x.Nil)
                x.Parent = y;
        }

        private void InsertFix(TreeNode x)
        {
            while (x != _root && !x.Parent.Black)
            {
                bool right = x.Parent == x.Parent.Parent.Left;
                var y = right ? x.Parent.Parent.Right : x.Parent.Parent.Left;

                if (y.Black)
                {
                    if (right)
                    {
                        if (x == x.Parent.Right)
                        {
                            x = x.Parent;
                            RotateLeft(x);
                        }
                    }
                    else
                    {
                        if (x == x.Parent.Left)
                        {
                            x = x.Parent;
                            RotateRight(x);
                        }
                    }
                    x.Parent.Black = true;
                    x.Parent.Parent.Black = false;
                    if (right)
                        RotateRight(x.Parent.Parent);
                    else
                        RotateLeft(x.Parent.Parent);

                }
                else
                {
                    x.Parent.Black = true;
                    y.Black = true;
                    x.Parent.Parent.Black = false;
                    x = x.Parent.Parent;
                }
            }
            _root.Black = true;
        }

        private void DeleteFix(TreeNode x)
        {
            while (x != _root && x.Black)
            {
                bool left = x == x.Parent.Left;
                var w = left ? x.Parent.Right : x.Parent.Left;

                if (!w.Black)
                {
                    w.Black = true;
                    x.Parent.Black = false;
                    if (left)
                    {
                        RotateLeft(x.Parent);
                        w = x.Parent.Right;
                    }
                    else
                    {
                        RotateRight(w);
                        w = x.Parent.Right;
                    }
                }

                if (w.Left.Black && w.Right.Black)
                {
                    w.Black = false;
                    x = x.Parent;
                }
                else
                {
                    var tnr = left ? w.Right : w.Left;
                    var tnl = left ? w.Left : w.Right;

                    if (tnr.Black)
                    {
                        tnl.Black = true;
                        w.Black = false;
                        if (left)
                        {
                            RotateRight(w);
                            w = x.Parent.Right;
                        }
                        else
                        {
                            RotateLeft(w);
                            w = x.Parent.Left;
                        }
                    }
                    w.Black = x.Parent.Black;
                    x.Parent.Black = true;
                    if (left)
                    {
                        w.Right.Black = true;
                        RotateLeft(x.Parent);
                    }
                    else
                    {
                        w.Left.Black = true;
                        RotateRight(x.Parent);
                    }
                    x = _root;
                }
            }
            x.Black = true;
        }

        private void DeleteNode(TreeNode z)
        {
            TreeNode x;
            TreeNode y;

            if (z == null || z.Nil)
                return;

            if (z.Left != null && z.Left.Nil || z.Right == null || z.Right.Nil)
            {
                y = z;
            }
            else
            {
                y = z.Right;
                while (y.Left != null && !y.Left.Nil)
                    y = y.Left;
            }

            if (y.Left != null && !y.Left.Nil)
                x = y.Left;
            else
                x = y.Right;

            x.Parent = y.Parent;
            if (y.Parent != null)
            {
                if (y.Parent.Left == y)
                    y.Parent.Left = x;
                else
                    y.Parent.Right = x;

            }
            else
                _root = x;

            if (y != z)
                z.Value = y.Value;

            if (y.Black)
                DeleteFix(x);
            _count--;
        }

        private TreeNode FindNode(T value)
        {
            var current = _root;
            while (current != null && !current.Nil)
            {
                if (current.Value.Equals(value))
                    return current;
                current = value.CompareTo(current.Value) < 0 ? current.Left : current.Right;
            }
            return null;
        }


        public bool Insert(T value)
        {
            TreeNode current = _root;
            TreeNode parent = null;

            while (current != null && !current.Nil)
            {
                if (current.Value.Equals(value))
                    return false;

                parent = current;
                current = value.CompareTo(current.Value) < 0 ? current.Left : current.Right;
            }
            TreeNode x = new(value, false);
            x.Parent = parent;

            if (parent != null)
            {
                if (value.CompareTo(parent.Value) < 0)
                    parent.Left = x;
                else
                    parent.Right = x;
            }
            else
            {
                _root = x;
            }
            InsertFix(x);
            _count++;
            return true;
        }

        public bool IsPresent(T value)
        {
            var x = FindNode(value);
            return x != null;
        }

        public void Delete(T value)
        {
            var x = FindNode(value);
            DeleteNode(x);
        }

    }
}
