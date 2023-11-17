using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text;
using System.IO;
using System;

public class MoveObject : MonoBehaviour
{
    public Transform ob1;
    public Transform ob2;
    public Transform ob3;
    public Transform ob4;
    public Transform ob5;
    public Transform ob6;
    
    public static List<GameObject> shapes = new List<GameObject>();
    public  List<int> objorder = new List<int>();
    public static List<float> retraceX1 = new List<float>();
    public static List<float> retraceY1 = new List<float>();
    public static List<string> shapenames = new List<string>();
    public static List<string> objnames = new List<string>();
    public List<double> stampList = new List<double>();
    string partiDate;
    string partiID;
    string path;
    string path2;
    StreamWriter writer;
    public double stamp = 0.1;
    public int j = 0;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        partiDate = PartDate.pDate;
        partiID = PartInfo.pID;
        path = "Version" + DropDown.version + "/PlaceLog/Place1_" + partiID + ".csv";
        writer = new StreamWriter(path, true);
        writer.WriteLine("ID: " + partiID + ",DATE: " + partiDate + "\n");
        writer.WriteLine("Time,Object Placed");
        InvokeRepeating("posStamp", 0, .1f);
    }

    // Update is called once per frame
    void Update()
    {
        int i = 0;
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            ob1.transform.position = new Vector3(GameObject.Find("First Person Player").transform.position.x, 2f, GameObject.Find("First Person Player").transform.position.z);
            if (objorder.Contains(3))
            {
                i = objorder.IndexOf(3);
                writer.WriteLine(Math.Round(stamp,1) + "," + ob1.gameObject.name.Substring(1));
                stampList.Add(stamp);
                retraceX1[i] = ob1.transform.position.x;
                retraceY1[i] = ob1.transform.position.z;
            } else {
                objorder.Add(3);
                objorder.Sort();
                i = objorder.IndexOf(3);
                writer.WriteLine(Math.Round(stamp,1) + "," + ob1.gameObject.name.Substring(1));
                retraceX1.Insert(i,ob1.transform.position.x);
                retraceY1.Insert(i,ob1.transform.position.z);
            }

        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            ob2.transform.position = new Vector3(GameObject.Find("First Person Player").transform.position.x, 1.5f, GameObject.Find("First Person Player").transform.position.z);
            if (objorder.Contains(4))
            {
                i = objorder.IndexOf(4);
                writer.WriteLine(Math.Round(stamp,1) + "," + ob2.gameObject.name.Substring(1));
                retraceX1[i] = ob2.transform.position.x;
                retraceY1[i] = ob2.transform.position.z;
            } else {
                objorder.Add(4);
                objorder.Sort();
                i = objorder.IndexOf(4);
                writer.WriteLine(Math.Round(stamp,1) + "," + ob2.gameObject.name.Substring(1));
                retraceX1.Insert(i,ob2.transform.position.x);
                retraceY1.Insert(i,ob2.transform.position.z);
            }
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            ob3.transform.position =new Vector3(GameObject.Find("First Person Player").transform.position.x, 2f, GameObject.Find("First Person Player").transform.position.z);
            if (objorder.Contains(1))
            {
                i = objorder.IndexOf(1);
                writer.WriteLine(Math.Round(stamp,1) + "," + ob3.gameObject.name.Substring(1));
                retraceX1[i] = ob3.transform.position.x;
                retraceY1[i] = ob3.transform.position.z;
            } else {
                objorder.Add(1);
                objorder.Sort();
                i = objorder.IndexOf(1);
                writer.WriteLine(Math.Round(stamp,1) + "," + ob3.gameObject.name.Substring(1));
                retraceX1.Insert(i,ob3.transform.position.x);
                retraceY1.Insert(i,ob3.transform.position.z);
            }
        }
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            ob4.transform.position = new Vector3(GameObject.Find("First Person Player").transform.position.x, 2f, GameObject.Find("First Person Player").transform.position.z);
            if (objorder.Contains(6))
            {
                i = objorder.IndexOf(6);
                writer.WriteLine(Math.Round(stamp,1) + "," + ob4.gameObject.name.Substring(1));
                retraceX1[i] = ob4.transform.position.x;
                retraceY1[i] = ob4.transform.position.z;
            } else {
                objorder.Add(6);
                objorder.Sort();
                i = objorder.IndexOf(6);
                writer.WriteLine(Math.Round(stamp,1) + "," + ob4.gameObject.name.Substring(1));
                retraceX1.Insert(i,ob4.transform.position.x);
                retraceY1.Insert(i,ob4.transform.position.z);
            }
        }
        if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            ob5.transform.position = new Vector3(GameObject.Find("First Person Player").transform.position.x, 1.5f, GameObject.Find("First Person Player").transform.position.z);
            if (objorder.Contains(5))
            {
                i = objorder.IndexOf(5);
                writer.WriteLine(Math.Round(stamp,1) + "," + ob5.gameObject.name.Substring(1));
                retraceX1[i] = ob5.transform.position.x;
                retraceY1[i] = ob5.transform.position.z;
            } else {
                objorder.Add(5);
                objorder.Sort();
                i = objorder.IndexOf(5);
                writer.WriteLine(Math.Round(stamp,1) + "," + ob5.gameObject.name.Substring(1));
                retraceX1.Insert(i,ob5.transform.position.x);
                retraceY1.Insert(i,ob5.transform.position.z);
            }
        }
        if(Input.GetKeyDown(KeyCode.Alpha6))
        {
            ob6.transform.position = new Vector3(GameObject.Find("First Person Player").transform.position.x, 2f, GameObject.Find("First Person Player").transform.position.z);
            if (objorder.Contains(2))
            {
                i = objorder.IndexOf(2);
                writer.WriteLine(Math.Round(stamp,1) + "," + ob6.gameObject.name.Substring(1));
                retraceX1[i] = ob6.transform.position.x;
                retraceY1[i] = ob6.transform.position.z;
            } else {
                objorder.Add(2);
                objorder.Sort();
                i = objorder.IndexOf(2);
                writer.WriteLine(Math.Round(stamp,1) + "," + ob6.gameObject.name.Substring(1));
                retraceX1.Insert(i,ob6.transform.position.x);
                retraceY1.Insert(i,ob6.transform.position.z);
            }
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(objorder.Count == 6)
            {
                writer.Close();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }

        private void posStamp() {
        stamp = stamp + 0.1;
        } 
      //have to update how to save files  
    }