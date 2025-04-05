using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "NewTranslation", menuName = "Localization/Translation Data")]
public class InformacionTraduccion : ScriptableObject
{
    public string title;
    public string subtitle;
    public string description;
    public string footer;
    
}
