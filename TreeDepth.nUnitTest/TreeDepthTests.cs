namespace TreeDepth.nUnitTest
{
    public class Tests
    {
     
        [Test]
        public void Test1()
        {

            Program.TreeNode root = Program.newTreeNode(1);

            Assert.AreEqual(1, Program.getDepth(root));
           
        }
        [Test]
        public void Test2()
        {

            Program.TreeNode root = Program.newTreeNode(1);

            (root.child).Add(Program.newTreeNode(11));
            
            Assert.AreEqual(2, Program.getDepth(root));

        }
        [Test]
        public void Test3()
        {

            Program.TreeNode root = Program.newTreeNode(1);

            (root.child).Add(Program.newTreeNode(11));
            (root.child[0].child).Add(Program.newTreeNode(111));

            Assert.AreEqual(3, Program.getDepth(root));

        }
    }
}