using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChildren : MonoBehaviour
{
    public Transform parent;
    public static List<GameObject> childObjects = new List<GameObject>();
    public static List<float> xs = new List<float>(6);
    public static List<float> ys = new List<float>(6);
    public static List<float> distances = new List<float>(6);
    public static string closest;
    public static string farthest;

    public List<int> objorder = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        
    foreach (Transform child in parent)
    {
        childObjects.Add(child.gameObject);
        DataLog.shapeNames.Add(child.gameObject.name.Substring(1));
    }
    int i = 0;
    float dist = 0;
    float minDist = 100000000000000;
    float maxDist = 0;
    while (i < 5) 
    {
        dist = Vector3.Distance(childObjects[5].transform.position,childObjects[i].transform.position);
        distances.Add(Vector3.Distance(childObjects[5].transform.position,childObjects[i].transform.position));
        if (dist < minDist)
        {
            minDist = dist;
        }
        if (dist > maxDist)
        {
            maxDist = dist;
        }
        i++;
    }
    closest = childObjects[distances.IndexOf(minDist)].name.Substring(1);
    farthest = childObjects[distances.IndexOf(maxDist)].name.Substring(1);

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void posStamp()
    {
       foreach (Transform child in parent)
    {
        Debug.Log(child.gameObject.activeSelf);
    } 
    }
}
