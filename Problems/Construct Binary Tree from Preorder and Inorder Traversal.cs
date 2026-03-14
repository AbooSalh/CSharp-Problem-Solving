namespace CSPS.Problems;
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal: IProblem
{
    public string Result => BuildTree(new[] { 3, 9, 20, 15, 7 }, new[] { 9, 3, 15, 20, 7 }).val.ToString();

    private int _preorderIndex;
    private Dictionary<int, int> _inorderIndexByValue = new();

    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        if (preorder == null || inorder == null)
        {
            throw new ArgumentNullException(preorder == null ? nameof(preorder) : nameof(inorder));
        }

        if (preorder.Length != inorder.Length)
        {
            throw new ArgumentException("preorder and inorder must have the same length");
        }

        _preorderIndex = 0;
        _inorderIndexByValue = new Dictionary<int, int>(inorder.Length);

        for (int i = 0; i < inorder.Length; i++)
        {
            _inorderIndexByValue[inorder[i]] = i;
        }

        return BuildSubtree(preorder, 0, inorder.Length - 1);
    }

    private TreeNode BuildSubtree(int[] preorder, int inorderLeft, int inorderRight)
    {
        if (inorderLeft > inorderRight)
        {
            return null!;
        }

        int rootValue = preorder[_preorderIndex++];
        TreeNode root = new(rootValue);
        int inorderRootIndex = _inorderIndexByValue[rootValue];

        root.left = BuildSubtree(preorder, inorderLeft, inorderRootIndex - 1);
        root.right = BuildSubtree(preorder, inorderRootIndex + 1, inorderRight);

        return root;
    }
}
