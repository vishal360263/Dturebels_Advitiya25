using UnityEngine;
using UnityEngine.UI;

public class firstscript : MonoBehaviour
{  
    public GameObject firstpanel;
    public GameObject secondpanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("switchpanel",6f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void switchpanel(){
            firstpanel.SetActive(false);
            secondpanel.SetActive(true);
        }
}
