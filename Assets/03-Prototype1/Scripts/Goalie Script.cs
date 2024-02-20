using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goalie : MonoBehaviour
{
    [Header("Set in Inspector")]

    
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirections = 0.0005f;
    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update



    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        pos.z += speed * Time.deltaTime;

        transform.position = pos;

        if (pos.z < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.z > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
        else if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= 1;
        }
    }
}