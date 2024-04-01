namespace task
{
    public class calculator
    {
        public void add(int a,int b)
        {
            
            Console.WriteLine( a +b);
        }
        public void add(float a,float b, float c)
        {
            ;
            Console.WriteLine( a + b + c);
        }

        public void sub(int a,int b,float c) 
        {
            
            Console.WriteLine(a - b - c);
        }
        public void sub(float a,int b,int c)
        {
            
            Console.WriteLine(a - b - c);
        }

        public void multi(int a,int b)
        {
            Console.WriteLine(a*b);
        }
        public void multi(float a,int b ,int c)
        {
            Console.WriteLine(a*b*c);
        }

        public void divid(int a,int b)
        {
            Console.WriteLine(a/b);
        }
        public void divid(float a,float b)
        {
            Console.WriteLine(a/b);
        }
    }

    internal class Program
    {
       // static void Main(string[] args)
       //{

       //     calculator obj = new calculator();

       //     Console.Write("addition:");
       //     obj.add(12, 50);
       //     obj.add(10.5f, 15.5f, 20.5f);

       //     Console.Write("Subration:");
       //     obj.sub(20, 10, 5.5f);
       //     obj.sub(10, 5, 2.4f);

       //     Console.Write("multiplication:");
       //     obj.multi(5, 5);
       //     obj.multi(6, 6);

       //     Console.Write("division:");
       //     obj.divid(20, 10);
       //     obj.divid(10.5f, 2.2f);


       // }
    }
}
