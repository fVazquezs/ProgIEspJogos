using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5 : MonoBehaviour
{
    [Range(0.1f, 10f)]
    public float speed = 1;
    public float amplitud = 2;
    public Transform target;
    private int direction = 1;

    private Vector3 basePosition;

    void Start()
    {
        Debug.Log($"{target.position.z - (transform.position.z)} / {target.position.x - (transform.position.x)}");
    //     basePosition = transform.position;
    //     // Mathf.Atan(target.position.z - transform.position.z / target.position.x - transform.position.x) * (180 / Mathf.PI);
    //     transform.rotation = Quaternion.Euler(
    //             new Vector3(0, Mathf.Atan(target.position.z - (transform.position.z) / target.position.x - (transform.position.x)) * (180 / Mathf.PI), 0));
        Debug.Log(CalculateAngle());
    }

    float CalculateAngle()
    {
        return  -1 * Mathf.Atan(target.position.z - (transform.position.z) / target.position.x - (transform.position.x)) * (180 / Mathf.PI);
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(
            new Vector3(0, CalculateAngle(), 0));
        // Vector3 pos = transform.position;

        // if (!Physics.Raycast(new Ray(new Vector3(pos.x + direction, pos.y, pos.z), Vector3.down)))
        // {
        //     direction *= -1;
        // }
        // pos.x += Time.deltaTime * speed * direction;

        // float zPos = amplitud * Mathf.Sin(Mathf.PI / 2 * pos.x) * basePosition.z;
        // pos.z = zPos;


        // Quaternion rotation = transform.rotation;
        // float zChange = pos.z - transform.position.z;
        // if (zChange < 0) zChange *= -1;
        // float xChange = pos.x - transform.position.x;
        // if (xChange < 0) xChange *= -1;

        // rotation.y = Mathf.Atan(zChange / xChange) * (180 / Mathf.PI);

        // Debug.Log($"Z value {zChange} x value {xChange} {Mathf.Atan(zChange / xChange) * (180 / Mathf.PI)}");
        // transform.position = pos;

        // transform.rotation = Quaternion.Euler(new Vector3(0, rotation.y, 0));
        // Debug.Log(transform.rotation.y + " " + rotation.y);
    }
}
