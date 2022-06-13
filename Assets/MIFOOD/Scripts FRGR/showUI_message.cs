using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showUI_message : MonoBehaviour
{
    
    public GameObject mensagemUI;
    public float segundos = 3f;
   
    void Start()
    {
        mensagemUI.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            mensagemUI.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(segundos);
        Destroy(mensagemUI);
        Destroy(gameObject);
       
    }
}
