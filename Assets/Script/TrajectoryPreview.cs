using UnityEngine;

public class TrajectoryPreview : MonoBehaviour
{
    [Header("References")]
    public PlayerController player;
    public Rigidbody2D playerRb;

    [Header("Trajectory")]
    public GameObject dotPrefab;
    public int numberOfDots = 25;
    public float timeStep = 0.1f;

    private GameObject[] dots;

    private void Start()
    {
        dots = new GameObject[numberOfDots];

        for (int i = 0; i < numberOfDots; i++)
        {
            dots[i] = Instantiate(dotPrefab);

            dots[i].transform.localScale =
                Vector3.one * 0.25f;

            dots[i].SetActive(false);
        }
    }

    private void Update()
    {
        if (player == null || playerRb == null)
            return;

        if (player.IsDragging)
        {
            DrawTrajectory();
        }
        else
        {
            HideTrajectory();
        }
    }

    private void DrawTrajectory()
    {
        Vector2 velocity =
            player.GetPredictedVelocity();

        for (int i = 0; i < numberOfDots; i++)
        {
            float t = i * timeStep;

            Vector2 position =
                (Vector2)player.transform.position +
                velocity * t +
                0.5f *
                Physics2D.gravity *
                playerRb.gravityScale *
                t * t;

            dots[i].transform.position = position;
            dots[i].SetActive(true);
        }
    }

    private void HideTrajectory()
    {
        for (int i = 0; i < numberOfDots; i++)
        {
            dots[i].SetActive(false);
        }
    }
}