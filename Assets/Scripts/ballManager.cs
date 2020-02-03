using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballManager : MonoBehaviour
{
  [SerializeField]int remainingBalls = 4;
    int inGameBalls;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void ballLaunched()
    {
        inGameBalls++;
        remainingBalls--;
    }

}
