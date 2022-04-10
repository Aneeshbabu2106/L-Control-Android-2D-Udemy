using UnityEngine;

public class Swipe : MonoBehaviour
{
    public GameObject player;

    public float maxTime;
    public float minDis;

    private float startTime;
    private float endTime;

    Vector3 startPos;
    Vector3 endPos;

    private float swipeTime;
    private float swipeDis;

    void Update()
    {
        if (Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                startPos = touch.position;
                startTime = Time.time;
            }
            else if (touch.phase == TouchPhase.Ended)
                
                {
                    endPos = touch.position;
                    endTime = Time.time;

                    swipeDis = (endPos - startPos).magnitude;
                    swipeTime = endTime - startTime;

                    if(swipeDis > minDis && swipeTime < maxTime ){
                        swipe();
                    }
                }
            }  
    }
    public void swipe()
            {
                Vector3 distance = endPos - startPos;
                if(Mathf.Abs(distance.x) > Mathf.Abs(distance.y)){
                    Debug.Log(" horizontal");
                }
                else if (Mathf.Abs(distance.x) < Mathf.Abs(distance.y)){
                    Debug.Log(" vertical");
                    player.GetComponent<playerJump>().Jump();
                }
                
            }
}
