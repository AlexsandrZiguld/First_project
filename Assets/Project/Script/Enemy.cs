using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace project
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private Player _player;

        // Start is called before the first frame update
        void Start()
        {
            _player = FindObjectOfType<Player>();
           
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}