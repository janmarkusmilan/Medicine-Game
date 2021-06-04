using UnityEngine;
using System.Collections;

public class CountStars : MonoBehaviour
{
    public void ThreeStars()
    {
        TotalScore.totalStars += 3;
    }

    public void TwoStars()
    {
        TotalScore.totalStars += 2;
    }

    public void OneStar()
    {
        TotalScore.totalStars += 1;
    }

    public void ResetScore()
	{
		TotalScore.totalStars = 0;
	}
}
