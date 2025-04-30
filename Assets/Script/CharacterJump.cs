using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    [Header("Thiết lập việc nhảy")]
    public float jumpForce = 5f; //Lực nhảy
    public Transform groundCheck; //Transform đánh dấu vị trí kiểm tra mặt đất
    // Đánh dấu để làm gì ? Phải biết vị nào sẽ chạm vào, nếu chạm vào thì làm gì tiếp theo
    // Làm gì tiếp theo thì đó là phát lực, phát lực xong thì nhảy.
    public float groundCheckRadius = 5f; // Bán kính kiểm tra mặt đất
    public LayerMask whatIsGround; // Layer mà bề mặt thuộc về

    private Rigidbody2D rb2D; // Tham chiếu tới Rigidbody component
    private bool isGrounded; // Kiểm tra xem nhân vật có đang chạm mặt đất hay không ?


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        if(rb2D == null)
        {
            Debug.LogError("Rigidbody component không được tìm thấy trên GameObject này!");
            enabled = false; // Vô hiệu hóa script nếu không có Rigidbody. Nó giống như việc nếu không
            // kiểm tra được nhân vật nào chạm mặt đất thì vố hiệu hóa đoạn mã có chức năng nhảy cho
            // nhân vật
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Vì sao cần hàm update này ? Chưa giải thích được
        // Kiểm tra xem nhân vật có đang chạm đất hay không ?
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        // Xử lý input nhảy khi nhấn nút Space và nhân vật đang chạm đất
        if (Input.GetButtonDown("Jump") && isGrounded) 
        {
            // Thêm lực tức thời lên Rigidbody2D  để nhân vật nhảy lên
            rb2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
