using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{ 
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Right { get; set; }
        public  Node<T> Left { get; set; }
       
    }

    public  class BinarayTree
    {
        public Node<int> root;
        public BinarayTree()
        {
            root = null;
        }
        public  void Binary(int num)
        {
            var queu = new Queue<int>();
            Node<int> node = new Node<int>();
            node.Data = num;
            if (root==null)
            {
               root = node;
            }
            else
            {
                Node<int> cirrent = root;
                Node<int> parent;
                while(true)
                {
                    parent = cirrent;
                    if(num<cirrent.Data)
                    {
                        cirrent = cirrent.Left;
                        if(cirrent==null)
                        {
                            cirrent.Left = node;
                            break;
                        }
                        else
                        {
                            cirrent = cirrent.Right;
                            if (cirrent == null)
                            {
                                parent.Right = node;
                                break;
                            }
                        }
                    }
                }

            }

            
        }
        public  void pring()
        {
            PrintTree123(root);
        }
        public  void PrintTree123(Node<int> node, string p = " ")
        {
            if (node != null)
            {
                Console.WriteLine($"{p} {node.Data}");
                PrintTree123(node.Left, p + "  ");
                PrintTree123(node.Right, p + "  ");
            }
        }



    }
    class Program
    {
       

       
        
        
        static int[] val = new int[] {1,2,333,444,11,12,33,22 };
        static int i;

        public static Node<int> metod (int n)
        {
           
            Node<int> newNode = null;
            if(n==0)
            {
                return null;
            }
            else
            {
                var nl = n / 2;
                var nr = n - nl - 1;
                newNode = new Node<int>();
                newNode.Data = val[i++];
                 newNode.Left = metod(nl);
                newNode.Right = metod(nr);
            }
            return newNode;
        }



      
        public static void PrintTree(Node<int> node,string p=" ")
        {
            if(node!=null)
            {
                Console.WriteLine($"{p} {node.Data}");
                PrintTree(node.Left,p+"  ");
                PrintTree(node.Right,p+"  ");
            }
        }
       
        static void Main(string[] args)
        {
            Random random = new Random();

            var queu = new Queue<int>();
            var stack = new Stack<int>();
            Node<int> node = metod(val.Length);
           
            
       
            for (int i = 0; i < val.Length; i++)
            {
                int conut = val[i];

                queu.Enqueue(conut);
                var deq = queu.Dequeue();
                Console.WriteLine($"@ {deq}");

            }
            Console.WriteLine("сбалансированое дерево");
            for(int i=0; i<val.Length;i++)
            {
                int count = val[i];
                 stack.Push(count);
                var steckinfo = stack.Pop();
                Console.WriteLine(steckinfo);
            }        
        }
    }
}
