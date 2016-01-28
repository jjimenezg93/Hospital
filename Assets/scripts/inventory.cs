using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class inventory : MonoBehaviour {

    public List<GameObject> objects;

    public void AddObject(GameObject obj) {
        objects.Add(obj);
    }

    public bool IsObject(GameObject obj) {
        int i = 0;
        while (i <= objects.Count) {
            if (objects[i].name == obj.name) {
                return true;
            }
            i++;
        }
        return false;
    }
}
