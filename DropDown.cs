using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDown : MonoBehaviour
{
    public static List<double> mapObjectXs;
    public static List<double> mapObjectYs;
    public static List<double> puzzleKeyXs;
    public static List<double> puzzleKeyYs;
    public static int version;
    public void HandleInputData(int val) {
        if (val == 0) {
            //
        }
        if (val == 1) {
            mapObjectXs = new List<double>() {-12.2483,16.7014,-3.1598,-12.2483,3.7801,16.6701};
            mapObjectYs = new List<double>() {-2.9403,-14.1475,15.3258,8.4538,1.2575,-1.2575};
            puzzleKeyXs = new List<double>() {-292,-146,-532,-441,-347,-314};
            puzzleKeyYs = new List<double>() {-11.55,389.55,127.55,10.55,220.55,389.55};

            version = 1;
        }
        if (val == 2) {
            mapObjectXs = new List<double>() {-15.2037,14.5834,-3.0251,14.5834,3.1729,-3.425};
            mapObjectYs = new List<double>() {4.5205,6.5556,6.2924,-5.7133,-10.2217,4.5205};
            puzzleKeyXs = new List<double>() {-390,-416,-540,-256,-198,-391};
            puzzleKeyYs = new List<double>() {-26.45,363.55,133.55,363.55,212.55,127.55};
            version = 2;
        }
        if (val == 3) {
            mapObjectXs = new List<double>() {-16.7476,5.8645,-16.8322,-4.9867,16.5859,5.8645};
            mapObjectYs = new List<double>() {-10.9893,-1.1977,0.7713,-10.9893,-9.3801,12.2893};
            puzzleKeyXs = new List<double>() {-188,-315,-342,-187,-208,-492};
            puzzleKeyYs = new List<double>() {-45.45,248.55,-49.45,106.55,387.55,244.55};
            version = 3;
        }
        if (val == 4) {
            mapObjectXs = new List<double>() {-14.2164,3.3939,-3.3616,15.8459,-14.2164,3.3548};
            mapObjectYs = new List<double>() {-10.5894,-2.6778,10.5656,-2.6778,2.7729,9.7741};
            puzzleKeyXs = new List<double>() {-193,-295,-465,-295,-367,-459};
            puzzleKeyYs = new List<double>() {-13.95,216.05,129.05,380.05,-13.95,217.05};
            version = 4;
        }
        if (val == 5) {
            mapObjectXs = new List<double>() {6.2945,-3.7892,-6.8865,5.0879,-6.8865,5.0879};
            mapObjectYs = new List<double>() {-30.7199,22.4238,-30.6226,3.7405,-17.4413,15.191};
            puzzleKeyXs = new List<double>() {-36,-547,-37,-365,-164,-478};
            puzzleKeyYs = new List<double>() {232.55,135.55,105.55,220.55,106.55,220.55};
            version = 5;
        }
        if (val == 6) {
            mapObjectXs = new List<double>() {2.6014,3.8521,-10.954,-5.0666,-5.0666,2.6014};
            mapObjectYs = new List<double>() {-32.7756,21.3581,-18.0834,3.4648,14.6342,-19.1763};
            puzzleKeyXs = new List<double>() {-16,-536,-157,-366,-473,-147};
            puzzleKeyYs = new List<double>() {196.55,209.55,67.55,123.55,123.5,196.55};
            version = 6;
        }
        if (val == 7) {
            mapObjectXs = new List<double>() {7.6105,-5.01,7.6105,-5.01,-9.4299,3.6769};
            mapObjectYs = new List<double>() {-25.0656,3.2624,-7.515,14.4406,-29.2667,21.4722};
            puzzleKeyXs = new List<double>() {-90,-362,-258,-469,-49,-537};
            puzzleKeyYs = new List<double>() {245.05,125.05,245.05,127.05,81.05,207.05};
            version = 7;
        }
        if (val == 8) {
            mapObjectXs = new List<double>() {9.3837,5.057,-6.1578,-4.0191,-6.1578,5.057};
            mapObjectYs = new List<double>() {-32.4779,14.6705,-32.1788,21.218,-16.6344,3.4793};
            puzzleKeyXs = new List<double>() {-19,-471,-22,-535,-170,-365};
            puzzleKeyYs = new List<double>() {262.05,220.05,112.05,133.05,112.05,220.05};
            version = 8;
        }
        
    }
}


