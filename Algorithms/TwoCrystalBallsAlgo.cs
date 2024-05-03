namespace Algorithms;

public class TwoCrystalBallsAlgo
{
    public static int TwoCrystalBalls(bool[] breaks) 
    {
        var jumpAmount = (int)Math.Floor(Math.Sqrt(breaks.Length));

        var i = jumpAmount;
        for(;i < breaks.Length; i += jumpAmount)
        {
            if(breaks[i] == true)
            {
                break;
            }
        }

        i -= jumpAmount;
        
        for(var j = 0; j <= jumpAmount && i < breaks.Length; i++, j++)
        {
            if(breaks[i])
            {
                return i;
            }
        }

        return -1;


    }

}