using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoodeMovement : MonoBehaviour
{
    public Transform connectedNoode;

    void Update()
    {
        NoodeLerp();
    }
    /*Toplanan oyun objelerini topladığımız ve eğrisel hareket kazandırdığımız methot.*/
    void NoodeLerp()
    {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, connectedNoode.position.x, Time.deltaTime * 20), connectedNoode.position.y, connectedNoode.position.z + 1);
    }
}
