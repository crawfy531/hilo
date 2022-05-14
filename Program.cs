
    //player: guess, points, play again : dealer-------------------------------------------------------
namespace hilo{
    class Program{

    public class Player{
        public string turn(){
            Console.Write("Higher or lower? [h/l]");
            string input = Console.ReadLine();
            return input;
        }
        public int pointsEarned(bool correct, int pointsTotal){
            int points = 0;
            if(correct){
                points = 100;
            }
            else{
                points = -75;
            }
            pointsTotal += points;
            return pointsTotal;
        }
    }

        //card: generate random number 1-13 : dealer-------------------------------------------------------
    public class Card{

        public int newCard(){
            Random r = new Random();
            int newCard = r.Next(1,13);
            return newCard;
        }
    }
    //dealer : draws cards, compare cards, asks for input, give/receive points, end game: player,card
    public class Dealer{
        public bool comparison( int upCard, int downCard, string guess){
            string answer = "na";
            bool correct = false;

            if(downCard < upCard){
                answer = "l";
            }
            else if (downCard > upCard){
                answer = "h";
            }
            if(answer == guess){
                correct = true;
            }
            else{
                correct = false;
            }
            return correct;
            ;
        }
        public bool keepPlay(){
            bool play = true;
            string input = "na";
            while(input != "y" && input != "n"){
                Console.Write("Play again? [y/n]");
                input = Console.ReadLine();
                if(input != "y" && input != "n"){
                    Console.WriteLine("Please put either y for yes or n for no");
                }

        }
            if(input == "y"){
                play = true;
            }
            else{
                play = false;
            }
            return play;
        }
    }
    static void Main(){
        Program pr = new Program();
        Dealer d = new Dealer();
        Card c = new Card();
        Player pl = new Player();

        string guess = "na";
        int pointsTotal = 300;
        bool play = true;
        int upCard = 0;
        int downCard = 0;
        bool correct = false;

        while(play == true){
        guess = "na";
        Console.Write("The card is: ");
        upCard = c.newCard();
        Console.WriteLine(upCard);
        while(guess != "l" && guess != "h"){
            guess = pl.turn();
            if(guess != "l" && guess != "h"){
                Console.WriteLine("You need to enter either an h (higher) or an l (lower).");
            }
        }
        downCard = c.newCard();
        Console.WriteLine($"Next card was: {downCard}");
        correct = d.comparison(upCard, downCard, guess);
        pointsTotal = pl.pointsEarned(correct, pointsTotal);
        Console.WriteLine($"Your score is: {pointsTotal}");
        if(pointsTotal <= 0){
            Console.WriteLine("Your points reached below 0...");
            Console.WriteLine("Game Over");
            pointsTotal = 300;
        }
        play = d.keepPlay();
        }

    }
    }
}

