using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
    /*Temas edilen oyun objesinin rengini ve etiketini değiştirmeyi sağlayan methot.*/
    [SerializeField] Color yellowColor;
    void OnTriggerEnter(Collider temas)
    {
        if(temas.gameObject.CompareTag("CollectedMoney"))
        {
            temas.gameObject.GetComponent<MeshRenderer>().material.color = yellowColor;
            temas.gameObject.tag = "Gold";
        }

    }
}
