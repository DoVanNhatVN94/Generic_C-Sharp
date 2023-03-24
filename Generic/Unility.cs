using System;
namespace Generic
{
    public class Unility<T>
    {
        // với List<T> được sử dụng để lưu trữ một tập hợp các phần tử có cùng kiểu dữ liệu.
        private List<T> myGenericList = new List<T>();

        //Gọi phuong thuc them item
        public void AddItem(T item)
        {
            myGenericList.Add(item);
        }
        //Gọi phuong thuc lay item
        public T GetItem(int index)
        {
            return myGenericList[index];
        }

        public void GetAllItem() {
            foreach (var item in myGenericList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

//Tương tự, chúng ta có thể sử dụng các Generic utility khác như List<T>, Dictionary<TKey, TValue>, Queue<T>, Stack<T>, Nullable<T>, v.v... để giải quyết các vấn đề khác nhau trong lập trình.