using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deadPlayer : MonoBehaviour
{

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.name == "monster")
        {
            Debug.Log("Game Over");
            Destroy(collisionInfo.collider.gameObject);
            SceneManager.LoadScene("gameOver");
            
        }

    }

}
