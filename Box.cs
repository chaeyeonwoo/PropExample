using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Box
    {
        public int Width { get; set; }
        private int Width;
         
        public int width
        {
            get { return width; }
            set {
                if(value < 0)
                width = value; }
        }

        
        private int height;

        public int Height
        {
            get { return height; }
            set {
                if (height > 0) { this.height = height; }
                else { Console.WriteLine("높이는 자연수로 입력해주세요."); }
        }


        public Box(int width, int height)
        {
            if(width>0 && height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                Console.WriteLine("너비와 놓ㅍ이는 자연수로 초기화 해 주세요.");
                // throw new Exception("너비와 높이는 자연수로 초기화 해주세요.");
            }
        }

        public int getWidth() { return this.width; }
        public int getHeight() { return this.height; }

        public void setWidth(int width)
        {
            if (width > 0) { this.width = width; }
            else { Console.WriteLine("너비는 자연수로 입력해주세요."); }

        }

        public void setHeight(int height)
        {
             }
        }

        // commit 메시지 : 속성(Property)를 활용하여 게터세터 처리하기

        public int Area
        {
            get { return Width * Height; }
          
        }
        
       
    }
}
