using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float damage = 1f;
    public string targetTag = "Enemy";
    public float destroyTime = 3f;

    void Start()
    {
        // 3초 뒤 자동 파괴
        Destroy(gameObject, destroyTime);
    }

    void Update()
    {
        // 앞으로 이동
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // 맞은 대상의 태그가 Enemy인지 확인
        if (other.CompareTag(targetTag))
        {
            // 대상의 Health 스크립트를 가져와서 데미지 주기
            Health health = other.GetComponent<Health>();
            if (health != null)
            {
                health.TakeDamage(damage);
            }

            // 총알 자신 삭제
            Destroy(gameObject);
        }
    }
}