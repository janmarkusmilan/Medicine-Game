using UnityEngine;
using UnityEngine.UI;

public class SetButton : MonoBehaviour
{
    public void Correct(Transform repeat, Transform correct, Transform partial, Transform incorrect)
    {
        repeat.gameObject.SetActive(false);
        correct.gameObject.SetActive(true);
        partial.gameObject.SetActive(false);
        incorrect.gameObject.SetActive(false);
    }
    public void Partial(Transform repeat, Transform correct, Transform partial, Transform incorrect)
    {
        repeat.gameObject.SetActive(false);
        correct.gameObject.SetActive(false);
        partial.gameObject.SetActive(true);
        incorrect.gameObject.SetActive(false);
    }
    public void Incorrect(Transform repeat, Transform correct, Transform partial, Transform incorrect)
    {
        repeat.gameObject.SetActive(false);
        correct.gameObject.SetActive(false);
        partial.gameObject.SetActive(false);
        incorrect.gameObject.SetActive(true);
    }

    // ------------------------------------------------------------------------------------------------------------------------

    public void IncorrectMedicineTaskOnClick()
    {
        GameObject npcList = GameObject.Find("NPCS");
        Transform npcTrans = npcList.transform.Find(GameManager.currentNPC);

        Transform rpgTalkRepeat;
        Transform rpgTalkCorrect;
        Transform rpgTalkPartial;
        Transform rpgTalkIncorrect;

        rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Repeat Info");
        rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Correct");
        rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Partially Correct");
        rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Incorrect");

        Incorrect(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
    }

    // ------------------------------------------------------------------------------------------------------------------------

    public void TrazodoneTaskOnClick()
    {
        GameObject npcList = GameObject.Find("NPCS");
        Transform npcTrans = npcList.transform.Find(GameManager.currentNPC);

        Transform rpgTalkRepeat;
        Transform rpgTalkCorrect;
        Transform rpgTalkPartial;
        Transform rpgTalkIncorrect;

        if (GameManager.currentNPC == "NPC Mia")
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient 1 Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient 1 Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient 1 Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient 1 Incorrect");

            Correct(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
        else
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Incorrect");

            Incorrect(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------

    public void AcetaminophenTaskOnClick()
    {
        GameObject npcList = GameObject.Find("NPCS");
        Transform npcTrans = npcList.transform.Find(GameManager.currentNPC);

        Transform rpgTalkRepeat;
        Transform rpgTalkCorrect;
        Transform rpgTalkPartial;
        Transform rpgTalkIncorrect;

        if (GameManager.currentNPC == "NPC Laura")
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient 2 Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient 2 Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient 2 Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient 2 Incorrect");

            Correct(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
        else
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Incorrect");

            Incorrect(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
    }

    public void IbuprofenTaskOnClick()
    {
        GameObject npcList = GameObject.Find("NPCS");
        Transform npcTrans = npcList.transform.Find(GameManager.currentNPC);

        Transform rpgTalkRepeat;
        Transform rpgTalkCorrect;
        Transform rpgTalkPartial;
        Transform rpgTalkIncorrect;

        if (GameManager.currentNPC == "NPC Laura")
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient 2 Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient 2 Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient 2 Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient 2 Incorrect");

            Partial(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
        else if (GameManager.currentNPC == "NPC Connor")
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient 6 Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient 6 Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient 6 Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient 6 Incorrect");

            Partial(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
        else
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Incorrect");

            Incorrect(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------

    public void EtonogestrelTaskOnClick()
    {
        GameObject npcList = GameObject.Find("NPCS");
        Transform npcTrans = npcList.transform.Find(GameManager.currentNPC);

        Transform rpgTalkRepeat;
        Transform rpgTalkCorrect;
        Transform rpgTalkPartial;
        Transform rpgTalkIncorrect;

        if (GameManager.currentNPC == "NPC Kelly")
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient 3 Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient 3 Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient 3 Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient 3 Incorrect");

            Correct(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
        else
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Incorrect");

            Incorrect(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------

    public void LoratadineTaskOnClick()
    {
        GameObject npcList = GameObject.Find("NPCS");
        Transform npcTrans = npcList.transform.Find(GameManager.currentNPC);

        Transform rpgTalkRepeat;
        Transform rpgTalkCorrect;
        Transform rpgTalkPartial;
        Transform rpgTalkIncorrect;

        if (GameManager.currentNPC == "NPC Sarah")
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient 4 Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient 4 Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient 4 Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient 4 Incorrect");

            Correct(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
        else
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Incorrect");

            Incorrect(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------

    public void SumatriptanTaskOnClick()
    {
        GameObject npcList = GameObject.Find("NPCS");
        Transform npcTrans = npcList.transform.Find(GameManager.currentNPC);

        Transform rpgTalkRepeat;
        Transform rpgTalkCorrect;
        Transform rpgTalkPartial;
        Transform rpgTalkIncorrect;

        if (GameManager.currentNPC == "NPC Jake")
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient 5 Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient 5 Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient 5 Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient 5 Incorrect");

            Correct(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
        else
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Incorrect");

            Incorrect(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------

    public void MetoprololTaskOnClick()
    {
        GameObject npcList = GameObject.Find("NPCS");
        Transform npcTrans = npcList.transform.Find(GameManager.currentNPC);

        Transform rpgTalkRepeat;
        Transform rpgTalkCorrect;
        Transform rpgTalkPartial;
        Transform rpgTalkIncorrect;

        if (GameManager.currentNPC == "NPC Connor")
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient 6 Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient 6 Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient 6 Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient 6 Incorrect");

            Correct(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
        else
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Incorrect");

            Incorrect(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------

    public void AlbuterolTaskOnClick()
    {
        GameObject npcList = GameObject.Find("NPCS");
        Transform npcTrans = npcList.transform.Find(GameManager.currentNPC);

        Transform rpgTalkRepeat;
        Transform rpgTalkCorrect;
        Transform rpgTalkPartial;
        Transform rpgTalkIncorrect;

        if (GameManager.currentNPC == "NPC Ryan")
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient 7 Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient 7 Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient 7 Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient 7 Incorrect");

            Correct(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
        else
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Incorrect");

            Incorrect(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------

    public void AcyclovirTaskOnClick()
    {
        GameObject npcList = GameObject.Find("NPCS");
        Transform npcTrans = npcList.transform.Find(GameManager.currentNPC);

        Transform rpgTalkRepeat;
        Transform rpgTalkCorrect;
        Transform rpgTalkPartial;
        Transform rpgTalkIncorrect;

        if (GameManager.currentNPC == "NPC Eden")
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient 8 Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient 8 Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient 8 Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient 8 Incorrect");

            Correct(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
        else
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Incorrect");

            Incorrect(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------

    public void LovastatinTaskOnClick()
    {
        GameObject npcList = GameObject.Find("NPCS");
        Transform npcTrans = npcList.transform.Find(GameManager.currentNPC);

        Transform rpgTalkRepeat;
        Transform rpgTalkCorrect;
        Transform rpgTalkPartial;
        Transform rpgTalkIncorrect;

        if (GameManager.currentNPC == "NPC Luna")
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient 9 Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient 9 Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient 9 Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient 9 Incorrect");

            Correct(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
        else
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Incorrect");

            Incorrect(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
    }

    // ------------------------------------------------------------------------------------------------------------------------

    public void OmeprazoleTaskOnClick()
    {
        GameObject npcList = GameObject.Find("NPCS");
        Transform npcTrans = npcList.transform.Find(GameManager.currentNPC);

        Transform rpgTalkRepeat;
        Transform rpgTalkCorrect;
        Transform rpgTalkPartial;
        Transform rpgTalkIncorrect;

        if (GameManager.currentNPC == "NPC Jamie")
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient 10 Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient 10 Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient 10 Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient 10 Incorrect");

            Correct(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
        else
        {
            rpgTalkRepeat = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Repeat Info");
            rpgTalkCorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Correct");
            rpgTalkPartial = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Partially Correct");
            rpgTalkIncorrect = npcTrans.transform.Find("RPGTalkArea Patient " + GameManager.patientNum + " Incorrect");

            Incorrect(rpgTalkRepeat, rpgTalkCorrect, rpgTalkPartial, rpgTalkIncorrect);
        }
    }
}
