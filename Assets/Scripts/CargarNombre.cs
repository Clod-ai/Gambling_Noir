using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CargarNombre : MonoBehaviour
{

    private GameObject nombre1;
    private GameObject nombre2;

    // Start is called before the first frame update
    void Start()
    {
        nombre1 = GameObject.FindGameObjectWithTag("nombre1");
        nombre1.GetComponent<Text>().text = PlayerPrefs.GetString("nombre1");
        nombre2 = GameObject.FindGameObjectWithTag("nombre2");
        nombre2.GetComponent<Text>().text = PlayerPrefs.GetString("nombre2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
