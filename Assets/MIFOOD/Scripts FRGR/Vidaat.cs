using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidaat : MonoBehaviour
{
    public Slider Barradevida;
    // Start is called before the first frame update
    void Start()
    {
        Barradevida.SetValueWithoutNotify(HealthSystemAttribute.health);
    }

    // Update is called once per frame
    void Update()
    {
        Barradevida.SetValueWithoutNotify(HealthSystemAttribute.health);

    }
}
