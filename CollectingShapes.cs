using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using System.Text;
using System.IO;


public class CollectingShapes : MonoBehaviour
{
    public int i = 0;
    public int j = 0;
    public double stamp = 0.1;
    public List<double> hitStampList;
    public List<double> stampList;
    public List<double> posList;
    public Transform parent;
    string partiDate;
    string partiID;
    string path;
    string path2;
    StreamWriter writer;
    StreamWriter writer2;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        partiDate = PartDate.pDate;
        partiID = PartInfo.pID;
        path = "Version" + DropDown.version + "/PositionLog/Pos1_" + partiID + ".csv";
        path2 = "Version" + DropDown.version + "/HitLog/Hit1_" + partiID + ".csv";
        writer = new StreamWriter(path, true);
        writer2 = new StreamWriter(path2, true);
        writer.WriteLine("ID: " + partiID + ",DATE: " + partiDate + "\n");
        writer2.WriteLine("ID: " + partiID + ",DATE: " + partiDate + "\n");
        writer.WriteLine("Time,Location");
        writer2.WriteLine("Time,Object Hit");
        InvokeRepeating("posStamp", 0, .1f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        
        while(i < GetChildren.childObjects.Count)
        {
            try
            {
                stampList.Add(stamp);
                GetChildren.childObjects[i].gameObject.SetActive(false);
                GetChildren.childObjects[i + 1].gameObject.SetActive(true);
              
            }
            catch (ArgumentOutOfRangeException)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            i++;
            break;
        }
    }
    public void ActivateObjects() {
        foreach (Transform child in parent)
    {
        child.gameObject.SetActive(true);
    }
    }

    private void posStamp() {
        if(i < GetChildren.childObjects.Count) {
        writer.WriteLine(Math.Round(stamp,1) + "," + GameObject.Find("First Person Player").transform.position.x + "," + GameObject.Find("First Person Player").transform.position.z);
        stamp = stamp + 0.1;
        } else {
            writer.Close();
            while (j < GetChildren.childObjects.Count) {
                writer2.WriteLine(Math.Round(stampList[j],1) + "," + DataLog.shapeNames[j]);
                j++;
            }
            writer2.Close();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } 
    }
}  
