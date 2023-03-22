using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductEnumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo mảng sản phẩm
            Product[] products = new Product[]
            {
                new Product("P001", "Product 1", 100),
                new Product("P002", "Product 2", 200),
                new Product("P003", "Product 3", 300),
            };

            // Tạo đối tượng ProductEnumerable
            ProductEnumerable productEnumerable = new ProductEnumerable(products);

            // Sử dụng vòng lặp foreach để lấy dữ liệu từ mảng sản phẩm
            Console.WriteLine("Danh sách sản phẩm:");
            foreach (Product product in productEnumerable)
            {
                Console.WriteLine(product);
            }
        }
    }

    // Lớp sản phẩm
    class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2:C0}", Id, Name, Price);
        }
    }

    // Lớp ProductEnumerable
    class ProductEnumerable : IEnumerable
    {
        private Product[] products;

        public ProductEnumerable(Product[] products)
        {
            this.products = products;
        }

        // Phương thức GetEnumerator() trả về đối tượng IEnumerator
        public IEnumerator GetEnumerator()
        {
            return new ProductEnumerator(products);
        }
    }

    // Lớp ProductEnumerator
    class ProductEnumerator : IEnumerator
    {
        private Product[] products;
        private int position = -1;

        public ProductEnumerator(Product[] products)
        {
            this.products = products;
        }

        // Phương thức MoveNext() di chuyển đến phần tử tiếp theo trong mảng
        public bool MoveNext()
        {
            position++;
            return (position < products.Length);
        }

        // Phương thức Reset() đưa vị trí đến -1
        public void Reset()
        {
            position = -1;
        }

        // Phương thức Current trả về phần tử hiện tại
        public object Current
        {
            get { return products[position]; }
        }
    }
}
