using UnityEngine;

public class MotionPlayerScript : MonoBehaviour
{   
    public Animator ani;

    void Start()
    {
        ani = GetComponent<Animator>(); // Assign Animator to avoid null reference
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            ani.SetBool("ruuning", true);
         
            ani.SetBool("walking1", false);
            ani.SetBool("jump",false);
            ani.SetBool("left w", false);
            ani.SetBool("right w", false);
             ani.SetBool("back w", false);
            transform.position = transform.position +new Vector3(5f*Time.deltaTime,0,0);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            
           ani.SetBool("ruuning", false);
            ani.SetBool("walking1", true);
            ani.SetBool("jump",false);
            ani.SetBool("left w", false);
            ani.SetBool("right w", false);
             ani.SetBool("back w", false);
             transform.position = transform.position +new Vector3(2f*Time.deltaTime,0,0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            
            ani.SetBool("right w", true);
            ani.SetBool("ruuning", false);
            ani.SetBool("walking1", false);
            ani.SetBool("jump",false);
            ani.SetBool("left w", false);
          
             ani.SetBool("back w", false);
            transform.position = transform.position +new Vector3(0,0,2f*Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            
            ani.SetBool("left w", true);
            ani.SetBool("ruuning", false);
            ani.SetBool("walking1", false);
            ani.SetBool("jump",false);
           
            ani.SetBool("right w", false);
             ani.SetBool("back w", false);
             transform.position = transform.position +new Vector3(0,0,-2f*Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            
            ani.SetBool("back w", true);
            ani.SetBool("ruuning", false);
            ani.SetBool("walking1", false);
            ani.SetBool("jump",false);
            ani.SetBool("left w", false);
            ani.SetBool("right w", false);
             
             transform.position = transform.position +new Vector3(-2f*Time.deltaTime,0,0);
        }
        else if(Input.GetKey(KeyCode.Space)){
            ani.SetBool("jump",true);
            ani.SetBool("ruuning", false);
            ani.SetBool("walking1", false);
            
            ani.SetBool("left w", false);
            ani.SetBool("right w", false);
             ani.SetBool("back w", false);
             transform.position = transform.position +new Vector3(2f*Time.deltaTime,0,0);
        }
        else
        {
            ani.SetBool("ruuning", false);
            ani.SetBool("walking1", false);
            ani.SetBool("jump",false);
            ani.SetBool("left w", false);
            ani.SetBool("right w", false);
             ani.SetBool("back w", false);
        }
    }
}
