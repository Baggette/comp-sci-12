namespace multi_methods
{
    class Program
    {
        //method that when executed prints an item from the array based on a given value 
        static void lyrics(int line)
        {
            //declare lyrics in an array
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
            //write lyrics to console
            Console.WriteLine(lyrics[line]);
        }
        static void lyricloop()
        {
            //the order that the lyrics go
            int[] counter = { 0, 1, 2, 3, 3, 4, 5, 3, 3, 6, 5, 3, 3, 7, 8 };
            //iterate through all of the items in the counter array until its done
            for (int i = 0; i < counter.GetLength(0); i++)
            {
                Console.ReadKey();
                Console.WriteLine("");
                lyrics(counter[i]);
            }
            //when its done execute main again
            Main();
        }
        static void Main()
        {

            string exit;
            //prompt user if they want to exit
            do
            {
                Console.WriteLine("Press enter to continue or exit to exit");
                exit = Console.ReadLine().ToLower();
                //check user input, if its exit, exit if not continue
                if (exit == "exit") return;
                //execute the lyric printing method
                lyricloop();
            } while (exit != "exit"); //this while doesn't seem to do anything however it breaks when its removed
        }

    }
}