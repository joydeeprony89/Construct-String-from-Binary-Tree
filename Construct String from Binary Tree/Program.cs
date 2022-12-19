// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Solution s = new Solution();
TreeNode root = new TreeNode(1);
root.left = new TreeNode(2);
root.left.left = new TreeNode(4);
root.right = new TreeNode(3);
var answer = s.Tree2str(root);
Console.WriteLine(answer);

public class TreeNode
{
  public int val;
  public TreeNode left;
  public TreeNode right;
  public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
  {
    this.val = val;
    this.left = left;
    this.right = right;
  }
}

public class Solution
{
  public string Tree2str(TreeNode root)
  {
    List<string> res= new List<string>();

    void Preorder(TreeNode root)
    {
      // Preorder - root->left->right

      // base condition
      if (root == null) return;

      res.Add("(");
      res.Add(root.val.ToString());
      if (root.left == null && root.right != null)
        res.Add("()");
      Preorder(root.left);
      Preorder(root.right);

      res.Add(")");
    }

    Preorder(root);
    string str = string.Join("",res);
    return str.Substring(1, str.Length - 2);
  }
}