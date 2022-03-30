using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace project
{
    public class SpawnEnemy : MonoBehaviour
        
    {
        public GameObject ghostPrefab;
        public Transform spawnPosition;

        // Start is called before the first frame update
        void Start()
        {
            Instantiate(ghostPrefab, spawnPosition.position, spawnPosition.rotation);
        }        
    }

}
