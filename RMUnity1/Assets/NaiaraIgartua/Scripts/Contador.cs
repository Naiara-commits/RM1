using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private TextMeshProUGUI contadorTexto;
    private int cubosDestruidos = 0;
    private const int fin = 20;

    void Awake()
    {
        Instance = this;
    }

    public void Contador()
    {
        cubosDestruidos++;
        contadorTexto.text = cubosDestruidos + " / " + fin;

        if (cubosDestruidos >= fin)
        {
            contadorTexto.text = "¡Has ganadoooo!";

            FindObjectOfType<Cubos>().CancelInvoke(nameof(Cubos.spawnCubo));

        }
    }

    public bool MetaAlcanzada() => cubosDestruidos >= fin;
}
