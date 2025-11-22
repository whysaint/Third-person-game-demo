using System;
using UnityEngine;

public class RelativeMoement : MonoBehaviour
{
    [SerializeField] private Transform target;

    public float rotSpeed = 15.0f;

    private void Update()
    {
        Vector3 movement = Vector3.zero;
        
        float horInput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");
        if (horInput != 0 || vertInput != 0)
        {
            Vector3 right = target.right;
            Vector3 forward = Vector3.Cross(right, Vector3.up);
            movement = (right * horInput) + (forward * vertInput);

            Quaternion direction = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Lerp(transform.rotation, direction, rotSpeed * Time.deltaTime);
        }
    }
}
