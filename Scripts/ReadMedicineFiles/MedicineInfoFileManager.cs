using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;

public class MedicineInfoFileManager : MonoBehaviour
{
    string[] descriptionArray;

    //Variables to store info from complete meds file 
    string[] allMeds;
    string[] subArrayMedsInfo;
    public TextAsset completeFile;
    

    public Transform medsInfoStorage;

    void Awake()
    {
      
        ReadFromCompleteFile();
       
    }
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    //Reads the text file with all medicines and info and stores them in subArrayMedsInfo
    public void ReadFromCompleteFile()
    {
        allMeds = completeFile.text.Split("="[0]);    //ds - first split on each med sep by ==

        string description1;
        string description2;

        for (int i = 0; i < allMeds.Length; i++)
        {
            subArrayMedsInfo = allMeds[i].Split("\n"[0]);  //ds - then each med by line
            description1 = SetStringDescription1(subArrayMedsInfo);
            description2 = SetStringDescription2(subArrayMedsInfo);
            setChildDescription(subArrayMedsInfo[0], description1, description2);

        }
       
    }

    public string SetStringDescription1(string[] descriptionArray)
    {
        string content;

        content = descriptionArray[2]
            + "\n" + descriptionArray[3]
            + "\n" + descriptionArray[4]
            + "\n" + descriptionArray[5];

        return content;
        
    }

    public string SetStringDescription2(string[] descriptionArray)
    {   
        int indexForMoreDetails = 7;
        string content = "";

        for (int i = indexForMoreDetails; i < descriptionArray.Length; i++)
        {
            //String to concat all lines of txt file
            content += descriptionArray[i] + "\n";
        }

        return content;

    }

    public void setChildDescription(string medName, string description1, string description2) //before: string medName, string description
    {
        string medInfo = medName  + " Info";
        Transform medObject = medsInfoStorage.transform.Find(medInfo);
        Transform goDescription = medObject.transform.Find("Description 1");
        Transform itemFrame = goDescription.transform.Find("Item Frame");
        //TextMeshProUGUI text = itemFrame.GetComponent<TextMeshProUGUI>();

        TextMeshProUGUI text1 = medObject.GetChild(1).GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI text2 = medObject.GetChild(2).GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>();

        text1.SetText(description1);
        text2.SetText(description2);


        //Code to set the text of the child's text 
        //change from first getChild() index 1 or 2 to go from description 1 or description 2


        //TextMeshProUGUI text = child.GetChild(1).GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>();
        //text.SetText(description);
        //}


    }
    
}















//get all children of informationPanel attach to information panel
/*
public void ReadFromTheFile()
{
    //allMeds = asset.text.Split("="[0]);

    descriptionArray = asset.text.Split("\n"[0]);


    for (int i = 0; i < descriptionArray.Length; i++)
    {

        SetTextGeneralMedInfo(descriptionArray);
        SetTextMoreDetailsMedInfo(descriptionArray);
        //print(descriptionArray[i]);
        //print(descriptionArray[i]);
    }
    //print(allMeds);

}*/

/*
public void SetTextGeneralMedInfo(string[] descriptionArray)
{
//Can also put this in a loop, but the format is the same for all txt files, safe to hard code it like this.
generalMedInfo.SetText(descriptionArray[2]
    + "\n" + descriptionArray[3]
    + "\n" + descriptionArray[4]
    + "\n" + descriptionArray[5]);
}

//Print out the rest of the detailed information about med from text file
public void SetTextMoreDetailsMedInfo(string[] descriptionArray)
{
int indexForMoreDetails = 7;
moreDetailsMedInfo.SetText(descriptionArray[7] + "\n" + descriptionArray[9]);
string content = "";

for (int i = indexForMoreDetails; i < descriptionArray.Length; i++)
{
    //String to concat all lines of txt file
    content += descriptionArray[i] + "\n";
}

moreDetailsMedInfo.SetText(content);

}*/

/*
public void GetAllChildren()
{
    foreach (Transform child in medsInfoStorage.transform)
    {
        print("Foreach loop: " + child);

        //Code to set the text of the child's text 
        //change from first getChild() index 1 or 2 to go from description 1 or description 2


        TextMeshProUGUI text = child.GetChild(1).GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>();

    }

    //child.GetChild(1) code to access Desciption 1(0) and 2(1) in child

     * child.GetChild(1).GetChild(0).GetChild(0) to get the text content of the component
       it would be textmeshprogui text = child.GetChild(1).GetChild(0).GetChild(0)        


}*/
