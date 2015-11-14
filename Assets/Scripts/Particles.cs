using UnityEngine;
using System.Collections;

public class Particles : MonoBehaviour {

    public GameObject player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void Emit(int num)
    {
        UpdatePosition();
        GetComponent<ParticleSystem>().Emit(num);
    }

    public void UpdatePosition()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y - 0.8f, transform.position.z);
    }
}
