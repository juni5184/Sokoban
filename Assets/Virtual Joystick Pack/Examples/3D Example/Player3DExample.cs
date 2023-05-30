using UnityEngine;

public class Player3DExample : MonoBehaviour {

    public float moveSpeed = 3f;
    public Joystick joystick;

    public GameManager gameManager;

    public ButtonClick buttonClick;

	void Update () 
	{

        if (gameManager.isGameOver == true)
        {
            return;
        }

        Vector3 moveVector = (Vector3.right * joystick.Horizontal + Vector3.forward * joystick.Vertical);

        //메뉴 창 켜져 있으면 안 움직이게 하고 싶은데 관성때문에 굴러감ㅜㅜ
        if (buttonClick.menuOn == false)
        {
            if (moveVector != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(moveVector);
                transform.Translate(moveVector * moveSpeed * Time.deltaTime, Space.World);
            }
        }
	}
}