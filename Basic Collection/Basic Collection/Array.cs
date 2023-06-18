using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Collection
{
    public class Array
    {

    
     public static void MulArray()
        {


            //Array 3D

            string[,,] array3d = {

                {

                    { "Shojib","sunny","Anamul","Adil" },

                      { "Sunny,","Shojib","Arefin","Tisha" }
                    

                },



                {

                    { "Shojib","Emel","Joy","Adil" },
                    {"Anan,","Arab","Arefin","Tisha"}

                },







            };


            Console.WriteLine(array3d.Rank);
            Console.WriteLine(array3d.Length);
            //Console.WriteLine("The value is "+ array3d[1,2,3]);


        }



        public static void JaggedArray()
        {

            int[][] jagged = new int[4][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 },
                new int[] { 10, 11, 12 }
            };



            //Console.WriteLine("The value is {0}", jagged[3][1]);
             
            for( int i = 0; i < jagged.Length; i++)
            {
                for( int j = 0; j < jagged[i].Length; j++)
                {


                    Console.WriteLine("Element {0}",jagged[i][j]);




                }
            }




        }


        public static void parramArray(params string[] sentence)
        {
            for(int i=0;i< sentence.Length; i++)
            {
                Console.Write(sentence[i]);
            }



        }


        public static void GenericAndNongeneric()
        {

            //Non generic (ArrayList)
            

            //int a = 10;
            //string b= "a";
            //float c = 3.24f;
            //bool d= false;
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(a);
            //arrayList.Add(b);
            //arrayList.Add(c);
            //arrayList.Add(d);

            //arrayList.Remove(c);

           
            //    foreach (int i in arrayList)
            //    {
            //        Console.WriteLine("The items is {0}", i);
            //    }


            //Generic(List)

            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            
            //foreach( int item in list)
            //{
            //    Console.WriteLine(item);
            //}




        }

        public static void Hashtab()
        {
            // Non generic

            Hashtable ht = new Hashtable();

            Product product1 = new Product(0111,"A",25.05);

            Product product2 = new Product(0222, "B", 35.05);

            Product product3 = new Product(0333, "C", 45.05);



            ht.Add(product1.Id, product1);
            ht.Add(product3.Id, product3);
            ht.Add(product2.Id, product2);

            //Individual Item Store

            //Product store = (Product)ht[product1.Id];
            //Console.WriteLine($"product Id: {store.Id}, Poduct Name: {store.Name} , product price:{store.Price}");



            // All value store

            //foreach(DictionaryEntry item in ht)
            //{
            //    Product product = (Product)item.Value;
            //    Console.WriteLine("Product Id : {0}", product.Id);
            //    Console.WriteLine("Product Nmae : {0}", product.Name);
            //    Console.WriteLine("Product Price : {0}", product.Price);


            //}


            // OR


            foreach (Product item in ht.Values)
            {
                Console.WriteLine("Product Id : {0}", item.Id);
                Console.WriteLine("Product Nmae : {0}", item.Name);
                Console.WriteLine("Product Price : {0}", item.Price);


            }






        }


        public static void Dictonary() {

            //generic

            Product[] products =
            {
                new Product(0111,"A",25.05),
                new Product(0222, "B", 35.05),
                new Product(0333, "C", 45.05),


            };
        
        
           Dictionary<string,Product> dict = new Dictionary<string,Product>();
            foreach (Product item in products)
            {
                dict.Add(item.Name, item);
            }



            //filter search
            string key = "C";
            if (dict.ContainsKey(key))
            {
                Product pd= dict[key];
                Console.WriteLine($"product found {pd.Name}");

            }
        
           else {
                Console.WriteLine("Product not found with this {0}", key);
                    
                    
                    }
        
        }

        public static void stack()
        {
            //generic

            int[] num = { 1, 2, 3, 4, 5, 6, 7 };
            Stack<int> stack = new Stack<int>();

            //foreach (int i in num)
            //{

            //    stack.Push(i);

            //}

            //// reverse the number

            //while(stack.Count > 0)
            //{
            //    int res= stack.Pop();
            //    Console.Write(res+ " ");




            //}


            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(9);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(6);


            //foreach (int number in queue)
            //{
            //    Console.WriteLine(number);
            //}

            Console.WriteLine("\nDequeuing '{0}'", queue.Dequeue());
            Console.WriteLine("Peek at next item to dequeue: {0}",
               queue.Peek());
            Console.WriteLine("Dequeuing '{0}'",queue.Dequeue());









        }

    }
}
