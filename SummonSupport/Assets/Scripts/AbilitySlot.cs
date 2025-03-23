using System;
using UnityEngine;
using TMPro;

public class AbilitySlot : MonoBehaviour
{
    public String ability;
    public String keybinding;
    public TextMeshProUGUI guiKeybinding;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (keybinding != null)
        {
            guiKeybinding.SetText(keybinding);
        }
        else
        {
            guiKeybinding.SetText("");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
