using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemManager : MonoBehaviour
{
    public GameObject[] wallet;
    public GameObject[] glass;
    public GameObject[] coins;
    public GameObject[] ring;
    public GameObject[] key;
    public List<Vector2> pos = new List<Vector2>();

    public Image coinWinner;
    public Image glassWinner;
    public Image ringWinner;
    public Image keyWinner;

    // Start is called before the first frame update
    void Start()
    {
        Random.InitState((int)System.DateTime.Now.Ticks);

        foreach (GameObject item in wallet){
            pos.Add(item.transform.position);
        }
        for (int p = 0; p<wallet.Length; p++)
        {
            int n = Random.Range(0, pos.Count);
            wallet[p].transform.position = pos[n];
            pos.RemoveAt(n);
        }

        //random winning glass shard
 
        int i = Random.Range(0, glass.Length);
        glass[i].GetComponent<correctItem>().winningItem = true;
        glassWinner.sprite = glass[i].GetComponent<SpriteRenderer>().sprite;

        foreach (GameObject item in glass)
        {
            pos.Add(item.transform.position);
        }
        for (int p = 0; p < glass.Length; p++)
        {
            int n = Random.Range(0, pos.Count);
            glass[p].transform.position = pos[n];
            pos.RemoveAt(n);
        }

        //random winning coin

        i = Random.Range(0, coins.Length);
        coins[i].GetComponent<correctItem>().winningItem = true;
        coinWinner.sprite = coins[i].GetComponent<SpriteRenderer>().sprite;


        foreach (GameObject item in coins)
        {
            pos.Add(item.transform.position);
        }
        for (int p = 0; p < coins.Length; p++)
        {
            int n = Random.Range(0, pos.Count);
            coins[p].transform.position = pos[n];
            pos.RemoveAt(n);
        }

        //random winning ring 

        i = Random.Range(0, ring.Length);
        ring[i].GetComponent<correctItem>().winningItem = true;
        ringWinner.sprite = ring[i].transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().sprite;


        foreach (GameObject item in ring)
        {
            pos.Add(item.transform.position);
        }
        for (int p = 0; p < ring.Length; p++)
        {
            int n = Random.Range(0, pos.Count);
            ring[p].transform.position = pos[n];
            pos.RemoveAt(n);
        }


        //random winning key 

        i = Random.Range(0, key.Length);
        key[i].GetComponent<correctItem>().winningItem = true;
        keyWinner.sprite = key[i].GetComponent<SpriteRenderer>().sprite;

        foreach (GameObject item in key)
        {
            pos.Add(item.transform.position);
        }
        for (int p = 0; p < key.Length; p++)
        {
            int n = Random.Range(0, pos.Count);
            key[p].transform.position = pos[n];
            pos.RemoveAt(n);
        }


    }



}
