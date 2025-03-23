using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class AbilityHandler : MonoBehaviour
{
    MinionHandler minionHandler;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        minionHandler = GameObject.FindGameObjectWithTag("Player").GetComponent<MinionHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInputs();
    }
    private void CheckInputs()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SmolHeal();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            BigHeal();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            SummonGreen();
        }
    }
    private RaycastHit2D GetTargetOnClick()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
        return hit;
        
    }
    private void Heal(int value)
    {
        RaycastHit2D hit = GetTargetOnClick();
        if (hit.collider != null)
        {
            StatHandler targetScript = hit.collider.GetComponent<StatHandler>();
            if (targetScript != null)
            {
                targetScript.AddHealth(value);
            }
        }
        
    }
    private void SmolHeal()
    {
        Heal(10);
    }
    private void BigHeal()
    {
        Heal(20);
    }
    private void SummonGreen()
    {
        minionHandler.SpawnMinion();
    }

    
}
