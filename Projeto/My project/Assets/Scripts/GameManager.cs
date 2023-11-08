using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI hud, msgVitoria;
    public int restantes;
    public AudioClip clipMoeda, clipVitoria;

    private AudioSource source;


    void Start()
    {
        TryGetComponent(out source);

        restantes = FindObjectsOfType<Moeda>().Length;

        hud.text = $"Moedas Restantes: {restantes}";
    }

    public void SubtrairMoedas(int valor)
    {
        restantes -= valor;
        hud.text = $"Moedas Restantes: {restantes}";
        source.PlayOneShot(clipMoeda);

        if(restantes <= 0)
        {
            msgVitoria.text = "Parabéns!";
            source.Stop();
            source.PlayOneShot(clipVitoria);
        }
    }

    void Update()
    {
        
    }
}
