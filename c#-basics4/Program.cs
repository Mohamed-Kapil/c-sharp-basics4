namespace c__basics4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1 question

            double[] prices = { 25.5, 40.0, 33.75 };

            Console.WriteLine(prices[1]);

            #endregion

            #region 2 question

            int[,] shelfCopies =
              {
                { 3, 5 },
                { 1, 4 }
               };

            Console.WriteLine(shelfCopies[1, 0]);

            #endregion

            #region 3 question

            static void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Library!");
            }

            PrintWelcomeMessage();

            #endregion

            #region 4 question

            static void PrintBookTitle(string title)
            {
                Console.WriteLine("Book title: " + title);
            }

            PrintBookTitle("Clean Code");

            #endregion

            #region 5 question

            static void AddBonusPages(int pages)
            {
                pages = pages + 50;
            }

            int pages = 400;

            AddBonusPages(pages);

            Console.WriteLine(pages);

            #endregion

            #region 6 question

            static void ApplyDiscount(double[] pricess)
            {
                pricess[0] = pricess[0] - 5;
            }

            double[] pricess = { 25.5, 40.0 };

            ApplyDiscount(pricess);

            Console.WriteLine(pricess[0]);

            #endregion

            #region 7 question

            static void AddBonusPagesByRef(ref int pagess)
            {
                pagess = pagess + 50;
            }

            int pagess = 400;

            AddBonusPagesByRef(ref pagess);

            Console.WriteLine(pagess);

            #endregion

            #region 8 question

            static void ReplaceArray(ref double[] pricessss)
            {
                pricessss = new double[] { 10.0, 12.5, 15.0 };
            }

            double[] pricessss = { 25.5, 40.0 };

            ReplaceArray(ref pricessss);

            Console.WriteLine(pricessss.Length);

            #endregion

            #region 9 question

            static bool TryGetPrice(string title, out double price)
            {
                if (title == "Clean Code")
                {
                    price = 25.5;
                    return true;
                }

                price = 0;
                return false;
            }

            double price;

            if (TryGetPrice("Clean Code", out price))
            {
                Console.WriteLine(price);
            }

            static void PrintBookInfo(string title, int pages = 300)
            {
                Console.WriteLine("Title: " + title);
                Console.WriteLine("Pages: " + pages);
            }


            PrintBookInfo("Clean Code");

            PrintBookInfo("Refactoring", 464);


            #endregion

            #region 10 question

            PrintBookInfo(pages: 464, title: "Refactoring");

            #endregion

            #region 11 question

            static void PrintAllTitles(params string[] titles)
            {
                foreach (string title in titles)
                {
                    Console.WriteLine(title);
                }
            }

            PrintAllTitles("Clean Code", "Refactoring", "The Pragmatic Programmer");

            #endregion

        }
    }
}
