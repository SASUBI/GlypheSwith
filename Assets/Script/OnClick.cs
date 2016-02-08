﻿using UnityEngine;
using System.Collections;

public class OnClick : MonoBehaviour {
    public Vector3 mousePosition;
    public float moveSpeed = 0.1f;

	void Update () {
        if (Input.GetMouseButton(0))
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        }
    }
}
