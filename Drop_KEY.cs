using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drop_KEY : MonoBehaviour
{
    [SerializeField]
    private Canvas canvas;
    public Transform picture;

    public void DropHandler(BaseEventData data)
    {
        PointerEventData pointerData = (PointerEventData)data;

        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            (RectTransform)canvas.transform, pointerData.position,
            canvas.worldCamera, out position
        );

        transform.position = canvas.transform.TransformPoint(position);

         Debug.Log(transform.localPosition);
    }
}
