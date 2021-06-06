using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBolasMenu : MonoBehaviour
{
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
    public float startWait;
  
    IEnumerator Start()
    {
        yield return new WaitForSeconds(startWait);         //Espera a quantidade de tempo antes de 
        StartCoroutine (SpawnarBolas()); 
        if(Input.GetButtonDown("Jump")){
                Debug.Log("Inicia FRENESI!");
            }   

    }



    IEnumerator SpawnarBolas()
    {
      //  yield return new WaitForSeconds(startWait);

       

        for (; ;)
        {
        
            float variavel_de_troca;

            int escolha = Random.Range(0, 2);
            if (escolha % 2 == 0)
            {
                variavel_de_troca = spawnValues.x * -1;
            }
            else
            {
                variavel_de_troca = spawnValues.x;
            }

            Vector3 spawnPosition = new Vector3(x: variavel_de_troca, y: spawnValues.y, z: spawnValues.z);
            Quaternion spawnRotation = Quaternion.Euler(0, 0, Random.Range(-30, 30)); ;
            

            if (variavel_de_troca < 0)
            {
                spawnRotation = Quaternion.Euler(0, 0, Random.Range(-40, -10));
            }
            else
            {
                spawnRotation = Quaternion.Euler(0, 0, Random.Range(10, 40));
            }

            int variavel_de_bola = Random.Range(1,10);

            switch (variavel_de_bola)
            {
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
