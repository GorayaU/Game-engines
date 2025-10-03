using UnityEngine;

public class Move : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.Translate(Vector3.left);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.Translate(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.Translate(Vector3.up);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            this.transform.Translate(Vector3.down);
        }
    }
}
