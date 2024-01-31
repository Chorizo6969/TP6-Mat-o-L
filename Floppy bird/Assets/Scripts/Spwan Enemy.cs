using System.Collections;
using UnityEngine;

public class SpwanEnemy : MonoBehaviour
{
    public GameObject PrefabTuyau1;
    public GameObject PrefabTuyau2;
    public GameObject PrefabTuyau3;
    public GameObject PrefabTuyau4;
    public GameObject PrefabTuyau5;
    public int result;

    void Start()
    {
        ShufflePrefab();
    }

    void ShufflePrefab()
    {
        result = Random.Range(1, 6);
        Spawner();
    }

    public void Spawner()
    {

        switch (result)
        {
            case 1:
                GameObject Spwan = Instantiate(PrefabTuyau1);
                Spwan.transform.position = new Vector2(14, 0);
                StartCoroutine(Repete());
                break;

            case 2:
                GameObject Spwan2 = Instantiate(PrefabTuyau2);
                Spwan2.transform.position = new Vector2(14, 0);
                StartCoroutine(Repete());
                break;

            case 3:
                GameObject Spwan3 = Instantiate(PrefabTuyau3);
                Spwan3.transform.position = new Vector2(14, 0);
                StartCoroutine(Repete());
                break;

            case 4:
                GameObject Spwan4 = Instantiate(PrefabTuyau4);
                Spwan4.transform.position = new Vector2(14, 0);
                StartCoroutine(Repete());
                break;

            case 5:
                GameObject Spwan5 = Instantiate(PrefabTuyau5);
                Spwan5.transform.position = new Vector2(14, 0);
                StartCoroutine(Repete());
                break;
        }
    }
    IEnumerator Repete()
    {
        result = Random.Range(1, 6);
        yield return new WaitForSeconds(3);
        Spawner();
    }
}
