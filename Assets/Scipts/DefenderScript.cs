using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderScript : MonoBehaviour {
    [SerializeField] int starCost = 100;
    [SerializeField] int starAmount = 0;
    public void AddStars() {
        if(starAmount>0){
            FindObjectOfType<StarDisplayScript>().AddStars(starAmount);
        }
    }

    public int GetStarCost() {
        return starCost;
    }
}
