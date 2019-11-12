using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            //game.ListPlayers();
            //Console.ReadLine();


            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();                                       //Adding a player
            //player.Name = "Jonathan";
            //game = game + player;                                               //Method operator overloading...You can also write it like game += player;
            //game = game - player;                                               //.....game -= player;

            // Card card = new Card();
            //card.Suit = Suit.Clubs;


            //Deck deck = new Deck();
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);                  //Lambda for .Count 
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList(); //Lambda for .Where
            //foreach(Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}
            // List<int> numberList = new List<int>() { 1, 34, 27, 35, 456, 753, 976 };
            //int sum = numberList.Sum(); //or .Max() or .Min() or .Sum(x => x + 5)...etc
            //int add = numberList.Where(x => x > 20).Sum();                           //Lambda numbers greater than 20 then add those numbers
            //Console.WriteLine(add);


            //deck.Shuffle(3);                                                    //Calling our shuffle method to iterate 3 times

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();


            Deck deck = new Deck();
            deck.Shuffle(3);
            //deck = Shuffle(deck, 3);

            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            //Console.WriteLine("Times Shuffled: {0}", timesshuffled);                    //A way to format strings, we could add {0}{1}, timesshuffled, another method...etc
            Console.ReadLine();
        }


        //public static Deck Shuffle(Deck deck, int times)                            //Overload method
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);                                               //Reshuffling deck iteration
        //    }
        //    return deck;
        //}
    }
}
