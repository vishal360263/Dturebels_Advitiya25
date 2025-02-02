using UnityEngine;
using UnityEngine.SceneManagement;

public class thirdpanelopener : MonoBehaviour
{
    public GameObject thirdpane;
    public GameObject secondpane;
    public GameObject firstpane;


    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void thirdpanel()
    {
        thirdpane.SetActive(true);
        firstpane.SetActive(false);
        secondpane.SetActive(false);
    }
      public void nextscene()
    {
        SceneManager.LoadScene("level1");
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
