using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera camFront;
    public Camera camBack;
    public Camera camLeft;
    public Camera camRight;

    private void Start()
    {
        camFront.enabled = true;
        camBack.enabled = false;
        camLeft.enabled = false;
        camRight.enabled = false;
    }

    public void SwitchFront()
    {
        camFront.enabled = true;
        camBack.enabled = false;
        camLeft.enabled = false;
        camRight.enabled = false;
    }
    public void SwitchBack()
    {
        camFront.enabled = false;
        camBack.enabled = true;
        camLeft.enabled = false;
        camRight.enabled = false;
    }
    public void SwitchLeft()
    {
        camFront.enabled = false;
        camBack.enabled = false;
        camLeft.enabled = true;
        camRight.enabled = false;
    }
    public void SwitchRight()
    {
        camFront.enabled = false;
        camBack.enabled = false;
        camLeft.enabled = false;
        camRight.enabled = true;
    }
}