using Generic;

MyGenericClass<string> myStringObject = new MyGenericClass<string>();
myStringObject.SetGenericValue("Hello, World!");
string myString = myStringObject.GetGenericValue();

Console.WriteLine($"Với type truyền vào class MyGenericClass là string, ta có đoạn text sau : {myString} ");

MyGenericClass<int> myIntObject = new MyGenericClass<int>();
myIntObject.SetGenericValue(123);
int myInt = myIntObject.GetGenericValue();
Console.WriteLine("Tương tự với kiểu int");
Console.WriteLine(myInt);

var listInt = new Unility<int>();

//listInt.AddItem("a"); báo lỗi ngay nếu chúng ta truyền string vào
listInt.AddItem(1);
listInt.AddItem(12);
listInt.AddItem(13);
listInt.AddItem(14);
listInt.GetAllItem();

// Generic trong C# là một tính năng cho phép định nghĩa và sử dụng các lớp, cấu trúc và phương thức đa năng, có thể áp dụng cho nhiều kiểu dữ liệu khác nhau.

//Việc sử dụng Generic giúp cho mã nguồn trở nên tái sử dụng được hơn, giảm thiểu số lượng mã lặp lại và cung cấp sự linh hoạt cho các ứng dụng.

