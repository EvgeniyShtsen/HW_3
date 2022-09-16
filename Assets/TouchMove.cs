using UnityEngine;

public class TouchMove : MonoBehaviour
{
    public Vector2 mouseVect;
    public Vector2 sumVect;
    public bool needImpulse;
    private Vector2 startPos;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
                startPos = Input.touches[0].position; 
            if (Input.touches[0].phase == TouchPhase.Ended)
            { 
                sumVect = startPos - Input.touches[0].position;
            }
        }
    }

    void FixedUpdate()
    {
        if (needImpulse)
        {
            Vector3 forceVect = new Vector3(sumVect.x, sumVect.y);
            GetComponent<Rigidbody2D>().AddForce(-forceVect, ForceMode2D.Impulse);
            needImpulse = false;
        }
    }
}