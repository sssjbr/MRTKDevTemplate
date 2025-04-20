using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCameraUpright : MonoBehaviour
{
    void Update()
    {
        if (Camera.main != null)
        {
            Vector3 direction = Camera.main.transform.position - transform.position;

            // Only rotate on Y axis (horizontal) to face user, ignore pitch and roll
            direction.y = 0;

            Quaternion targetRotation = Quaternion.LookRotation(-direction);
            transform.rotation = targetRotation;
        }
    }
}
