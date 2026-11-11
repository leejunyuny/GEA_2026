using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    // 필드 선언 (기본값)
    public int level = 1;
    public int exp = 0;
    public int maxLevel = 10;
    public int maxHp = 100;

    // 경험치 추가 및 레벨업 로직
    public void AddExp(int amount)
    {
        // 이미 만렙이면 경험치 획득 불가, exp는 0 유지
        if (level >= maxLevel)
        {
            exp = 0;
            return;
        }

        exp += amount;
        int requiredExp = level * 100;

        // 경험치가 필요량 이상이면 레벨업
        if (exp >= requiredExp)
        {
            exp -= requiredExp;
            level++;
            maxHp = Mathf.RoundToInt(maxHp * 1.1f);

            // 칭호 결정
            string title = "";
            if (level <= 3) title = "초보";
            else if (level <= 6) title = "숙련";
            else if (level <= 9) title = "베테랑";
            else title = "마스터";

            Debug.Log($"Lv {level} 로 레벨업, exp {exp}, maxHp {maxHp}, {title}");
        }
        else
        {
            Debug.Log($"Lv {level}, exp {exp}");
        }
    }

    // ContextMenu 테스트 메뉴
    [ContextMenu("적 처치")]
    void TestKillEnemy()
    {
        AddExp(70);
    }

    [ContextMenu("보스 처치")]
    void TestKillBoss()
    {
        AddExp(180);
    }
}