using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    public Text ammoText;
    public void UpdateAmmo(int count)
    {
        ammoText.text = " " + count;
    }
}
