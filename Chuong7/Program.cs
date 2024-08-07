namespace Chuong7
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DerivedClass o = new DerivedClass();
            o.Abstractmethod();
            Console.WriteLine("x = {0}, y={1}", o.x, o.y);

            //demo interface
            ISampleInterface obj = new ImplementInterface();
            obj.SampleMethod();

            // 
            IEnglishDemensions englishDemensions = new Box(30.0f, 20.0f);
            IMetricDimensions metricDimensions = new Box(30.0f, 20.0f);

            Console.WriteLine($"length:{englishDemensions.Length()} , width: {englishDemensions.Length()}");
            Console.WriteLine($"length:{metricDimensions.Length()} , width: {metricDimensions.Length()}");



            /*
             1. So sánh giữa lớp và giao diện

             Lớp (Class):

             Là một bản thiết kế để tạo ra các đối tượng (instance).
             Có thể chứa các thuộc tính (fields), phương thức (methods), và constructor.
             Hỗ trợ kế thừa đơn (single inheritance); một lớp chỉ có thể kế thừa từ một lớp cha.
             Có thể chứa các phương thức có triển khai (implemented methods).

             Giao diện (Interface):

             Là một tập hợp các khai báo phương thức mà một lớp phải triển khai.
             Chỉ chứa các khai báo phương thức (abstract methods) và không có phần triển khai. 
             Tuy nhiên, từ C# 8.0, giao diện có thể chứa các phương thức mặc định (default methods)
             và các phương thức tĩnh (static methods).
             Hỗ trợ kế thừa đa giao diện (multiple inheritance); một lớp có thể thực thi nhiều giao diện.
             Không thể chứa các thuộc tính instance hoặc constructor.


             2. Sự khác nhau giữa giao diện và lớp trừu tượng

             Lớp trừu tượng (Abstract Class):

             Có thể chứa cả phương thức triển khai và phương thức trừu tượng.
             Có thể có các thuộc tính instance và constructor.
             Có thể cung cấp một phần triển khai và bắt buộc lớp con phải cung cấp phần triển khai còn lại.
             Không thể được tạo instance trực tiếp.

             Giao diện (Interface):

             Chỉ chứa các khai báo phương thức và không có phần triển khai (cho đến C# 8.0).
             Không thể có các thuộc tính instance và constructor.
             Chỉ có các phương thức public và abstract; từ C# 8.0 trở đi có thể có default methods và static methods.
             Một lớp có thể thực thi nhiều giao diện nhưng chỉ có thể kế thừa từ một lớp trừu tượng.


             3. Các lớp thực thi giao diện sẽ phải làm gì?
             Các lớp thực thi giao diện phải cung cấp triển khai cho tất cả các phương thức trừu tượng được khai báo trong giao diện. Nếu không, lớp đó phải được khai báo là trừu tượng.

             4. Có bao nhiêu cách gọi một phương thức được khai báo trong giao diện?
             Có hai cách chính để gọi một phương thức trong giao diện:

             Qua đối tượng của lớp thực thi: Tạo một instance của lớp thực thi giao diện và gọi phương thức thông qua instance đó.
             Qua tham chiếu giao diện: Sử dụng một tham chiếu kiểu giao diện để tham chiếu đến một đối tượng của lớp thực thi và gọi phương thức thông qua tham chiếu đó.


             5. Các thành viên của giao diện có thể có những thuộc tính truy cập nào?
             Trong C#, các phương thức trong giao diện mặc định là public và abstract. 
             Từ C# 8.0, giao diện có thể có các phương thức với các thuộc tính truy cập như public, private, protected, internal, default (cho default methods), và static.

             6. Chúng ta có thể tạo thể hiện của giao diện một cách trực tiếp được không?
             Không, chúng ta không thể tạo thể hiện của giao diện một cách trực tiếp vì giao diện chỉ chứa các phương thức trừu tượng hoặc không có triển khai đầy đủ.

             7. Giao diện là kiểu dữ liệu tham chiếu hay kiểu giá trị?
             Giao diện là kiểu dữ liệu tham chiếu.

             8. Khi thực thi giao diện với cấu trúc thì truy cập các thành viên của giao diện thông qua đối tượng hay thông qua tham chiếu giao diện là tốt nhất?
             Việc truy cập thông qua tham chiếu giao diện là tốt nhất khi muốn sử dụng tính đa hình,
             giúp mã linh hoạt hơn và dễ dàng thay thế đối tượng thực thi khác mà không cần thay đổi mã gọi phương thức.

             9. Số giao diện có thể được kế thừa cho một lớp?
             Một lớp có thể thực thi nhiều giao diện mà không có giới hạn nào về số lượng giao diện mà nó có thể thực thi.

             10. Việc thực thi giao diện tường minh là thực thi như thế nào? Trong trường hợp nào thì cần thực hiện tường minh?
             Việc thực thi giao diện tường minh (explicit interface implementation) là việc triển khai các phương thức của giao diện một cách tường minh
             bằng cách sử dụng tên giao diện cùng với tên phương thức trong lớp thực thi.
             Điều này thường được sử dụng khi một lớp thực thi nhiều giao diện có phương thức trùng tên và cần phải phân biệt cách gọi.


              */

            //bt11
            ISHowId showId = new Employee();
            Console.WriteLine($"Id: {showId.Id}");

            //12
            // Trong C#, các thành viên của một giao diện không thể có thân (body) và không thể chứa các trường (fields).
            // Giao diện chỉ có thể chứa các khai báo phương thức, thuộc tính, sự kiện, hoặc chỉ số (indexers).

            //13  IPoint p2 = new IPoint(); dong nay sai vi khong the khoi tao doi tuong cua interface

            MyPoint p = new MyPoint(2, 3);
            Console.Write("My Point: ");
            PrintPoint(p);
            IPoint p2 = new MyPoint(2, 3);
            PrintPoint(p2);

            // bt14

            IDisplay dog = new Dog("corgi");
            IDisplay cat = new Cat("tam the");

            Console.WriteLine($"Dog name: {dog.Getname()}");
            Console.WriteLine($"Cat name: {cat.Getname()}");


        }

        private static void PrintPoint(IPoint p)
        {
            Console.WriteLine("x={0}, y={1}", p.x, p.y);
        }

  
    }
}

