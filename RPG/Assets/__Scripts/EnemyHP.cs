using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyHP : MonoBehaviour
{
    public int enemyHP;
    private int currentHP;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = enemyHP;
    }
    // Update is called once per frame
    void Update()
    {
        if (currentHP <= 0)
        {
            Destroy(transform.parent.gameObject);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHP -= damage;
    }
}