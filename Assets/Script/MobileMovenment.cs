using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMovenment : MonoBehaviour
{
    private Vector2 touchStartPos;
    private Vector2 touchEndPos;
    private bool isMoving = false;

    public float moveSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Xử lý sự kiện cảm ứng
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    touchStartPos = touch.position;
                    isMoving = true;
                    break;

                case TouchPhase.Moved:
                    touchEndPos = touch.position;
                    break;

                case TouchPhase.Ended:
                    isMoving = false;
                    break;
            }
        }

        // Di chuyển đối tượng nếu đang có cử chỉ di chuyển
        if (isMoving)
        {
            Vector2 touchDelta = (touchEndPos - touchStartPos).normalized;
            Vector3 movement = new Vector3(touchDelta.x, 0, touchDelta.y) * moveSpeed * Time.deltaTime;
            transform.Translate(movement);
        }
    }
}
