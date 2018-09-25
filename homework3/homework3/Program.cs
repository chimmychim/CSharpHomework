using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
         {
            new Square(5, "Square #1"),
            new Circle(3, "Circle #1"),
            new Rectangle( 4, 5, "Rectangle #1"),
            new Triangle( 3, 4, 45,"Triangle #1")
         };

            System.Console.WriteLine("Shapes Collection");
            foreach (Shape s in shapes)
            {
                System.Console.WriteLine(s);
            }
        }
    }
}
public abstract class Shape
{
    private string myId;

    public Shape(string s)
    {
        Id = s;
    }

    public string Id //类型
    {
        get
        {
            return myId;
        }

        set
        {
            myId = value;
        }
    }


    public abstract double Area //面积,抽象属性
    {
        get;
    }

    public virtual void Draw() //绘制,虚方法
    {
        Console.WriteLine("Draw Shape Icon");
    }

    public override string ToString() // 覆盖object的虚方法
    {
        return Id + " Area = " + string.Format("{0:F2}", Area);
    }
}

//正方形类
public class Square : Shape
{
    private int mySide; //边长

    public Square(int side, string id)
        : base(id)
    {
        mySide = side;
    }

    public override double Area	//实现面积
    {
        get
        {
            return mySide * mySide;
        }
    }

    public override void Draw() //覆盖绘制方法
    {
        Console.WriteLine("Draw 4 Side:" + mySide);
    }
}

// 圆类
public class Circle : Shape
{
    private int myRadius; //半径

    public Circle(int radius, string id)
        : base(id)
    {
        myRadius = radius;
    }

    public override double Area  //实现面积
    {
        get
        {
            return myRadius * myRadius * System.Math.PI;
        }
    }

    public override void Draw() //覆盖绘制方法
    {
        Console.WriteLine("Draw Circle:" + myRadius);
    }

}

//矩形类
public class Rectangle : Shape
{
    private int myWidth;
    private int myHeight;

    public Rectangle(int width, int height, string id)
        : base(id)
    {
        myWidth = width;
        myHeight = height;
    }

    public override double Area
    {
        get
        {
            return myWidth * myHeight;
        }
    }

    public override void Draw() //覆盖绘制方法
    {
        Console.WriteLine("Draw Rectangle");
    }

}
//三角形类
public class Triangle : Shape
{
    private int myBase;
    private int myHeight;
    private int myAngle;

    public Triangle(int tribase, int height, int angle, string id)
        : base(id)
    {
        myBase = tribase;
        myHeight = height;
        myAngle = angle;
    }

    public override double Area
    {
        get
        {
            return myBase * myHeight * 0.5;
        }
    }

    public override void Draw() //覆盖绘制方法
    {
        Console.WriteLine("Draw Triangle");
    }

}


