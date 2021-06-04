using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TotalScore : MonoBehaviour
{
    public static int totalStars = 0;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Text gt = this.GetComponent<Text>();
        if (totalStars < 15)
        {
            gt.text = "You got a total of " + totalStars + "/30 stars this playthrough. That's okay! " +
                "Memorizing medicine properties takes time, and we all start from somewhere. " +
                "You will definitely do better next time!";
        }
        else if (totalStars >= 15 && totalStars < 20)
        {
            gt.text = "You got a total of " + totalStars + "/30 stars this playthrough. You're getting better! " +
                "It's completely fine if this is not the results you were expecting. " +
                "Just keep practicing and you'll get the hang of it!";
        }
        else if (totalStars >= 20 && totalStars < 25)
        {
            gt.text = "You got a total of " + totalStars + "/30 stars this playthrough. Nice job! " +
                "You can still improve your score and knowledge. " +
                "Keep at it and you will eventually get everything right!";
        }
        else if (totalStars >= 25 && totalStars < 30)
        {
            gt.text = "You got a total of " + totalStars + "/30 stars this playthrough. Excellent work! " +
                "You might have made a minor mistake here and there, but what matters is that you're starting to grasp a basic knowledge of several medicines. " +
                "Try aiming for a perfect score! You can definitely do it!";
        }
        else if (totalStars == 30)
        {
            gt.text = "You got a total of " + totalStars + "/30 stars this playthrough. Amazing! " +
                "You now have an understanding of a few common medicines that we use in the world today. " +
                "Congratulations on the perfect score, and thank you for playing this game!";
        }
    }
}
