using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private Transform target;
    [SerializeField] private float smoothing;

    [SerializeField] private Vector2 minPos;
    [SerializeField] private Vector2 maxPos;

    private void LateUpdate()
    {
        Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);

        targetPosition.x = Mathf.Clamp(targetPosition.x, minPos.x, maxPos.x);
        targetPosition.y = Mathf.Clamp(targetPosition.y, minPos.y, maxPos.y);


        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
            
    }




}
