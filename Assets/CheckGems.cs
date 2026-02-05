using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class CheckGems : MonoBehaviour
{
    [SerializeField] private int numberOfGems;
    private int numberOfGemsInSocket = 0;
    public UnityEvent unlock;
    public void AddGem()

    {
        numberOfGemsInSocket += 1;
        CheckForAllGems();
    }
    private void CheckForAllGems()
    {
        if (numberOfGemsInSocket == numberOfGems)
            unlock.Invoke();
    }
    public void RemoveGem()
    {
        numberOfGemsInSocket -= 1;
    }
}