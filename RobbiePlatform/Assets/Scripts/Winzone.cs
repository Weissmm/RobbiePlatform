using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winzone : MonoBehaviour
{
    int playLayer;
    // Start is called before the first frame update
    void Start()
    {
        playLayer=LayerMask.NameToLayer("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.layer==playLayer){
            Debug.Log("Player win!");
        }
        GameManager.PlayerWon();
    }
   
}
