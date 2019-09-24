using System;
using System.Collections.Generic;



class Game
{
    public int Main()
    {
        int origNum = 50;
        int highNum = 100;
        int lowNum  = 1;
        int splitUp = highNum - (origNum / 2);
        int splitDown = origNum - lowNum / 2 ;
        Console.WriteLine("Would you like to play a game? y/n");
        string gameAns = Console.ReadLine();
        if(gameAns == "y")
        {
            moreThanNum();
        }
    }
    static void yesGame(int origNum) {
        string questionString = Console.WriteLine("Is your number higher than" + origNum + " ? y/n");
        string questionAnswer = Console.ReadLine();
        if(questionAnswer == "y")
        {
            moreThanNum();
        }
        // else if(questionAnswer == "n")
        // {
        //     lessThanNum();
        // }
    }

        static void moreThanNum()
        {
            lowNum = origNum++;
            origNum = splitUp;
            yesGame(originNum);
    
        }
        // static void lessThanNum(string answer)
        // {
        //     highNum = orignum++;

        // }
    
}