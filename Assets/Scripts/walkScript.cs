using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkScript : MonoBehaviour
{
    public float speed;
    private Vector3 tPos;
    private bool isMoveing = false;

    void Update()
    {
        if (Input.GetMouseButton(0)) {
            triggerPosition();
        }

        if (isMoveing) {
            isMove();
        }
    }

    void triggerPosition() {
        tPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(tPos);
        tPos.z = transform.position.z;
        isMoveing = true;
    }

    void isMove() {
        transform.position = Vector3.MoveTowards(transform.position, tPos, speed * Time.deltaTime);
        if (transform.position == tPos) {
            isMoveing = false;
        }
    }

}
