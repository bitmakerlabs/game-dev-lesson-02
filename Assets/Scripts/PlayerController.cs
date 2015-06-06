using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    #region Public Member Variables
    public float RollForce = 1.0f;
    //public bool UseTorque = false;
    #endregion

    #region Private Member Variables
    private Rigidbody _Rigidbody;
    private Vector2 _InputAxis = new Vector2();
    #endregion

    // Use this for initialization
	void Start () 
    {
        _Rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        _InputAxis.x = Input.GetAxis("Horizontal");
        _InputAxis.y = Input.GetAxis("Vertical");
	}

    void FixedUpdate()
    {
        // mag(v) = x*x + y*y + z*z;
        if( _InputAxis.sqrMagnitude >= 0.01f )
        {
            //if (!UseTorque)
            //{
                _Rigidbody.AddForce(new Vector3(_InputAxis.x, 0, _InputAxis.y) * RollForce);
      /*      }
            else
            {
                _Rigidbody.AddTorque(new Vector3(_InputAxis.y, 0, -_InputAxis.x) * RollForce);
            }*/
        }        
    }

    private void OnTriggerEnter(Collider col)
    {
        if( col.tag == "Pickup" )
        {
            Coin c = col.GetComponent<Coin>();
            c.Kill();
        }
    }
}
