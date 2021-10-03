using System;
namespace Iamsorry
{    
    class Program
    {     
        static void Main(string[] args)
        {
            Stack<char> st = new Stack<char>();
            string check = "{}[]()";
            string correct = "(1 + 1) - 20 * {[100 - (200 / 4000)] +5}";
            string incorrect = "(1 + 1) - 20 * {100 - (200 / 4000)] +5}";
            foreach (var c in correct)
            {
                if (check.IndexOf(c) != -1)
                {
                    int a = check.IndexOf(c);
                    int index = check.IndexOf(c);
                    while (a > 1)
                    {
                        a = a - 2;
                    }
                    if (a == 1 )
                    {
                        if (st.Peek() == check[--index])
                        {
                            st.Pop();
                        }
                        else
                        {
                            st.Push(c);
                        }

                    }
                    if (a == 0)
                    {
                        st.Push(c);
                    }
                }
            }
            if(st.IsEmpty())
            {
                Console.WriteLine("pog");
            }
            else
            {
                Console.WriteLine("not pog");
            }
        }
    }
    public class Stack<T>
    {
        T[] pole;
        int posithion = -1;
        int ElementCount;
        public Stack(int maxElementCount = 100)
        {
            ElementCount = maxElementCount;
            pole = new T[maxElementCount];
        }
        public void Push(T t)
        {            
            pole[++posithion] = t;
        }
        public void Pop()
        {
            posithion--;                              
        }
        public T Peek()
        {     
            return pole[posithion];
        }
        public bool IsEmpty()
        {
            bool TrFal;            
            if (posithion == -1)
            {
                TrFal = true;
            }
            else
            {
                TrFal = false;
            }
            return TrFal;
        }
        public T[] PrintStack()
        {
            T[] save = new T[ElementCount];
            for (int i = 0; i <= posithion; i++)
            {
                save[i] = pole[i];
            }
            return save;
        }
    }
}
