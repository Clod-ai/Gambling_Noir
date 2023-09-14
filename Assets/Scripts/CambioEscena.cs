using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{

    private float timerValue = 10;

    private void Update()
    {
        timerValue -= Time.deltaTime;

        if (timerValue < 0)
        {
            SceneManager.LoadScene("MesaPoker");
        }
    }
}

