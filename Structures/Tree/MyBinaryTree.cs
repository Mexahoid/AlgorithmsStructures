
using Structures.Queue;

namespace Structures.Tree
{
    public class MyBinaryTree<T> where T : IComparable<T>
    {
        public enum TreeSearchType
        {
            NLR,
            LNR,
            LRN
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

        private void LeftRecurrent(TreeNode node, IList<T> input)
        {
            if (node == null)
                return;
            input.Add(node.Value);
            LeftRecurrent(node.Left, input);
            LeftRecurrent(node.Right, input);
        }
        private void CenterRecurrent(TreeNode node, IList<T> input)
        {
            if (node == null)
                return;
            CenterRecurrent(node.Left, input);
            input.Add(node.Value);
            CenterRecurrent(node.Right, input);
        }
        private void RightRecurrent(TreeNode node, IList<T> input)
        {
            if (node == null)
                return;
            RightRecurrent(node.Left, input);
            RightRecurrent(node.Right, input);
            input.Add(node.Value);
        }

        public void DeepFirst(IList<T> input, TreeSearchType type)
        {
            switch (type)
            {
                case TreeSearchType.NLR:
                    LeftRecurrent(_root, input);
                    break;
                case TreeSearchType.LNR:
                    CenterRecurrent(_root, input);
                    break;
                case TreeSearchType.LRN:
                    RightRecurrent(_root, input);
                    break;
            }
        }

        public void BreadthFirst(IList<T> input)
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
    }
}
