using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public ScoreCounter scoreCounter;

    public LevelCounter levelCounter;
    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreCounter = scoreGO.GetComponent<ScoreCounter>();

        GameObject levelGO = GameObject.Find("LevelCounter");
        levelCounter = levelGO.GetComponent<LevelCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        Debug.Log("Collided with " + collidedWith.name);
        if (collidedWith.CompareTag("Apple"))
        {
            Destroy(collidedWith);
            scoreCounter.score += 100;
            HighScore.TRY_SET_HIGH_SCORE(scoreCounter.score);
            if (scoreCounter.score == 1000)
            {
                levelCounter.score += 1;
            }
            else if (scoreCounter.score == 2000)
            {
                levelCounter.score += 1;
            }
            else if (scoreCounter.score == 4000)
            {
                levelCounter.score += 1;
            }
            else if (scoreCounter.score == 8000)
            {
                levelCounter.score += 1;
            }
        }
        if (collidedWith.CompareTag("Branch"))
        {
            Debug.Log("Branch collected!");
            Destroy(collidedWith);
            
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            apScript.BranchHit();
        }
    }
}
