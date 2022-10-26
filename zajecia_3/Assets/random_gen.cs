using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class random_gen : MonoBehaviour
{
	
	public GameObject myPrefab;
    	// Start is called before the first frame update
    	void Start()
    	{
    		List<Vector3> coords = new List<Vector3>();
    		System.Random r = new Random();
    		for (int i = 0; i < 10; i++) 
		{
		  int n = r.Next(0, 10);
		  int m = r.Next(0, 10);
		  if(coords.Contains(new Vector3(n, 0, m)) == false){
		  	coords.Add(new Vector3(n, 0, m));
		  }
		  else{
		  	i -= 1;
		  }
		}
		for (int i = 0; i < 10; i++) 
		{
		  Instantiate(myPrefab, coords[i], Quaternion.identity);
		}
    	}

}
