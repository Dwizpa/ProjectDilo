using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWall : MonoBehaviour
{
    public PlayerControl player;
    [SerializeField] GameManager gameManager;

    void OnTriggerEnter2D(Collider2D anotherCollider)
    {
        //Jika objek tersebut bernama "Ball"
        if(anotherCollider.name == "Ball")
        {

            //Tambahkan skor ke pemain
            player.IncrementScore();

            //Jika skor pemain belum mencapai skor maksimal...
            if(player.Score < gameManager.maxScore)
            {
                //...restart game setelah bola mengenai dinding.
                anotherCollider.gameObject.SendMessage("RestartGame", 2.0f, SendMessageOptions.RequireReceiver);
            }
        }
    }
    
}