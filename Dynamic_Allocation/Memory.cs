using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Allocation
{
    public class Order
    {
        public int Type;    //0需求1释放
        public int User;
        public int Size;    //需求大小

        public Order(int u, int t, int s)
        {
            this.User = u;
            this.Type = t;
            this.Size = s;
        }

        public Order()
        {

        }
    }

    public class Memory
    {
        public int Index;
        public Order[] Ord;
        public static bool FF;
        public List Used;
        public List UnUsed;

        public Memory()     //initialize
        {
            Index = 0;
            Ord = new Order[11] {
               new Order(1,0,130) ,
               new Order(2,0,60) ,
               new Order(3,0,100) ,
               new Order(2,1,60) ,
               new Order(4,0,200) ,
               new Order(3,1,100) ,
               new Order(1,1,130) ,
               new Order(5,0,140) ,
               new Order(6,0,60) ,
               new Order(7,0,50) ,
               new Order(6,1,60) ,
            };      //指令队列
            this.Used = new List();
            this.UnUsed = new List();
            Piece p0 = new Piece(0, 640);
            UnUsed.Append(p0);   //初始内存
        }

        public void RunSetp()
        {
            if (Index < Ord.Length)
                this.RunOrder(Ord[Index++]);
        }


        public void RunOrder(Order od)
        {
            if (od.Type == 0)  //申请
            {
                this.Ask(od.User, od.Size);
            }
            else    //释放
            {
                this.Release(od.User, od.Size);
            }
        }

        public void Ask(int user, int size)
        {
            Node A = UnUsed.Head;
            Node N = A.Next;
            while (N != null && N.Data.Size < size)
            {
                A = A.Next;
                N = A.Next;
            }
            Piece P = new Piece(user, N.Data.Begin, size);
            this.Used.Append(P);
            N.Data.Begin += size;
            N.Data.Size -= size;
            if (N.Data.Size == 0)  //删除
            {
                A.Next = N.Next;
            }
        }

        public void Release(int user, int size)
        {
            Node A = Used.Head;
            Node N = A.Next;
            while (N != null && N.Data.User != user)
            {
                A = A.Next;
                N = A.Next;
            }
            Piece P = new Piece(N.Data.Begin, size);
            this.UnUsed.Append(P, true);
            N.Data.Begin += size;
            N.Data.Size -= size;
            if (N.Data.Size == 0)  //删除
            {
                A.Next = N.Next;
            }
        }

        public void Log()
        {
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("LOG Order:");
            if (this.Index < this.Ord.Length)
            {
                Order ord = this.Ord[this.Index];  //上一条指令
                System.Diagnostics.Debug.WriteLine("U:" + ord.User + " T:" + ord.Type + " S:" + ord.Size);
            }
            System.Diagnostics.Debug.WriteLine("LOG Memory Unused:");
            Node A = UnUsed.Head.Next;
            while (A != null)
            {
                System.Diagnostics.Debug.WriteLine("B:" + A.Data.Begin + " S:" + A.Data.Size);
                A = A.Next;
            }
            System.Diagnostics.Debug.WriteLine("LOG Memory Used:");
            A = Used.Head.Next;
            while (A != null)
            {
                System.Diagnostics.Debug.WriteLine("U:" + A.Data.User + " B:" + A.Data.Begin + " S:" + A.Data.Size);
                A = A.Next;
            }
            System.Diagnostics.Debug.WriteLine("");
        }

    }
    public class Piece
    {
        public int User { set; get; }
        public int Begin { set; get; }
        public int Size { set; get; }

        public Piece(int b, int s)
        {
            this.Begin = b;
            this.Size = s;
        }

        public Piece(int u, int b, int s)
        {
            this.User = u;
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
    public class Node
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
    public class List
    {
        public Node Head { set; get; } //单链表头

        //构造
        public List()
        {
            Head = new Node();  //表头结点
        }

        /// 增加新元素到合适位置
        public void Append(Piece item, bool merge = false)
        {
            Node foot = new Node(item);
            Node A = Head;
            if (merge)
            {
                this.merge(foot);
            }
            while (A.Next != null && A.Next.Data < foot.Data)
            {
                A = A.Next;
            }
            A.InsNext(foot);
        }

        public void merge(Node node)
        {
            Node A = Head;
            Node N = A.Next;
            while (N != null)
            {
                if (node.Data.Begin + node.Data.Size == N.Data.Begin)  //碎片向后合并
                {
                    node.Data.Size += N.Data.Size;
                    A.Next = N.Next;
                    N = A.Next;
                }
                else if (N.Data.Begin + N.Data.Size == node.Data.Begin)   //碎片向前合并
                {
                    node.Data.Begin = N.Data.Begin;
                    node.Data.Size += N.Next.Data.Size;
                    A.Next = N.Next;
                    N = A.Next;
                }
                else
                {
                    A = A.Next;
                    N = A.Next;
                }
            }
        }

    }
}
