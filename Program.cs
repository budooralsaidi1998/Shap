namespace Shap
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }


    public class shape
    {
        protected double lengh;
        protected double width;
        public virtual double area(double x, double y)

        {
            return 0;
        }
    }

    public class  square : shape 
    {
    
    }
    public class circle : shape { }

    public class triangle  : shape { }
    public class rectangle : shape { }
}
}
