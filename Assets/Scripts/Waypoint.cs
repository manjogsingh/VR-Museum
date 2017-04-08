using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Waypoint : MonoBehaviour
{

    public Transform startPosition;
    public Transform endPosition;
    public float speed = 0.05f;
    bool startLerp;
    GameObject currentObject;
    void Start()
    {
        startLerp = false;
        //startPosition=transform;
        StartCoroutine(waitForStart());
    }
    public void Move(Transform current)
    {
        endPosition = current;
        startLerp = !startLerp;
    }
    IEnumerator waitForStart()
    {
        while (!startLerp)
        {
            yield return new WaitForSeconds(1.0f);
        }
        StartCoroutine(MoveTo());
    }
    IEnumerator MoveTo()
    {
        startLerp = false;
        float timeToStart = Time.time;
        while (!startLerp)
        {
            float temp = (Time.time - timeToStart) * speed;
            startPosition.position = Vector3.Lerp(startPosition.position, endPosition.position, temp);
            //endPosition.localScale = Vector3.Lerp(endPosition.localScale, new Vector3(0, 0, 0), temp);
            yield return null;
        }
        StartCoroutine(waitForStart());
    }
}
