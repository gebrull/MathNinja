using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SpawnFrenesi : MonoBehaviour
{

    public GameObject frenesi;
    public GameObject bola1;
    public GameObject bola2;
    public GameObject bola3;
    public GameObject bola4;
    public GameObject bola5;
    public GameObject bola6;
    public GameObject bola7;
    public GameObject bola8;
    public GameObject bola9;

    public Vector3 spawnValues;
    public float spawnwait;
    private int variavel_bola;

    // Start is called before the first frame update
    void Start()
    {   
        Destroy(frenesi, 6);
        StartCoroutine (IniciaFrenesi());
    }

    IEnumerator IniciaFrenesi()
    {
     
        for (; ;)
        {
    
            Vector3 spawnPosition = new Vector3(x: spawnValues.x, y: spawnValues.y, z: spawnValues.z);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, Random.Range(-30, 30));
                       
            variavel_bola = Random.Range(1,10);
            switch (variavel_bola) {
                case 1:
                    Instantiate(bola1, spawnPosition, spawnRotation);
                    break;
                case 2:
                    Instantiate(bola2, spawnPosition, spawnRotation);
                    break;
                case 3:
                    Instantiate(bola3, spawnPosition, spawnRotation);
                    break;
                case 4:
                    Instantiate(bola4, spawnPosition, spawnRotation);
                    break;
                case 5:
                    Instantiate(bola5, spawnPosition, spawnRotation);
                    break;
                case 6:
                    Instantiate(bola6, spawnPosition, spawnRotation);
                    break;
                case 7:
                    Instantiate(bola7, spawnPosition, spawnRotation);
                    break;
                case 8:
                    Instantiate(bola8, spawnPosition, spawnRotation);
                    break;
                case 9:
                    Instantiate(bola9, spawnPosition, spawnRotation);
                    break;
            }

            yield return new WaitForSeconds(spawnwait);
        }
        

    }


}
