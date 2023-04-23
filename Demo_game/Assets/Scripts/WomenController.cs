// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class WomenController : MonoBehaviour
// {
//     // Start is called before the first frame update
//     public Vector3 moveVector;
//     private bool isDead = true;
//     private float gravity = 9.8f; //trọng trường
//
//     private CharacterController women; //nhân vật
//     [SerializeField] protected float speed = 5f; //tốc độ
//     private float verticalVelocity = 0f; // vận tốc ngang
//     private float animTime = 2f;
//
//     private void Awake()
//     {
//         women = GetComponent<CharacterController>(); //ánh xạ
//
//     }
//
//     void Start()
//     {
//
//     }
//
//     // Update is called once per frame
//     void Update()
//     {
//         if (Time.time < animTime)
//         {
//             women.Move(Vector3.forward * speed * Time.deltaTime); //di chuyển trục Z
//
//         }
//         else
//         {
//             if (!isDead) // khi nv chưa chết 
//             {
//                 
//                 
//                 if (Input.GetKeyDown(KeyCode.UpArrow)) // Nhấn phím mũi tên
//                 {
//                     moveVector.y = speed; //đi ngược lại trọng trường
//                 }
//
//                 if (women.isGrounded) //khi va chạm mặt sàn
//                 {
//                     verticalVelocity = -0.5f;
//                 }
//                 else //khi không va chạm mặt sàn
//                 {
//                     // verticalVelocity = verticalVelocity - (gravity * Time.deltaTime);
//                     verticalVelocity -= gravity * Time.deltaTime;
//                 }
//
//                 //di chuyển theo từng trục
//                 moveVector.z = Input.GetAxis("Horizontal") * 10;
//                 moveVector.y = verticalVelocity;
//                 moveVector.z = speed;
//                 women.Move(moveVector * Time.deltaTime); //di chuyển tổng hợp
//             }
//         }
//     }
//
//     //thay đổi tốc độ
//     public void setSpeed(float l)
//     {
//         speed += l;
//     }
//     //kiểm tra nhân vật chết
//     public void Dead()
//     {
//         isDead = true;
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunning : MonoBehaviour
{
    private bool isDead = false;//kiem tra trang thai chet
    private float YVelocity = 0f;//van toc theo truc y
    private float gravity = 9.8f;//gia toc
    private Vector3 moveVector;//vec to di chuyen
    private CharacterController player;//nhan vat
    private float animTime = 2f;//thoi gian animation
    
    [SerializeField] protected float speed = 5f;
    
    private void Awake()//khởi tạo các biến
    {
        player = GetComponent<CharacterController>();//anh xa
    }
    void Start()
    {
        
    }

    void Update()
    {
        if(Time.time<animTime)
        {
            player.Move(Vector3.forward * speed * Time.deltaTime);//di chuyen
        }
        else
        {
            if(isDead==false)//neu nhan vat khong chet
            {
                //kiem tra mat san
                if (player.isGrounded)
                {
                    YVelocity = -0.5f;
                    //YVelocity -= gravity * Time.deltaTime;
                }
                else //neu k phai san
                {
                    YVelocity -= gravity * Time.deltaTime;
                }
                //chuyen dong tung thanh phan
                moveVector.z = Input.GetAxis("Horizontal") * speed;
                //moveVector.y = YVelocity;
                //moveVector.y = Input.GetAxisRaw("Vertical") * -YVelocity;
                moveVector.z = speed;
                if (Input.GetKey(KeyCode.Space))
                {
                    moveVector.y = -YVelocity;
                }
                else
                {
                    moveVector.y = YVelocity;
                }

                if (Input.GetKey(KeyCode.RightArrow))
                {
                    moveVector.x = 6;
                }
                
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    moveVector.x = -6;
                }

                if (Input.GetKeyUp(KeyCode.RightArrow))
                {
                    moveVector.x = 0;
                }
                
                if (Input.GetKeyUp(KeyCode.LeftArrow))
                {
                    moveVector.x = 0;
                }
              
                //tong hoep
                player.Move(moveVector * Time.deltaTime);
            }
        }
    }
    
    public void SetSpeed(float s)//ham thay doi toc do
    {
        speed += s;
    }
    internal void Dead()//kiem tra trang thai chet
    {
        isDead = true;
    }
}

