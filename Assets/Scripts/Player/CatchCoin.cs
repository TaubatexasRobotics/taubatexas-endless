using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CatchCoin : MonoBehaviour
{
    public int coins;

    void Start(){
        coins = 0;
    }
    void OnTriggerEnter2D(Collider2D other){
        //se colidir com uma moeda
        if(other.gameObject.tag == "Coin"){
            coins += 1;
            Destroy(other.gameObject);
        }
    }
}
