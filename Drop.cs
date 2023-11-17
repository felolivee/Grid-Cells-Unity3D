using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class Drop : MonoBehaviour
{
    [SerializeField]
    private Canvas canvas;
    public Transform picture;
    public static float[] dropX = new float[6]; 
    public static float[] dropY = new float[6]; 
    public void DropHandler(BaseEventData data)
    {
        PointerEventData pointerData = (PointerEventData)data;

        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform)canvas.transform, pointerData.position,
            canvas.worldCamera, out position
        );

        transform.position = canvas.transform.TransformPoint(position);
         if(picture.name.Equals(DataLog.shapeNames[0]))
        {
            dropX[0] = (float) Math.Round(picture.localPosition.x,1);
            dropY[0] = (float) Math.Round(picture.localPosition.y,1);
        } else if(picture.name.Equals(DataLog.shapeNames[1]))
        {
            dropX[1] = (float) Math.Round(picture.localPosition.x,1);
            dropY[1] = (float) Math.Round(picture.localPosition.y,1);
        } else if(picture.name.Equals(DataLog.shapeNames[2]))
        {
            dropX[2] = (float) Math.Round(picture.localPosition.x,1);
            dropY[2] = (float) Math.Round(picture.localPosition.y,1);
        } else if(picture.name.Equals(DataLog.shapeNames[3]))
        {
            dropX[3] = (float) Math.Round(picture.localPosition.x,1);
            dropY[3] = (float) Math.Round(picture.localPosition.y,1);
        } else if(picture.name.Equals(DataLog.shapeNames[4]))
        {
            dropX[4] = (float) Math.Round(picture.localPosition.x,1);
            dropY[4] = (float) Math.Round(picture.localPosition.y,1);
        } else if(picture.name.Equals(DataLog.shapeNames[5]))
        {
            dropX[5] = (float) Math.Round(picture.localPosition.x,1);
            dropY[5] = (float) Math.Round(picture.localPosition.y,1);
        } 
    }
}
