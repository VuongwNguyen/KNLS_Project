using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float dichuyen;
    public float tocdo = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // di chuyen
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            dichuyen = -1;
        }else if  (Input.GetKey(KeyCode.RightArrow))
        {
            dichuyen = 1;
        }
        else dichuyen = 0;
        transform.Translate(Vector3.right * tocdo * dichuyen*Time.deltaTime);
    }
}
