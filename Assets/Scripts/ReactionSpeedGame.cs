using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ReactionTest : MonoBehaviour
{
    public TextMeshProUGUI reactionTimeText;
    public TextMeshProUGUI finshreactionTimeText;
    private float startTime;      
    private bool isReactionStarted;
    public Image image;
    [SerializeField] private GameObject finsh;

    void Start()
    {
        image.color = Color.red;
        isReactionStarted = false; 
        reactionTimeText.text = "ready...";
        Invoke("StartReaction", Random.Range(2f, 5f));  
    }

    void StartReaction()
    {
        
        reactionTimeText.text = "now!";
        startTime = Time.realtimeSinceStartup; 
        isReactionStarted = true;
        image.color = Color.green;
        
    }

    void Update()
    {
        if (image.color == Color.red && Input.GetMouseButtonDown(0))
        {
            reactionTimeText.text = "not now!";
        }
        
        
        if (isReactionStarted && Input.GetMouseButtonDown(0))  
        {
            finsh.SetActive(true);
            float reactionTime = (Time.realtimeSinceStartup - startTime) * 1000; 
            finshreactionTimeText.text = $"ReactionSpeed: {reactionTime:F2} ms"; 
            isReactionStarted = false; 
        }
    }
}