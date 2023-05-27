namespace ControleWork1
{
    class Node
    {
        public string Value;
        public Node Left;
        public Node Right;

        public Node(string value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    class BinarySearchTree
    {
        public Node root;

        public void Insert(string value)
        {
            if (root == null)
            {
                root = new Node(value);
                return;
            }

            Node current = root;
            Node parent = null;
            while (current != null)
            {
                parent = current;
                if (String.Compare(value, current.Value) < 0)
                    current = current.Left;
                else
                    current = current.Right;
            }

            if (String.Compare(value, parent.Value) < 0)
                parent.Left = new Node(value);
            else
                parent.Right = new Node(value);
        }

        public void TraverseInOrder(Node node)
        {
            if (node != null)
            {
                TraverseInOrder(node.Left);
                Console.WriteLine(node.Value);
                TraverseInOrder(node.Right);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            BinarySearchTree tree = new BinarySearchTree();
            string[] words = { "собака", "як", "кит", "слон", "кот", "белка" };

            foreach (string word in words)
            {
                tree.Insert(word);
            }

            Console.WriteLine("Прямой порядок обхода:");
            tree.TraverseInOrder(tree.root);
        }
    }
}