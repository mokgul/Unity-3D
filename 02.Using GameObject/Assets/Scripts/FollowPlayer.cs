using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject plane;
    public float followSpeed = 0.3f;

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(plane.transform);
        float move = Mathf.Abs(Vector3.Distance(this.transform.position, plane.transform.position) * followSpeed);
        this.transform.position =
            Vector3.MoveTowards(this.transform.position, plane.transform.position, move * Time.deltaTime);
    }
}
