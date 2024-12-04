using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI Score_text;

    int count;
    int Number;

    public GameObject[] objects;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objects = GameObject.FindGameObjectsWithTag("After");
        count = objects.Length;
        Number = 75 - count;
        Score_text.text = "" + Number;

        if (Number == 0)
        {
            FadeManager.Instance.LoadScene("GameClearScene", 1.0f);
        }

    }
}
