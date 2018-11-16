using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyThisCard : MonoBehaviour {
    public int price;

    private GameManager gm;//declared to gm so we can call to it

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();//look in the game for a game object with the name GameManager
    }

    public void buycard()
    {
        purchase();
    }

    private void purchase()
    {
        if (gm.money == 3)
        {
            Destroy(gameObject);
            print("you bought this card");
        }
        else
        {
            print("you donthave enough money");
        }
    }
}
