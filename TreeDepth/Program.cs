using System.Xml.Linq;

namespace TreeDepth
{
    public class Program
    {
        public class TreeNode
        {
            public int key;
            public List<TreeNode> child;
        };

        public static TreeNode newTreeNode(int key)
        {
            TreeNode temp = new TreeNode();
            temp.key = key;
            temp.child = new List<TreeNode>();
            return temp;
        }

        public static int getDepth(TreeNode subTree)
        {
            if (subTree == null)
            {
                return 0;
            }

            int depth = 0;
            foreach (TreeNode node in subTree.child)
            {
                depth = Math.Max(depth, getDepth(node));
            }
            return depth + 1;
        }

       static void Main(string[] args)
        {

            TreeNode root = newTreeNode(1);

            (root.child).Add(newTreeNode(11));
            (root.child).Add(newTreeNode(12));

            (root.child[0].child).Add(newTreeNode(111));
            (root.child[0].child).Add(newTreeNode(112));
            (root.child[1].child).Add(newTreeNode(121));

            (root.child[0].child[0].child).Add(newTreeNode(1111));
            (root.child[0].child[0].child).Add(newTreeNode(1112));
            (root.child[0].child[1].child).Add(newTreeNode(1121));

            (root.child[0].child[1].child[0].child).Add(newTreeNode(11211));

            Console.Write($"Depth of tree structure is {getDepth(root)} layers");
        }
    }
}