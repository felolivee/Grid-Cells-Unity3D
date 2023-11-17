using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class Responses : MonoBehaviour
{
    [SerializeField]
    private Canvas canvas;
    public Transform picture;
    public static string selected1;

    public void NameReturn(BaseEventData data)
    {
         selected1 = picture.name;
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
