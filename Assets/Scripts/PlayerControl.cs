using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 8f;

    // Update is called once per frame
    void Update()
    {
        // Horizontal: A/D
        float input = Input.GetAxisRaw("Horizontal"); // -1, 0, 1
        Vector3 pos = transform.position;
        pos.x += speed * input * Time.deltaTime;
        transform.position = pos;
    }
}
