using UnityEngine;

public class TouchMove : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0)
            Swipe();
    }
    void Swipe()
    {
        Vector2 delta = Input.GetTouch(0).deltaPosition;

        if ((Mathf.Abs(delta.x)) > (Mathf.Abs(delta.y)))
        {
            if (delta.x > 0)
            {
                transform.Rotate(0, 5f, 0);
            }
            else
            {
                transform.Rotate(0, -5f, 0);
            }
        }
    }
}