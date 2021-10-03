using System;
namespace Iamsorry
{    
    class Program
    {     
        static void Main(string[] args)
        {
            Stack<char> st = new Stack<char>();
            string check = "{}[]()";
            string correct = 
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
