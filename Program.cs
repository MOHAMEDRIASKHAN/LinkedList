using System.Collections;


namespace LinkedList
{
    class progrsm
    {
        public static void Main(string[] args)
        {
            LinkedListMain linkedListMain = new LinkedListMain();

            linkedListMain.Add(56);
            linkedListMain.Add(30);
            linkedListMain.Add(70);
            linkedListMain.Add(40);             //Inserted Extra 40;
            

            linkedListMain.Display();

            //Hashtable dict = new Hashtable();
            //dict.Add(2,"Riyas");
            //dict.Add(3,"Uma");
            //dict.Add(4,"UmaRiyas");

            //foreach(DictionaryEntry ele in dict)
            //{
            //    Console.WriteLine(ele.Key+" - " +ele.Value);
            //}

            //Console.WriteLine(dict[3]);
        }
    }
}
