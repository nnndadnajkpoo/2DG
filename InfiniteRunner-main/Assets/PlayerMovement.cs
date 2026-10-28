
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float laneDistance = 2f;
    public float laneChangeSpeed = 10f;

    private int currentLane = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && currentLane > -1)
        {
            currentLane--;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && currentLane < 1)
        {
            currentLane++;
        }

        Vector3 targetPosition = new Vector3(
            currentLane * laneDistance,
            transform.position.y,
            transform.position.z
        );

        transform.position = Vector3.Lerp(
            transform.position,
            targetPosition,
            laneChangeSpeed * Time.deltaTime
        );
    }
}
