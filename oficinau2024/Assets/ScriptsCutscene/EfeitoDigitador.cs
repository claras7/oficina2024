using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class NewBehaviourScript : MonoBehaviour
{
    private TextMeshProUGUI componenteTexto;
    private AudioSource _audioSorce;
    private string mensagemOriginal;
    public bool imprimindo;

    private void Awake()
    {
        TryGetComponent(out componenteTexto);
        TryGetComponent(out _audioSorce);
        mensagemOriginal = componenteTexto.text;
        componenteTexto.text = "";

    }
    private void OnEnable()
    {

    }
    private void OnDisable()
    {
        componenteTexto.text = mensagemOriginal;

    }

    public void ImprimirMensagem(string mensagem)
    {

    }

    IEnumerator LetraPorLetra(string mensagem)
    {
        string msg = "";
        foreach (var letra in mensagem)
        {
            msg += letra;
            componenteTexto.text = msg;
            _audioSorce.Play();
            yield return new WaitForSeconds(0.2f);

        }
        
    }
}
