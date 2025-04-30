using UnityEngine;
using UnityEngine.UI;
public class ThanhMau : MonoBehaviour
{
    public Image healthBarBackground;
    public float luongMauHienTai;
    public float luongMauToiDa;

    public void capNhatThanhMau(float luongMauHienTai, float luongMauToiDa)
    {
        if(healthBarBackground == null)
        {
            Debug.LogError("Khong co mau");
        }
        healthBarBackground.fillAmount = luongMauHienTai / luongMauToiDa;
       
    }
    
}
