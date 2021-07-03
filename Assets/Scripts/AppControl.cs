using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AppControl : MonoBehaviour
{
    public Image questionImage;
    public static List<DictionaryLookup> dictionaryLookupsList = new List<DictionaryLookup>();
    public static int answerCounter = 0;
    void Start()
    {
        questionImage.sprite = Resources.Load<Sprite>("VocabImages/DOG");

    }


    public void NextQuestion()
    {
        questionImage.sprite = Resources.Load<Sprite>("VocabImages/DUCK");
    }
}
