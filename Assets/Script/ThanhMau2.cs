using UnityEngine;
using UnityEngine.UI;

public class ThanhMau2 : MonoBehaviour
{
    public Image _thanhMau2;
    public float luongMauHienTai = 10;
    public float luongMauToiDa = 10;

    public void capNhatThanhMau(float luongMauHienTai, float luongMauToiDa)
    {
        _thanhMau2.fillAmount = luongMauHienTai / luongMauToiDa;
    }

}
