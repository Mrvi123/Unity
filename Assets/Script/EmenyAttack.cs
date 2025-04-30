using UnityEngine;

public class EnemyBatAttack : MonoBehaviour
{
    //
    [Header("Thiết lập")]
    public GameObject Bat_Attack_0;//Khuôn
    public int numberOfObjectBat_Attack_0 = 10;//Số lượng GameObject
    public Vector3 batattackPosition = new Vector3(5.0f, 5.0f, 0.0f);
    public Vector3 positiononOffset = Vector3.right;//Thay đổi vị trí bằng cách nhân cho 2f
    public float spawnBatAttack = 5f; //Trong bán kính 5 thì tạo dơi bay bay
    public Vector3 spawnBatAttackPosition = new Vector3(2.0f, 5.0f, 2.5f);
    //spawnBatAttackPosition.x = spawnBatAttack;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Spawn();
        SpawnEnemiesInRadius();//Trong bán kính nhiêu đó thì tạo dơi bay bay
    }

    //Hàm tạo con dơi tấn công (Bat_Attack_0)
    public void Spawn()
    {
        if (Bat_Attack_0 == null)
        {
            Debug.LogError("Cảnh báo lỗi rồi, lỗi rồi");
            return;
        }

        for (int i = 0; i < numberOfObjectBat_Attack_0; i++)
        {
            Vector3 currentBatAttackPosition = batattackPosition + (positiononOffset * i);

            //Quaternion q = Quaternion.Euler(currentBatAttackPosition);
            GameObject newObject = Instantiate(Bat_Attack_0, currentBatAttackPosition, Quaternion.identity);
        }

        Debug.Log("Create " + numberOfObjectBat_Attack_0 + " successfully");
    }

    void SpawnEnemiesInRadius()
    {
        if(Bat_Attack_0 == null)
        {
            Debug.Log("Lỗi rùi lỗi rùi");
        }

        for(int i = 0; i < numberOfObjectBat_Attack_0; i++)
        {
            Vector3 randomCircle = Random.insideUnitCircle * spawnBatAttack;
            Vector3 randomSpawnPosition = new Vector3(batattackPosition.x+randomCircle.x, batattackPosition.y+ randomCircle.y,0f);
            Quaternion q1 = Quaternion.Euler(90, 90, 90);
            Quaternion q2 = Quaternion.Inverse(q1);
            GameObject newBat = Instantiate(Bat_Attack_0, randomSpawnPosition, Quaternion.identity);
            //Quaternion q = newBat.transform.rotation;

            // Optional: in ra vị trí từng con
            Debug.Log($"Spawned Bat #{i + 1} at {randomSpawnPosition}");
        }
        Debug.Log("Create "+numberOfObjectBat_Attack_0+" successfully");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
