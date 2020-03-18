using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class player : MonoBehaviour
{

    private Rigidbody rb;

    public float speed;

    public GameObject Player;

    private int numCoins ;

    public TextMeshProUGUI m_Text;

    //public Text counText;



    #region Singleton
    public static player instance;

    private void Awake()
    {
        instance = this;

      
    }

    #endregion

   
    void setcounText()
    {
        
        m_Text.text = "Score: " + numCoins.ToString();
        Debug.Log(numCoins);
        //counText.text = "Score: " + numCoins.ToString();
    }


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("coin"))
        {
            Debug.Log("Pick Up coin");
            other.gameObject.SetActive(false);
            numCoins = numCoins + 1 ;
            setcounText();

        }

    }

    
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        speed = 15f;
        setcounText();
        Debug.Log(numCoins);
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal,0f,moveVertical);

        rb.AddForce(movement*speed);
       
       // transform.Translate(speed*moveHorizontal*Time.deltaTime,0f,speed*moveVertical);
    }
}
