using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;


public class StatHandler : MonoBehaviour
{
    public int hitPoints = 50;
    private UnityEngine.UI.Slider HealthBar;
    public void AddHealth(int addValue)
    {
        hitPoints += addValue;
        HealthBar.value = hitPoints;
    }
    public int GetHealth()
    {
        return hitPoints;
    }
    public void SetHealthBar(UnityEngine.UI.Slider NewHealthBar)
    {
        HealthBar = NewHealthBar;
        HealthBar.value = hitPoints;
    }
}