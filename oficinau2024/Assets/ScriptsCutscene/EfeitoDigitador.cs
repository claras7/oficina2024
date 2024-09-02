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
    public float tempoentreLetras = 0.08f;

    private void Awake()
    {
        TryGetComponent(out componenteTexto);
        TryGetComponent(out _audioSorce);
        mensagemOriginal = componenteTexto.text;
        componenteTexto.text = "";

    }
    private void OnEnable()
    {
        ImprimirMensagem(mensagemOriginal);
    }
    private void OnDisable()
    {
        componenteTexto.text = mensagemOriginal;
        StopAllCoroutines();
    }

    public void ImprimirMensagem(string mensagem)
    {

        if(gameObject.activeInHierarchy)
        {
            if(imprimindo) return;
            imprimindo = true;
            StartCoroutine(LetraPorLetra(mensagem));
        }
    }

    IEnumerator LetraPorLetra(string mensagem)
    {
        string msg = "";
        foreach (var letra in mensagem)
        {
            msg += letra;
            componenteTexto.text = msg;
            _audioSorce.Play();
            yield return new WaitForSeconds(tempoentreLetras);

        }
        imprimindo = false;
        StopAllCoroutines();
        
    }
}
