using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class msgVitoria : MonoBehaviour
{
    public TextMeshProUGUI hud, msgVitoria;
    public int restantes;
    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectOfType<Moeda>().Length;

        hud.text = $"Moedas restantes: {restante}";
    }

    // Update is called once per frame
    void Update()
    {
        msgVitoria.text = "Parabéns!";
    }
}
