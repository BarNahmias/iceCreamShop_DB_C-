
using System;

using System.Collections;
using System;

namespace BusinessEntities
{

    public class Costumer
    {

        public int id;
        public string name;
        public int order_id;

        public Costumer(int id, string name, int order_id)
        {
            this.id = id;
            this.name = name;
            this.order_id = order_id;
        }

        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public int getOrder_id()
        {
            return order_id;
        }

        public override string ToString()
        {
            return $"(id: {id}, name: {name}, order id: {order_id})";
        }
    }
   public class Invoice
    {
        string price;
        string name;
        string date;
        string flavor;
        string toping;
        string cone;

        public Invoice(string p, string n , string d, string f , string t, string c){
            this.price=p;
            this.name=n;
            this.date=d;
            this.flavor=f;
            this.toping=t;
            this.cone=c;
        }

         public Invoice(string p, string d, string f , string t, string c){
            this.price=p;
            this.name="";
            this.date=d;
            this.flavor=f;
            this.toping=t;
            this.cone=c;
        }

        public override string ToString()
        {
            return "{price: " + price + " , name: " + name + " order date: " + date + " , cone type: " + cone + ", flavors: " + flavor + " , topings: " + toping +"}";
        }
    }
    public class Order
    {
        public string cone;
        public string[] flavor;
        public string[] toping;
        public int toping_amount;
        public string order_time;
        public int price;
        public int order_id;

        public int status;


        public Order(int order_id, string con_type, string[] flavor, string[] toping,int status)
        {
            this.order_id = order_id;
            this.cone = con_type;
            this.status=status;
            this.order_time = DateTime.Now.ToString("MM/dd/yyyy");
            this.flavor = flavor;
            this.toping = toping;
            this.toping_amount = flavor.Length;
            if (("Regular".Equals(con_type) || "Special".Equals(con_type)) && flavor.Length <= 3 && flavor.Length >= 1)
            {
                //* One ice cream ball*//
                if (flavor.Length == 1)
                {
                    if ("Regular".Equals(con_type))
                    {
                        price = 7;
                    }
                    else if ("Special".Equals(con_type))
                    {
                        price = 9 + (toping.Length) * 2;
                    }
                }

                else if (flavor.Length == 2)
                {
                    // if (!badMatch(con_type, flavor, toping))
                    // {
                    //     throw new InvalidOperationException("Bad match- Choose better !");

                    // }
                    // else
                    // {
                        if ("Regular".Equals(con_type) && toping.Length == 1)
                        {
                            price = 12 + 2;
                        }
                        else if ("Special".Equals(con_type))
                        {
                            price = 14 + 2 * (toping.Length);
                        }
                        else if ("Regular".Equals(con_type))
                        {
                            price = 12;
                        }
                    // }
                }

                else if (flavor.Length == 3)
                {
                    // if (!badMatch(con_type, flavor, toping))
                    // {
                    //     throw new InvalidOperationException("Bad match- Choose better !");
                    // }

                    
                        if ("Regular".Equals(con_type) && toping.Length == 1)
                        {
                            price = 18 + 2;
                        }
                        else if ("Special".Equals(con_type))
                        {
                            price = 20 + 2 * (toping.Length);
                        }
                        else if ("Regular".Equals(con_type))
                        {
                            price = 18;
                        }
                    
                }
            }
            else if ("Box".Equals(con_type))
            {
                if (flavor.Length == 1)
                {
                    price = 5 + 7 + 2 * (toping.Length);
                }
                else
                {
                    price = 5 + (flavor.Length * 6) + (toping.Length * 2);
                }
            }
        }
public Order(int order_id, string con_type, string fla, string top ,int status)
        {
        
            string [] fl= fla.Split(","); 
            string [] tp= top.Split(",");
            this.status=status;
            this.order_id = order_id;
            this.cone = con_type;
            this.order_time = DateTime.Now.ToString("MM/dd/yyyy");
            this.flavor = fl;
            this.toping = tp;
            this.toping_amount = flavor.Length;
            if (("Regular".Equals(con_type) || "Special".Equals(con_type)) && flavor.Length <= 3 && flavor.Length >= 1)
            {
                //* One ice cream ball*//
                if (flavor.Length == 1)
                {
                    if ("Regular".Equals(con_type))
                    {
                        price = 7;
                    }
                    else if ("Special".Equals(con_type))
                    {
                        price = 9 + (toping.Length) * 2;
                    }
                }

                else if (flavor.Length == 2)
                {
                    // if (!badMatch(con_type, flavor, toping))
                    // {
                    //     throw new InvalidOperationException("Bad match- Choose better !");

                    // }
                    // else
                    // {
                        if ("Regular".Equals(con_type) && toping.Length == 1)
                        {
                            price = 12 + 2;
                        }
                        else if ("Special".Equals(con_type))
                        {
                            price = 14 + 2 * (toping.Length);
                        }
                        else if ("Regular".Equals(con_type))
                        {
                            price = 12;
                        }
                    // }
                }

                else if (flavor.Length == 3)
                {
                    // if (!badMatch(con_type, flavor, toping))
                    // {
                    //     throw new InvalidOperationException("Bad match- Choose better !");
                    // }

                    
                        if ("Regular".Equals(con_type) && toping.Length == 1)
                        {
                            price = 18 + 2;
                        }
                        else if ("Special".Equals(con_type))
                        {
                            price = 20 + 2 * (toping.Length);
                        }
                        else if ("Regular".Equals(con_type))
                        {
                            price = 18;
                        }
                    
                }
            }
            else if ("Box".Equals(con_type))
            {
                if (flavor.Length == 1)
                {
                    price = 5 + 7 + 2 * (toping.Length);
                }
                else
                {
                    price = 5 + (flavor.Length * 6) + (toping.Length * 2);
                }
            }
        }
        public bool badMatch(string con_type, string[] flavor, string[] toppings)
        {
            if ("Regular".Equals(con_type) && toppings.Length >= 1)
            {
                string find_chocolate = Array.Find(flavor,
                    ele => ele.StartsWith("Chocolate", StringComparison.Ordinal));
                string find_vanilla =
                    Array.Find(flavor, ele => ele.StartsWith("Vanilla", StringComparison.Ordinal));
                string find_maple = Array.Find(toppings, ele => ele.StartsWith("Maple", StringComparison.Ordinal));
                string find_hot = Array.Find(toppings,
                    ele => ele.StartsWith("Hot Chocolate", StringComparison.Ordinal));

                if ("Hot Chocolate".Equals(find_hot) && "Chocolate".Equals(find_chocolate))
                {
                    return false;
                }

                if ("Maple".Equals(find_maple) && "Vanilla".Equals(find_vanilla))
                {
                    return false;
                }
            }

            return true;
        }

