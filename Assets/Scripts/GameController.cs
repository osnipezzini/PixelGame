using UnityEngine;

public class GameController : MonoBehaviour
{
    public int TotalPoints;
    public string Name;
    // Start is called before the first frame update
    public GameController Instance { get; private set; }
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
