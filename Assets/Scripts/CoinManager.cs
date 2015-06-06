using UnityEngine;
using System.Collections;

public class CoinManager : MonoBehaviour 
{
    public BoxCollider FloorBounds;
    public Coin CoinPrefab;

    public int MaxCoins = 10;
    public int MinCoins = 5;

	// Use this for initialization
	void Start () 
    {
        Bounds bnds = FloorBounds.bounds;
        
        int coinsToSpawn = Random.Range(MinCoins, MaxCoins);

        for (int i = 0; i < coinsToSpawn; i++)
        {
            Vector3 rndPoint = new Vector3(Random.Range(bnds.min.x, bnds.max.x), 0.0f, Random.Range(bnds.min.z, bnds.max.z));
            GameObject.Instantiate(CoinPrefab, rndPoint, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
