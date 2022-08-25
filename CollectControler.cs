using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectControler : MonoBehaviour
{
    /*Temas edilen oyun objesini oyuncu oyun objesine dönüştürmeye yarayan methot.*/
    void OnTriggerEnter(Collider temas)
    {
        if(temas.gameObject.CompareTag("Money"))
        {
            temas.gameObject.transform.position = transform.position + Vector3.forward;
            Destroy(gameObject.GetComponent<CollectControler>());
            temas.gameObject.AddComponent<CollectControler>();
            temas.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            temas.gameObject.AddComponent<NoodeMovement>();
            temas.gameObject.GetComponent<NoodeMovement>().connectedNoode = transform;
            temas.gameObject.tag = "CollectedMoney";
        }
    }
}
