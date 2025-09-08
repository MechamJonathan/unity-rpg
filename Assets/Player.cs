using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;
    public int age = 25;
    public int characterLevel = 80;
    public float moveSpeed = 2.5f;
    public bool gameOver = false;

    public int currentHp = 100;

    private void Awake()
    {
        GetPlayerInfo();
    }

    private void Start()
    {
        TakeDamage(25);
    }

    private void Update()
    {

    }

    private void GetPlayerInfo()
    {
        Debug.Log("Player name is :" + playerName);
        Debug.Log("Player age is :" + age);
        Debug.Log("Player level is :" + characterLevel);
    }

    private void TakeDamage(int damage)
    {
        currentHp -= damage;
    }
    
}
