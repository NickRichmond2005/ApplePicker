using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject applePrefab;

    public GameObject branchPrefab;

    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float changeDirChance = 0.1f;

    public float ObjectDropDelay = 1f;
    void Start()
    {
        Invoke("DropObject", 2f);
    }

    void DropObject(){
        if (Random.value < 0.75f){
            GameObject apple = Instantiate<GameObject>(applePrefab);
            apple.transform.position = transform.position;
        } else {
            GameObject branch = Instantiate<GameObject>(branchPrefab);
            branch.transform.position = transform.position;
        }
        Invoke( "DropObject", ObjectDropDelay );
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if( pos.x < -leftAndRightEdge) {
            speed = Mathf.Abs( speed );
        }else if (pos.x > leftAndRightEdge) {
            speed = -Mathf.Abs( speed );
        }
    }

    void FixedUpdate() {
        if (Random.value < changeDirChance){
            speed *= -1;
        }
    }
}
