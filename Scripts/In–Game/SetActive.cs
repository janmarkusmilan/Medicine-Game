using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SetActive : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> objects;

    [SerializeField]
    private List<GameObject> objects2;

    public void DeactivateObjects()
    {
        foreach (var obj in objects)
            obj.SetActive(false);
    }

    public void DeactivateObjects2()
    {
        foreach (var obj2 in objects2)
            obj2.SetActive(false);
    }
}
