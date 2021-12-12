
using Structures.Queue;

namespace Structures.Tree
{
    public class MyBinaryTree<T> where T : IComparable<T>
    {
        public enum TreeSearchType
        {
            NLR,
            LNR,
            LRN,

            BR
        }

        private class TreeNode
        {
            public T Value { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

            public TreeNode(T it)
            {
                Value = it;
                Left = null;
                Right = null;
            }
        }

        private TreeNode _root;

        private static void InsertDeep(TreeNode node, T value)
        {
            if (node == null)
                return;

            if (node.Value.CompareTo(value) > 0)
            {
                if (node.Left == null)
                    node.Left = new TreeNode(value);
                else
                    InsertDeep(node.Left, value);
            }
            else
            {
                if (node.Right == null)
                    node.Right = new TreeNode(value);
                else
                    InsertDeep(node.Right, value);
            }

        }

        public void Insert(T value)
        {
            if (_root == null)
            {
                _root = new TreeNode(value);
                return;
            }
            MyBinaryTree<T>.InsertDeep(_root, value);
        }

        private bool LeftRecurrent(TreeNode node, IList<T> input, object value, ref int steps)
        {
            if (value == null)
            {
                if (node == null)
                    return false;
                input.Add(node.Value);
                LeftRecurrent(node.Left, input, null, ref steps);
                LeftRecurrent(node.Right, input, null, ref steps);
                return false;
            }
            else
            {
                bool find;

                if (node == null)
                    return false;
                steps++;
                if (node.Value.Equals((T)value))
                    return true;

                find = LeftRecurrent(node.Left, input, value, ref steps);
                if (find)
                    return true;
                find = LeftRecurrent(node.Right, input, value, ref steps);
                return find;
            }
        }
        private bool CenterRecurrent(TreeNode node, IList<T> input, object value, ref int steps)
        {
            if (value == null)
            {
                if (node == null)
                    return false;
                CenterRecurrent(node.Left, input, null, ref steps);
                input.Add(node.Value);
                CenterRecurrent(node.Right, input, null, ref steps);
                return false;
            }
            else
            {
                bool find;

                if (node == null)
                    return false;
                steps++;
                find = CenterRecurrent(node.Left, input, value, ref steps);

                if (node.Value.Equals((T)value) || find)
                    return true;

                find = CenterRecurrent(node.Right, input, value, ref steps);
                return find;
            }
        }
        private bool RightRecurrent(TreeNode node, IList<T> input, object value, ref int steps)
        {
            if (value == null)
            {
                if (node == null)
                    return false;
                RightRecurrent(node.Left, input, null, ref steps);
                RightRecurrent(node.Right, input, null, ref steps);
                input.Add(node.Value);
                return false;
            }
            else
            {
                bool find;
                if (node == null)
                    return false;
                steps++;
                find = RightRecurrent(node.Left, input, value, ref steps);
                if (find)
                    return true;
                find = RightRecurrent(node.Right, input, value, ref steps);
                if (node.Value.Equals((T)value) || find)
                    return true;

                return find;
            }

        }

        public void GetNodesDeepFirst(IList<T> input, TreeSearchType type, ref int steps)
        {
            switch (type)
            {
                case TreeSearchType.NLR:
                    LeftRecurrent(_root, input, null, ref steps);
                    break;
                case TreeSearchType.LNR:
                    CenterRecurrent(_root, input, null, ref steps);
                    break;
                case TreeSearchType.LRN:
                    RightRecurrent(_root, input, null, ref steps);
                    break;
            }
        }

        public void GetNodesBreadthFirst(IList<T> input)
        {
            MyLinkedQueue<TreeNode> queue = new();
            queue.Enqueue(_root);
            while (!queue.IsEmpty)
            {
                TreeNode node = queue.Dequeue();
                input.Add(node.Value);
                if (node.Left != null)
                    queue.Enqueue(node.Left);
                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }
        }

        public bool FindNode(T value, TreeSearchType type, ref int steps)
        {
            switch (type)
            {
                case MyBinaryTree<T>.TreeSearchType.NLR:
                    return LeftRecurrent(_root, null, value, ref steps);
                case MyBinaryTree<T>.TreeSearchType.LNR:
                    return CenterRecurrent(_root, null, value, ref steps);
                case MyBinaryTree<T>.TreeSearchType.LRN:
                    return RightRecurrent(_root, null, value, ref steps);
                case MyBinaryTree<T>.TreeSearchType.BR:

                    MyLinkedQueue<TreeNode> queue = new();
                    queue.Enqueue(_root);
                    while (!queue.IsEmpty)
                    {
                        steps++;
                        TreeNode node = queue.Dequeue();
                        if (node.Value.Equals(value))
                            return true;
                        if (node.Left != null)
                            queue.Enqueue(node.Left);
                        if (node.Right != null)
                            queue.Enqueue(node.Right);
                    }
                    break;
            }

            return false;


            /*MyLinkedQueue<TreeNode> queue = new();
            queue.Enqueue(_root);
            while (!queue.IsEmpty)
            {
                TreeNode node = queue.Dequeue();
                input.Add(node.Value);
                if (node.Left != null)
                    queue.Enqueue(node.Left);
                if (node.Right != null)
                    queue.Enqueue(node.Right);
            }*/
        }
    }
}
