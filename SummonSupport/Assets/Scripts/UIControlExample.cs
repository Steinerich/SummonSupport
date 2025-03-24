using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIControlExample : MonoBehaviour
{


    [SerializeField] UIDocument uiDoc;
    private VisualElement uiRoot;
    private ProgressBar healthBar;
    private ProgressBar powerBar;
    private Dictionary<string, Button> abilityButtons;

    void Start()
    {
        uiRoot = uiDoc.rootVisualElement;

        healthBar = uiRoot.Q<ProgressBar>("HealthBar");
        powerBar = uiRoot.Q<ProgressBar>("PowerBar");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        healthBar.value -= 1; // will practically be at zero in the blink of an eye
        powerBar.value -= 1; // will practically be at zero in the blink of an eye
    }
}
