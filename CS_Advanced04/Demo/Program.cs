using Demo.Fifa;
using Demo.YouTube;
using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region What is Collections
            // Collection in C#
            //  Lists
            //  HashTables

            // Generic - Non-Generic
            // Lists
            //  Non-Generic : ArrayList - Stack - Queue
            //  Generic     : List - LinkedList - Stack - Queue

            // HashTables
            //  Non-Generic : HashTable
            //  Generic     : Dictionary - SortedDictionary 
            #endregion

            #region HashTable
            //  Non-Generic : HashTable

            //Hashtable phoneBook = new Hashtable();
            //phoneBook.Add("Ahmed", 111111);
            //phoneBook.Add("Abdelrahman", 222222);
            //phoneBook.Add("Toqa", 333333);
            //phoneBook.Add("Mona", 111111);

            ////Console.WriteLine(phoneBook.IsFixedSize);
            ////Console.WriteLine(phoneBook.IsReadOnly);

            //phoneBook["Ali"] = 444444;
            //phoneBook["Mona"] = 555555;
            //Console.WriteLine(phoneBook["Alaa"]);

            //bool flag = phoneBook.Contains("Alaa");
            //Console.WriteLine(flag);

            //flag = phoneBook.ContainsKey("Ahmed");
            //Console.WriteLine(flag);

            //flag = phoneBook.ContainsValue(111111);
            //Console.WriteLine(flag);


            //foreach (DictionaryEntry item in phoneBook)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Dictionary
            //  Generic     : Dictionary

            //Dictionary<string, long> phoneBook = new Dictionary<string, long>();
            //phoneBook.Add("Ahmed", 111111);
            //phoneBook.Add("Abdelrahman", 222222);
            //phoneBook.Add("Toqa", 333333);
            //phoneBook.Add("Mona", 111111);

            //bool flag = phoneBook.Remove("Ahmed", out long value);
            //Console.WriteLine(flag);
            //Console.WriteLine(value);

            //flag = phoneBook.TryAdd("Ayman", 111111);
            //Console.WriteLine(flag);

            //flag = phoneBook.TryGetValue("Ahmed", out value);
            //Console.WriteLine(flag);
            //Console.WriteLine(value);


            //foreach (KeyValuePair<string, long> item in phoneBook)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region HashSet
            ////  Generic     : HashSet
            //HashSet<string> names = new HashSet<string>();
            //names.Add("Ahmed");
            //names.Add("Abdelrahman");
            //names.Add("Omar");
            //names.Add("Ali");
            //names.Add("Ahmed");

            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region SortedDictionary
            //SortedDictionary<int, string> pairs = new SortedDictionary<int, string>();
            //pairs.Add(23,"Ahmed");
            //pairs.Add(22,"Abdelrahman");
            //pairs.Add(20,"Omar");
            //pairs.Add(21,"Toqa");

            //foreach (var item in pairs)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region SortedList
            //SortedList<int, string> pairs = new SortedList<int, string>();
            //pairs.Add(23, "Ahmed");
            //pairs.Add(22, "Abdelrahman");
            //pairs.Add(20, "Omar");
            //pairs.Add(21, "Toqa");

            //foreach (var item in pairs)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region SortedSet
            //SortedSet<string> names = new SortedSet<string>();

            //names.Add("Ahmed");
            //names.Add("Abdelrahman");
            //names.Add("Abdelrahman");
            //names.Add("Ali");
            //names.Add("Omar");
            //names.Add("Toqa");

            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Event Ex01
            //Ball ball = new Ball() { Id = 1 };
            //Console.WriteLine(ball);
            //ball.Location = new Location() { X = 1, Y = 1, Z = 1 };
            //Console.WriteLine(ball);

            //Player p01 = new Player() { Name="Missi", TeamName="Miami" };
            //Player p02 = new Player() { Name="Alba", TeamName="Miami" };
            //Player p03 = new Player() { Name="Pedri", TeamName="Barcilona" };
            //Player p04 = new Player() { Name="Gavi", TeamName= "Barcilona" };

            //Refree refree = new Refree() { Name = "Ibrahim" };

            ////ball.Players.Add(p01);
            ////ball.Players.Add(p02);
            ////ball.Players.Add(p03);
            ////ball.Players.Add(p04);

            ////ball.Refrees.Add(refree);

            //ball.BallLocationChange += p01.Run;
            //ball.BallLocationChange += p02.Run;
            //ball.BallLocationChange += p03.Run;
            //ball.BallLocationChange += p04.Run;
            //ball.BallLocationChange += refree.Look;

            //ball.Location = new Location() { X = 3, Y = 1, Z = 1 };
            //Console.WriteLine(ball); 
            #endregion

            #region Event Ex02
            //Channel channel = new Channel() { Title = "DotNet" };
            //channel.AddVideo(new Video() { Title = "MVC", Description = "C#" });
            //Subscriper s01 = new Subscriper() { Name = "Abdelrahman"};
            //Subscriper s02 = new Subscriper() { Name = "Toqa"};
            //Subscriper s03 = new Subscriper() { Name = "Ahmed"};
            //Subscriper s04 = new Subscriper() { Name = "Omar"};

            //channel.Subscribers.Add(s01);
            //channel.Subscribers.Add(s02);
            //channel.Subscribers.Add(s03);

            //channel.Uploaded += s01.Notify;
            //channel.Uploaded += s02.Notify;
            //channel.Uploaded += s03.Notify;

            //channel.AddVideo(new Video() { Title = "MVC", Description = "C#" });

            //Console.WriteLine("After Ahmed UnSubscripe");
            //channel.Uploaded -= s03.Notify;
            //channel.Uploaded += s04.Notify;

            //channel.AddVideo(new Video() { Title = "EF Core", Description = "C#" }); 
            #endregion

        }
    }
}
