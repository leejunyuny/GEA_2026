using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 20f; // 총알이 주는 데미지
    public float lifeTime = 3f;  // 총알이 사라지는 시간

    void Start()
    {
        // 일정 시간이 지나면 총알이 자동으로 파괴됨
        Destroy(gameObject, lifeTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // 부딪힌 오브젝트에 Health 스크립트가 붙어있는지 확인
        Health targetHealth = collision.gameObject.GetComponent<Health>();

        if (targetHealth != null)
        {
            // 체력을 깎는 함수 호출
            targetHealth.TakeDamage(damage);
        }

        // 무엇이든 부딪히면 총알 삭제
        Destroy(gameObject);
    }
}