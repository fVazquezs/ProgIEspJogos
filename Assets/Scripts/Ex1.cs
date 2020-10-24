using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    [Range(0.1f, 10f)]
    public float speed = 1;

    private Vector3 basePosition;

    // Start is called before the first frame update
    void Start()
    {
        basePosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (IsObjectInsideThePlane(pos))
        {
            pos.x += Time.deltaTime * speed;
            transform.position = pos;
        } else {
            transform.position = basePosition;
        }
    }

    bool IsObjectInsideThePlane(Vector3 position)
    {
        Debug.Log(Physics.Raycast(new Ray(position, Vector3.down)));
        return Physics.Raycast(new Ray(position, Vector3.down));
    }
}
