using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using UnityEngine.SceneManagement;

public class DataLog : MonoBehaviour
{
   public static List<string> shapeNames = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        string partiDate = PartDate.pDate;
        string partiID = PartInfo.pID;
        int i = 0;
        string path = "Version" + DropDown.version + "/ResultsLog/TaskResults_" + partiID + ".csv";
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("ID: " + partiID + ",DATE: " + partiDate + "\n");
        writer.WriteLine("Object,RetraceX_1,RetraceY_1,RetraceX_2,RetraceY_2,RetraceX_3,RetraceY_3,RetraceX Key,RetraceY Key,Question1 Response,Question1 Key,Question2 Response,Question2 Key,PuzzleX Response,PuzzleX Key,PuzzleY Response,PuzzleY Key");
        while(i < shapeNames.Count)
        {
            writer.Write(shapeNames[i] + ",");
            writer.Write(MoveObject.retraceX1[i] + ",");
            writer.Write(MoveObject.retraceY1[i] + "," );
            writer.Write(MoveObject2.retraceX2[i] + ",");
            writer.Write(MoveObject2.retraceY2[i] + ",");
            writer.Write(MoveObject3.retraceX3[i] + ",");
            writer.Write(MoveObject3.retraceY3[i] + ",");
            writer.Write(DropDown.mapObjectXs[i] +  ",");
            writer.Write(DropDown.mapObjectYs[i] + ",");
            if (Responses.selected1.Equals(shapeNames[i]))
            {
                writer.Write("1,");
            } else {
                writer.Write("0,");
            }
            if ("chesspiece".Equals(shapeNames[i]))
            {
                writer.Write("1,");
            } else {
                writer.Write("0,");
            }
            if (Responses2.selected2.Equals(shapeNames[i]))
            {
                writer.Write("1,");
            } else {
                writer.Write("0,");
            }
            if ("star".Equals(shapeNames[i]))
            {
                writer.Write("1,");
            } else {
                writer.Write("0,");
            }
            //output the puzzle task response and puzzle task key
            writer.Write(Drop.dropX[i] + ",");
            writer.Write(DropDown.puzzleKeyXs[i] +  ",");
            writer.Write(Drop.dropY[i] + ",");
            writer.Write(DropDown.puzzleKeyYs[i] +  ",");
            i++;
            writer.Write("\n");
        }
        writer.Close();       
    }     
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)){
            Application.Quit();
        }
    }
}
