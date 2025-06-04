using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Product
    {
        public string name;
        public int price;
        static Product product;

        static Product()
        {
            product = null;
            Console.WriteLine("정적 생성자 호출");
        }

        // 소멸자 - 객체가 메모리에서 GC에 의해 소멸할 때 호출
        ~Product()
        {
            Console.WriteLine("Prodcut 객체 소멸자 생성!");
        }

        private Product(string name, int price) 
        {
            this.name = name;
            this.price = price;
        }

        public static Product Getinstance(string name, int price) {
            if (product == null)
            {
                product = new Product(name, price);
            }
            return product;
        }

        internal static Product GetInstance(string v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
