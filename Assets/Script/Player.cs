using UnityEngine;

public class Player : MonoBehaviour
{
    public ThanhMau2 thanhMau2;
    public float luongMauHienTai;
    public float luongMauToiDa = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        luongMauHienTai = luongMauToiDa;
        thanhMau2.capNhatThanhMau(luongMauHienTai, luongMauToiDa);
    }

    private void OnMouseDown()
    {
        luongMauHienTai = luongMauHienTai - 2;
        thanhMau2.capNhatThanhMau(luongMauHienTai, luongMauToiDa);
    }
}
