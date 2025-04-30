using UnityEngine;


public class CharacterHP : MonoBehaviour
{
    public ThanhMau heal;
    public float luongMauHienTai;
    public float luongMauToiDa  = 10;

    public void Start()
    {
        luongMauHienTai = luongMauToiDa;
        heal.capNhatThanhMau(luongMauHienTai, luongMauToiDa);
    }

    public void OnMouseDown()
    {
        luongMauHienTai = luongMauHienTai - 2;
        heal.capNhatThanhMau(luongMauHienTai, luongMauToiDa);   
    }
}
