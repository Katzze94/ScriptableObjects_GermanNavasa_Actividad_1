using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using System;
public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI oneText;
        public TextMeshProUGUI twoText;

    public TextMeshProUGUI threeText;

   

    public InformacionTraduccion englishTranslation;
    public InformacionTraduccion spanishTranslation;
    public InformacionTraduccion esperantoTranslation;



    public Button buttonEnglish;
    public Button buttonSpanish;
    public Button buttonEsperanto;

    void Start()
    {
        
        buttonEnglish.onClick.AddListener(() => SetLanguage("EN"));
        buttonSpanish.onClick.AddListener(() => SetLanguage("ES"));
        buttonEsperanto.onClick.AddListener(() => SetLanguage("EP"));

        
        SetLanguage("EN");
    }
    public void SetLanguage(string language)
    {
        InformacionTraduccion selected = null;

        switch (language)
        {
            case "EN": selected = englishTranslation; break;
            case "ES": selected = spanishTranslation; break;
            case "EP": selected = esperantoTranslation; break;
        }

        if (selected != null)
        {
            oneText.text = selected.frase;
            twoText.text = selected.frase;
            threeText.text = selected.frase;
            
        }
    }
}