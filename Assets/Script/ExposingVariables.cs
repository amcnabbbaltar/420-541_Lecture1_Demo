using UnityEngine;
[System.Serializable]
public struct PlayerStats
{
    public int level;

    [SerializeField]
    private float health;

    public PlayerStats(int level, float health)
    {
        this.level = level;
        this.health = health;
    }

    public override string ToString()
    {
        return $"Level: {level}, Health: {health}";
    }
}

public class ExposingVariables : MonoBehaviour
{
    [Header("Public Parameters")]
    public string Name;
    public Vector3 SpawnPoint;

    [Header("Public Serialized Parameters")]
    public PlayerStats publicStats;
    public PlayerStats[] publicStatsArray;

    [Header("Private Serialized Parameters with [SerializedField]")]
    [SerializeField] private PlayerStats privateStats;
    [SerializeField] private PlayerStats[] privateStatsArray;


    void Start()
    {
        Debug.Log("Public: " + publicStats);
        Debug.Log("Private: " + privateStats);
    }
}

