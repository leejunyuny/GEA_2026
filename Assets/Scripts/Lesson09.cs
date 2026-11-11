using UnityEngine;

public class Lesson09 : MonoBehaviour
{
    [ContextMenu("오버플로")]
    void Overflow()
    {
        int gold = int.MaxValue;
        Debug.Log(gold);

        gold = gold + 1;
        Debug.Log(gold);

        byte red = 255;
        red++;
        Debug.Log(red);
    }
    [ContextMenu("정밀도")]
    void Precision()
    {
        double d = 0.1 + 0.2;
        Debug.Log(d == 0.3);

        float big = 16777216f;
        float sum = big + 1f;
        Debug.Log(sum == big);

        float half = 1 / 2;
        Debug.Log(half);
    }
    [ContextMenu("자료형")]
    void Types()
    {
        int level = 30;
        byte red = 255;
        char grade = 'S';
        float speed = 5.5f;
        bool isHigh = level >= 10;

        Debug.Log(level + " " + red + " " + grade);
        Debug.Log(speed + " " + isHigh);
    }
    [ContextMenu("예측 2")]
    void Predict2()
    {
        int hp = 7;
        int maxHp = 10;

        Debug.Log(hp / maxHp);
        Debug.Log((float)hp / maxHp);
        Debug.Log(hp / 2);
        Debug.Log(hp / 2f);
        Debug.Log(hp % 2);
    }
}