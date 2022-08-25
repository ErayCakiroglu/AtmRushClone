using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoneyController : MonoBehaviour
{
    [SerializeField] float movementSpeed, horizontalSpeed;
    float horizontalMovement;
    void Update()
    {
        PlayerMoneyMovement();
    }
    /*Yatay düzlemde gelen parametre değerlerine göre yatay hareket kazandıran methot.*/
    void PlayerMoneyMovement()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalMovement * horizontalSpeed *Time.deltaTime, 0f, movementSpeed * Time.deltaTime));
    }
}
