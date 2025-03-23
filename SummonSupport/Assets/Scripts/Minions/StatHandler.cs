using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class StatHandler : MonoBehaviour
{
    public int hitPoints = 0;
    public void AddHealth(int addValue)
    {
        hitPoints += addValue;
    }
    public int GetHealth()
    {
        return hitPoints;
    }
}