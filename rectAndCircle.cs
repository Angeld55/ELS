using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace num2string_100_SC_SoftUni_home
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int countTimes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < countTimes; i++)
            {
                Circle circle = null;
                Rectangle rect = null;
                
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                //Console.WriteLine(first+" "+second);
                for (int q = 0; q < 2; q++)
                {
                    if (q == 1)
                    {
                        first = second;
                    }

                    if (first[0] == 'c')
                    {
                        first = first.Substring(7, first.Length - 8);

                        string[] elements = first.Split(',');
                        double[] cirlcePoints = new double[elements.Length];
                        for (int h = 0; h < elements.Length; h++)
                        {

                            cirlcePoints[h] = Convert.ToDouble(elements[h].Substring(0).Replace('.', ','));

                            Point center = new Point(cirlcePoints[0], cirlcePoints[1]);
                            circle = new Circle(center, cirlcePoints[2]);
                        }
                    }
                    else
                    {
                        first = first.Substring(10, first.Length - 11);

                        string[] elements = first.Split(',');
                        double[] rectPoints = new double[elements.Length];
                        for (int h = 0; h < elements.Length; h++)
                        {
                            rectPoints[h] = Convert.ToDouble(elements[h].Substring(0).Replace('.', ','));
                        }
                        Point one = new Point(rectPoints[0], rectPoints[1]);

                        Point two = new Point(rectPoints[2], rectPoints[3]);

                        rect = new Rectangle(one, two);
                    }

                    
                }
                //Point test = new Point(-6, 3);
                //Console.WriteLine("test" + circle.checkIfPointInsideCircle(test));
                
                
                //check tri in Circle
                Console.WriteLine(rect);
                Console.WriteLine(circle);
                bool inside = true;
                bool presichatSe = false;
                for (int t = 0; t < rect.allpoints.Length; t++)
                {
                    if (circle.checkIfPointInsideCircle(rect.allpoints[t]))
                    {
                        presichatSe = true;
                    }
                    else
                    {
                        inside = false;
                    }
                }
                if (inside)
                {
                    Console.WriteLine("Rectangle inside circle");
                }
                else
                {
                    //check cirle in trie
                    inside = true;
                    for (int y = 0; y < circle.allpoints.Length; y++)
                    {
                        if (rect.checkIfPointInsideRect(circle.allpoints[y]))
                        {
                            presichatSe = true;
                        }
                        else
                        {
                            inside = false;
                        }
                      
                    }
                    if (inside)
                    {
                        Console.WriteLine("Circle inside rectangle");
                    }
                    else if(presichatSe)
                    {
                        Console.WriteLine("Rectangle and circle cross");
                    }
                    else
                    {
                        Console.WriteLine("Rectangle and circle do not cross");
                    }
                }
             
            }

        }
        class Rectangle
        {
            public Point firstPoint;
            public Point secondPoint;
            public Point thirdPoint;
            public Point forthPoint;
            public Point[] allpoints;
            public Rectangle(Point a, Point b)
            {
                this.firstPoint = a;
                this.thirdPoint = b;

                this.secondPoint = new Point(firstPoint.X, thirdPoint.Y);
                this.forthPoint = new Point(thirdPoint.X, firstPoint.Y);
                this.allpoints = new Point[4];
                this.allpoints[0] =this.firstPoint;
                this.allpoints[1] = this.secondPoint;
                this.allpoints[2] = this.thirdPoint;
                this.allpoints[3] = this.forthPoint;
            }
            public bool checkIfPointInsideRect(Point p)
            {
                double upY;
                double downY;
                if (this.firstPoint.Y > this.thirdPoint.Y)
                {
                    upY = this.firstPoint.Y;
                    downY = this.thirdPoint.Y;
                }
                else
                {
                    downY = this.firstPoint.Y;
                    upY = this.thirdPoint.Y;
                }
                if ((p.Y - 0.01 > upY) || (p.Y + 0.01 < downY))
                {
                    return false;
                }
                double leftX;
                double rightX;

                if (this.thirdPoint.X > this.firstPoint.X)
                {
                    rightX = this.thirdPoint.X;
                    leftX = this.firstPoint.X;
                }
                else
                {
                    leftX = this.thirdPoint.X;
                    rightX = this.firstPoint.X;
                }
                if ((p.X - 0.01 > rightX) || (p.X + 0.01 < leftX))
                {
                    return false;
                }
                return true;

            }
            public override string ToString()
            {
                return this.secondPoint.X + " " + secondPoint.Y;
            }

        }
        class Circle
        {
            public Point Center;
            public Point UpPoint;
            public Point DownPoint;
            public Point LeftPoint;
            public Point RightPoint;
            public double radius;
            public Point[] allpoints;


            public Circle(Point center, double R)
            {
                this.Center = center;
                this.radius = R;


                double newY = center.Y + radius;
                this.UpPoint = new Point(center.X, newY);

                newY = center.Y - radius;
                this.DownPoint = new Point(center.X, newY);

                double newX = center.X - radius;
                this.LeftPoint = new Point(newX, center.Y);
                newX = center.X + radius;
                this.RightPoint = new Point(newX, center.Y);

                this.allpoints = new Point[5];
                this.allpoints[0] = this.Center;
                this.allpoints[1] = this.UpPoint;
                this.allpoints[2] = this.DownPoint;
                this.allpoints[3] = this.LeftPoint;
                this.allpoints[4] = this.RightPoint;
            }
            public bool checkIfPointInsideCircle(Point p)
            {
                //Console.WriteLine("Px"+p.X);
                //Console.WriteLine("Centerx"+Center.X);
                //Console.WriteLine("Py"+p.Y);
                //Console.WriteLine("center y"+Center.Y);
                double distance = ((p.X - Center.X) * (p.X - Center.X)) + ((p.Y - Center.Y) * (p.Y - Center.Y));
                
                distance = Math.Sqrt(distance);
               
                if ((distance>radius)&&(distance>radius+0.01))
                {
                    return false;
                }

                return true;

            }
            public override string ToString()
            {
                return  this.Center.X+" "+this.Center.Y+" ";
            }

        }
        class Point
        {
            public double X;
            public double Y;
            public Point(double x, double y)
            {
                this.X = x;
                this.Y = y;

            }
        }
    }
}