        public string flavor_toString()
        {
            string str = string.Join(",", this.flavor);

            return "{" + str + "}";
        }

       public int get_status()
        {

            return status;
        }

        public string toping_toString()
        {
            string str;
            if(this.toping == null){
                str = string.Join(",", "null");
            }
            else{
                str = string.Join(",", this.toping);
                return "{" + str + "}";
            }
            return "{"+ str + "}";
        }



        public int getOrder_id()
        {
            return this.order_id;
        }

        public string getCon_type()
        {
            return cone;
        }

        public string[] getFlavor()
        {
            return flavor;
        }

        public string[] getToping()
        {
            return toping;
        }

        public int getBall_amount()
        {
            return flavor.Length;
        }

        public string getTime()
        {
            return order_time;
        }

        public int getPrice()
        {
            return price;
        }

        public override string ToString()
        {
            return "{order id: " + order_id + " , order time: " + order_time + " , cone type: " + cone + ", ball amount: " + flavor.Length + " , flavors: " + flavor_toString() + " , topings: " + toping_toString() + " , price: " + price +",status:" +status +"}";
        }
    }




    // public sealed class App
    // {
    //     static void Main()
    //     {


    //         bool num = true;
    //         while (num)
    //         {

    //             Console.WriteLine("********************************************************* ");
    //             Console.WriteLine(" Welcome to the ice cream shop! - love in every scoop  ");
    //             Console.WriteLine(" For daily report enter   1  ");
    //             Console.WriteLine(" For favorite  flavor  enter   2  ");
    //             Console.WriteLine(" For favorite  product  enter  3  ");
    //             Console.WriteLine(" To receive an invoice  enter  4  ");
    //             Console.WriteLine(" To Exit incest 0 ");
    //             Console.WriteLine("********************************************************* ");

    //             int input = int.Parse(Console.ReadLine());

    //             switch (input)
    //             {
    //                 case 1:
    //                     Console.WriteLine("********************************************************* ");
    //                     Console.WriteLine("insert date example (dd/mm/yy) - from - 01/08/22 - to 01/09/22");
    //                     string date1 = Console.ReadLine();

    //                     Console.WriteLine("********************************************************* ");

    //                     string input1 = "";
    //                     while (input1 != "back")
    //                     {

    //                         Console.WriteLine("********************************************************* ");
    //                         Console.WriteLine(" For sum off Sales from - " + date1 + " insert a");
    //                         Console.WriteLine(" For average off Sales from - " + date1 + " insert b");
    //                         Console.WriteLine(" Uncompleted sales - " + date1 + " insert c");
    //                         Console.WriteLine(" Back to the previous menu incest - back");
    //                         Console.WriteLine("********************************************************* ");

    //                         input1 = Console.ReadLine();
    //                         if (input1 == "a")
    //                         {

    //                             Console.WriteLine(" sum off Sales from :" + date1 + ": ");
    //                         }

    //                         else if (input1 == "b")
    //                         {
    //                             Console.WriteLine(" average from :" + date1 + ": ");
    //                         }

    //                         else if (input1 == "c")
    //                         {
    //                             Console.WriteLine(" Uncompleted sales -" + date1 + "insert c");
    //                         }
    //                         else if (input1 == "back")
    //                         {

    //                             break;
    //                         }
    //                     }



    //                     break;

    //                 case 2:
    //                     Console.WriteLine("  favorite  flavor  :  ");
    //                     break;

    //                 case 3:
    //                     Console.WriteLine("  favorite  product  :  ");
    //                     break;

    //                 case 4:
    //                     string id1 = Console.ReadLine();
    //                     Console.WriteLine("  insert order id  ");
    //                     Console.WriteLine("  Detail of invoice  id number " + id1);
    //                     break;

    //                 case 0:
    //                     Console.WriteLine(" bay bay  - ice cream shop! - love in every scoop");
    //                     num = false;
    //                     break;

    //             }
    //         }


    //         string[] toppings = { "Hot Chocolate" };
    //         string[] flavors = { "Vanilla" };

    //         Order o = new Order(4, "Regular", flavors, toppings);
    //         Console.WriteLine(o.ToString());



    //     }


    // }


}
