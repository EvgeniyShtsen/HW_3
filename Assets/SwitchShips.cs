using UnityEngine;

public class SwitchShips : MonoBehaviour
{
    public GameObject[] objects;
    public int current_object;

    public void NextObject()
    {
        current_object++;

        if (current_object >= objects.Length)
        {
            current_object = objects.Length - 4;
        }
        for (int i = 0; i < objects.Length; i++)
        {
            if (i == current_object)
            {
                objects[i].SetActive(true);
            }
            else
            {
                objects[i].SetActive(false);
            }
        }
    }
    public void BackObject()
    {
        current_object--;

        if (current_object < 0)
        {
            current_object = current_object + 4;
        }
        for (int i = 0; i < objects.Length; i++)
        {
            if (i == current_object)
            {
                objects[i].SetActive(true);
            }
            else
            {
                objects[i].SetActive(false);
            }
        }
    }
}
