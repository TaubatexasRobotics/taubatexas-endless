using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
    GameObject Player;
    CatchCoin CC;
    public TextMeshProUGUI TextMP;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        CC = Player.GetComponent<CatchCoin>();
    }

    // Update is called once per frame
    void Update()
    {
        TextMP.SetText("coins: " + CC.coins.ToString());
    }
}
