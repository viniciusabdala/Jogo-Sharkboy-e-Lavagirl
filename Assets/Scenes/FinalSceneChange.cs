using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSceneChange : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Algo entrou no trigger: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detectado! Indo para FinalScene.");

            SceneManager.LoadScene("FinalScene");
        }
    }
}