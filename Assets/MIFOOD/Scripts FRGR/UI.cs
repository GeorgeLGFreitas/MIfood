using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text health;
    public Text vidas;
    // Start is called before the first frame update
    void Start()
    {
        health.text = ""+HealthSystemAttribute.health;
        vidas.text = "" + GameController.vidas;
    }

    // Update is called once per frame
    void Update()
    {
        health.text = "" + HealthSystemAttribute.health;
        if (GameController.vidas==0)
        {
            gameObject.SetActive(false);
        }
        vidas.text = "" + GameController.vidas;
    }
}
