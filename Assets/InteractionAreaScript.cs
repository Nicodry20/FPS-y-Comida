using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionAreaScript : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        PickupScript pickup = other.GetComponent<PickupScript>();

        if (pickup != null)
        {
            score += pickup.puntosItem;
            UpdateScoreText();

            if (pickup.esComida)
            {
                Destroy(other.gameObject);
            }
        }
        Debug.Log("Contacto");
    }

    private void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }
}
