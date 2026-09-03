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
            #endregion

            #region 7 question
            #endregion

            #region 8 question
            #endregion

            #region 9 question
            #endregion

            #region 10 question
            #endregion

            #region 11 question
            #endregion
        }
    }
}
