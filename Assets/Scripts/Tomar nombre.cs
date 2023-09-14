using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tomarnombre : MonoBehaviour
{
    public InputField inputName;
    public InputField inputLassName;

    public Text TextoNombre;
    public Text TextoApellido;
    public GameObject BotonSiguiente;

    private void Awake()
    {
        BotonSiguiente.SetActive(false);
    }
    public void Update()
    {
        if (TextoNombre.text.Length < 1 && TextoApellido.text.Length < 1)
        {
            BotonSiguiente.SetActive(false);
        }

        if (TextoNombre.text.Length > 1 || TextoApellido.text.Length > 1)
        {
            BotonSiguiente.SetActive(true);
        }
    }

    public void aceptar()
    {
        PlayerPrefs.SetString("nombre1",inputName.text);
        PlayerPrefs.SetString("nombre2", inputLassName.text);
        SceneManager.LoadScene("Intro");
    }
}
