using System;
using UnityEngine;

public class DeviceOperator : MonoBehaviour
{
    public float radios = 1.5f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, radios);

            foreach (Collider hitCollider in hitColliders)
            {
                Vector3 hitPosition = hitCollider.transform.position;
                hitPosition.y = transform.position.y;

                Vector3 derection = hitPosition - transform.position;
                if (Vector3.Dot(transform.forward, derection.normalized) > .5f)
                {
                    hitCollider.SendMessage("Operate", SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}
