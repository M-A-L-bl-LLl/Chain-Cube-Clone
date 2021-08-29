using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedZone : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Slider;

    private void OnTriggerStay(Collider other)
    {
        Cube cube = other.GetComponent<Cube>();

        if (cube != null)
        {
            if (!cube.IsMainCube && cube.CubeRigidbody.velocity.magnitude < .1f)
            {
                Debug.Log("Gameover");
                ScoreController.instance.ShowFinalResault();
                Canvas.gameObject.SetActive(true);
                Slider.gameObject.SetActive(false);
            }
        }
    }
}
