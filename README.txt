    Welcome to High-Low, this program is designed to let the user guess if the next
card pulled is going to be higher or lower then the current card shown. This program has four
different classes. The first one is the Main class which conducts the program calling
all of the other classes. The Card class makes new cards by generating a random number
from 1 to 13 using the newCard method. The player class represents the current player.
This class includes two methods: turn and pointsEarned. The turn method
gets input of the guess of the player of whether the next card is higher (h) or lower (l);
The pointsEarned method takes in two parameters: whether the guess the player was made and the
total number of points the player already has. The pointsEarned method then evaluates
on what to add or subtract to the total number of points the player has. Lastly there is
the Dealer class. This class has two methods: the comparison method and the keepPlay method.
The comparison method takes in thee parameters: the card that was seen by the
player, the card that was next, and the player's guess input. This method compares the
card seen with the next card and then verifies if the player's guess was right returning a boolian.
The method keepPlay simpily asks the player for input of whether they want to keep
playing and returns a boolian on whether they do or do not.
    This program is run through the console by using the c# language. The person who
produced this program was Jennifer Crawford (email address: cra21014@byui.edu) on May 14th, 2022.