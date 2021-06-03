using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Allocation
{
    class Memory
    {
        public static bool FF;
        public List Used;
        public List UnUsed;

        public Memory()     //initialize
        {
            Piece p0 = new Piece(0, 640);    //640k
            UnUsed.Append(p0);
        }

    }
    class Piece
    {
        public string User { set; get; }
        public int Begin { set; get; }
        public int Size { set; get; }

        public Piece(int b, int s)
        {
            this.Begin = b;
            this.Size = s;
        }

        public static bool operator <(Piece a, Piece b)
        {
            if (Memory.FF)      //首次适应
                return a.Begin < b.Begin;
            else    //最佳适应
                return a.Size < b.Size;
        }

        public static bool operator >(Piece a, Piece b)
        {
            if (Memory.FF)      //首次适应
                return a.Begin > b.Begin;
            else    //最佳适应
                return a.Size > b.Size;
        }
    }
    class Node
    {
        public Piece Data { set; get; }          //数据
        public Node Next { set; get; }    //下一个结点地址

        public void DelNext()       //删除下一个 
        {
            if (this.Next != null)
                this.Next = this.Next.Next;
        }

        public void InsNext(Node node)   //插入下一个
        {
            node.Next = this.Next;
            this.Next = node;
        }

        public Node(Piece item)
        {
            this.Data = item;
            this.Next = null;
        }

        public Node()
        {
            this.Data = default(Piece);
            this.Next = null;
        }
    }
    class List
    {
        public Node Head { set; get; } //单链表头

        //构造
        public List()
        {
            Head = null;
        }

        /// 增加新元素到合适位置
        public void Append(Piece item)
        {
            Node foot = new Node(item);
            Node A = new Node();
            if (Head == null)
            {
                Head = foot;
                return;
            }
            A = Head;
            while (A.Next != null && A.Next.Data < foot.Data)
            {
                A = A.Next;
            }
            A.InsNext(foot);
        }

    }
}
