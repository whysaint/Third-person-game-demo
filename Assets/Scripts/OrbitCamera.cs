using System;
using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    [SerializeField] private Transform target;

    public float rotSpeedKeyboard = 90f;
    public float rotSpeedMouse = 270f;

    private float _rotY;
    private Vector3 _offset;

    private void Start()
    {
        _rotY = transform.eulerAngles.y;
        _offset = target.position - transform.position;
    }

    private void LateUpdate()
    {
        float horInput = Input.GetAxis("Horizontal");
        float mouseX = Input.GetAxis("Mouse X");
        
        if (!Mathf.Approximately(horInput, 0))
        {
            _rotY += horInput * rotSpeedKeyboard * Time.deltaTime;
        }
        else
        {
            _rotY += mouseX * rotSpeedMouse * 3 * Time.deltaTime;
        }
        
        Quaternion rotation = Quaternion.Euler(0, _rotY, 0);
        transform.position = target.position - (rotation * _offset);
        transform.LookAt(target);
    }
}
