using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelCounter : MonoBehaviour
{
    [Header("Dynamic")]
    public int score = 0;
    
    public AppleTree appleTree;
    
    private TextMeshProUGUI uiText;

    void Start()
    {
        uiText = GetComponent<TextMeshProUGUI>();

        // GameObject appleTreeGO = GameObject.Find("AppleTree");
        // appleTree = appleTreeGO.GetComponent<AppleTree>();
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = score.ToString("#,0");

        // if (levelCounter.score == 1)
        // {
        //     appleTree.speed = 15f;
        // }
        // else if (levelCounter.score == 2)
        // {
        //     appleTree.speed = 20f;
        // }
        // else if (levelCounter.score == 3)
        // {
        //     appleTree.speed = 25f;
        // }
        // else if (levelCounter.score == 4)
        // {
        //     appleTree.speed = 35f;
        // }
    }
}

