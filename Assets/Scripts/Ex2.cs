using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    [Range(0.1f, 10f)]
    public float speed = 1;

    private int direction = 1;


    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (!Physics.Raycast(new Ray(new Vector3(pos.x + direction, pos.y, pos.z), Vector3.down)))
        {
            direction *= -1;
        }
        pos.x += Time.deltaTime * speed * direction;
        transform.position = pos;
    }

}
