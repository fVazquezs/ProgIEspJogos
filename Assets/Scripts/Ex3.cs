using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    [Range(0.1f, 10f)]
    public float speed = 1;
    public float amplitud = 2;

    private int direction = 1;

    private Vector3 basePosition;

    void Start()
    {
        basePosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (!Physics.Raycast(new Ray(new Vector3(pos.x + direction, pos.y, pos.z), Vector3.down)))
        {
            direction *= -1;
        }
        pos.x += Time.deltaTime * speed * direction;
       
        float zPos =  amplitud * Mathf.Sin(Mathf.PI / 2 * pos.x) * basePosition.z;
        pos.z = zPos;
       
        transform.right = pos - transform.position;
        transform.position = pos;
    }
}
