using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private int rotationSpeed = 200;
    void Start()
    {
        int integer = 0;
        float floatingPoint = 3.14f;
    }
    void Update()
    {
        transform.RotateAround(
            Vector3.zero, Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}