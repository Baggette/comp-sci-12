
namespace Program
{
    class Program
    {
        static void lyrics(int line)
        {
            string[] lyrics =
            {
                "Aah\r\nYeah\r\nWoo\r\nHey yeah\r\nHaa\r\nOoh yeah\r\nAh-ha\r\nYeah\r\nI wanna dance",//0
                "Clock strikes upon the hour\r\nAnd the sun begins to fade\r\nStill enough time to figure out\r\nHow to chase my blues away",//1
                "I've done alright up 'till now\r\nIt's the light of day that shows me how\r\nAnd when the night falls, loneliness calls",//2
                "Oh, I wanna dance with somebody\r\nI wanna feel the heat with somebody\r\nYeah, I wanna dance with somebody\r\nWith somebody who loves me",//3
                "I've been in love and lost my senses\r\nSpinning through the town\r\nSooner or later, the fever ends\r\nAnd I wind up feeling down",//4
                "I need a man who'll take the chance\r\nOn a love that burns hot enough to last\r\nSo when the night falls\r\nMy lonely heart calls",//5
                "Somebody who, somebody who\r\nSomebody who loves me yeah\r\nSomebody who, somebody who\r\nTo hold me in his arms oh",//6
                "Ooh ooh (dance)\r\nCome on baby (dance)\r\nOoh, yeah (dance)\r\nNow get with this\r\nWhoah!",//7
                "Don'tcha wanna dance with me baby?\r\nDon'tcha wanna dance with me boy?\r\nHey don'tcha wanna dance with me baby?\r\nWith somebody who loves me?\r\nDon'tcha wanna dance, say you wanna dance, don'tcha wanna dance\r\nDon'tcha wanna dance, say you wanna dance, don'tcha wanna dance\r\nDon'tcha wanna dance, say you wanna dance, ah-ha\r\nWith somebody who loves me\r\nDance, dance, dance (hey baby!)"//8


            };
            Console.WriteLine(lyrics[line]);
        }
        static void lyricloop()
        {
            int[] counter = { 0, 1, 2, 3, 3, 4, 5, 3, 3, 6, 5, 3, 3, 7, 8 };
            for (int i = 0; i < counter.GetLength(0); i++)
            {
                Console.ReadKey();
                Console.WriteLine("");
                lyrics(counter[i]);
            }
            Main();
        }
        static void Main()
            {
                string exit = "";

                while (exit != "exit")
                {
                    Console.WriteLine("Press enter to continue or exit to exit");
                    exit = Console.ReadLine().ToLower();
                    lyricloop();
                }
                Console.WriteLine("Bye");
                Console.ReadLine();
            }

            //while (input != "exit")
            //{
            //    Console.WriteLine("type the word exit");
            //    input = Console.ReadLine().ToLower();
            //    Console.WriteLine($"you entered {input}");
            //}

            //Console.WriteLine("bye");
            //Console.ReadLine();

            //foreach (string s in message)
            //{
            //    if (s == 'love')
            //    { 

            //    }
            //}

            /*for (int i = 0; i < colours.GetLength(0); i++)
            {
                Console.WriteLine($"colours! {colours[i]}");
            }*/
        }
}