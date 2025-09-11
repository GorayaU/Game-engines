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
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            this.transform.Translate(Vector3.down);
        }
        
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Destroy(hit.transform.gameObject);
            Debug.DrawLine(transform.position, hit.transform.position, Color.red);
            Debug.Log("You Win");
        }
        
    }
}
