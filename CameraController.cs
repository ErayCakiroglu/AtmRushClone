using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] float smoothSpeed;
    Vector3 offset;
    void Start()
    {
        offset = transform.position - playerTransform.position;
    }
    void Update()
    {
        CameraTracking();
    }
    /*Parametre olarak gönderilen Transform türünden playerTransform'u takip eden kamera takip metodu.*/
    void CameraTracking()
    {
        Vector3 newCameraPos = Vector3.Lerp(transform.position, playerTransform.position + offset, smoothSpeed * Time.deltaTime);
        transform.position = newCameraPos;
    }
}
