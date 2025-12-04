using System.ComponentModel.DataAnnotations;

// 구조체 실습
namespace _20251204_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Point_1 p = new Point_1();

            p.x1 = int.Parse(Console.ReadLine());
            p.y1 = int.Parse(Console.ReadLine());
            p.x2 = int.Parse(Console.ReadLine());
            p.y2 = int.Parse(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(p.x2 - p.x1,2) + Math.Pow(p.y2 - p.y1,2));

            Console.WriteLine(distance);



        }

        struct Point_1
        {
            public int x1;
            public int y1;
            public int x2;
            public int y2;
        }
    }
}
