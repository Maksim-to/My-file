using UnityEngine;

public class MoveCubeUp : MonoBehaviour
{
    private Vector3 originalPosition; 

    public float distance = 1f; 
    private bool isMoved = false; 

    private void Start()
    {
        originalPosition = transform.position; 
    }

    public void MoveUp()
    {
        if (!isMoved)
        {
            transform.Translate(Vector3.up * distance); 
            isMoved = true;
        }
        else
        {
            transform.position = originalPosition; 
            isMoved = false;
        }
    }
}
