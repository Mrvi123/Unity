using UnityEngine;
using UnityEngine.UI;//chèn vào để dùng UI trong Unity
public class CharacterHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Slider healthBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
        //Tìm Slider trong các GameObject con nếu healthBar chưa được gán trực tiếp
        if (healthBar != null)
        {
            healthBar = GetComponentInChildren<Slider>();
        }
        UpdateHealthBar();
    }

    //Hàm kiểm tra trạng thái thanh máu (check status)
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth < 0)
        {
            currentHealth = 0;
            Die();
        }
        UpdateHealthBar();
    }

    //Hàm hồi máu cho nhân vật
    public void Heal(int healAmount)
    {
        currentHealth += healAmount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        UpdateHealthBar();
    }

    //Hàm cập nhật trạng thái thanh máu
    void UpdateHealthBar()
    {
        if (healthBar != null)
        {
            healthBar.value = currentHealth;
            healthBar.maxValue = maxHealth;
            //Đảm bảo maxValue luôn được cập nhật nếu có thay đổi
        }
        else
        {
            Debug.LogError("Khong tim thay HealthBar!");
        }
    } 

    void Die()
        {
            Debug.Log(healthBar.name + "da chet");
            //Thực hiện các hành động khi nhân vật chết (ví dụ: vô hiệu hóa, phát animation chết,...)
        }
    // Update is called once per frame
    void Update()
    {
        
    }
}
