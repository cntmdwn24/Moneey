using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public int fishTypeIndex;
    private float speed;
    private Vector2 direction;
    private Transform objectTransform;

private void Start()
{
    Initialize(3f); // 나중에 지우기
}

    private void Awake()
    {
        objectTransform = GetComponent<Transform>();

        if (objectTransform == null)
        {
            Debug.LogError("Transform component is missing from this GameObject.");
            enabled = false;
        }
    }

    public void Initialize(float fishSpeed)
    {
        speed = fishSpeed;
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        UpdateRotation();
        InvokeRepeating("ChangeDirection", 1f, Random.Range(1f, 3f));
    }

    void Update()
    {
        if (objectTransform == null) return;

        objectTransform.position += (Vector3)(direction * speed * Time.deltaTime);
    }

    void ChangeDirection()
    {
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        UpdateRotation();
    }

    void UpdateRotation()
    {
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        objectTransform.rotation = Quaternion.Euler(0, 0, angle);
    }
}