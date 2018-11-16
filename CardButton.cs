using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardButton : MonoBehaviour
{
    private int cost = 1;//this is how much the card will give me

    private GameManager gm;//declared to gm so we can call to it

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();//look in the game for a game object with the name GameManager
    }

    public void PrintSomething()
    {
        print("You used This Button" + name);//prints to the screen when clicked
        BuyCard();//calls the buy card function
    }

    private void BuyCard()
    {
        gm.money += cost;//when we click the button it gives us the cost of 1
        Destroy(gameObject);
    }
}
