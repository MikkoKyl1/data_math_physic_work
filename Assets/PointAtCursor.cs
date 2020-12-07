using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAtCursor : MonoBehaviour
{
    private GameObject cannon;

    private Vector2 cannonDirection;
    private Ray ray;

    private void Awake()
    {
        cannon = this.gameObject;
    }

    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        cannonDirection = ray.origin - cannon.transform.position;

        Debug.Log(cannonDirection);

        cannon.transform.right = new Vector3(cannonDirection.x, cannonDirection.y, 0);
    }
}
