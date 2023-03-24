using System;
namespace Generic
{
    public class MyGenericClass<T>
    {
        private T myGenericVariable;

        public void SetGenericValue(T value)
        {
            myGenericVariable = value;
        }

        public T GetGenericValue()
        {
            return myGenericVariable;
        }
    }
}

