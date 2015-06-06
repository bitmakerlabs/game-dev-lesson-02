using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour
{
    #region Private Member Variables
    private bool _Alive = true;
    #endregion

    #region Public Methods
    public void Kill()
    {               
        GameObject.Destroy(this.gameObject);
        _Alive = false;
    }
    #endregion
    // Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (!_Alive)
            return;

        this.transform.Rotate(0.0f, 15.0f * Time.deltaTime, 0.0f, Space.World);
	}
}
