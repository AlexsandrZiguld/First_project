using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace project
{    
    public class Player : MonoBehaviour
    {
        public GameObject shieldPrefab;
        public Transform spawnPosition;

        private bool _isSpawnShield;
        private int level = 1;

        private Vector3 _direction;
        public float speed = 2f;
        private bool _isSprint;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(1))
                _isSpawnShield = true;

            _direction.x = Input.GetAxis("Horizontal");
            _direction.z = Input.GetAxis("Vertical");

            _isSprint = Input.GetButton("Sprint");
        }
        private void FixedUpdate()
        {
            if (_isSpawnShield)
            {
                _isSpawnShield = false;
                SpawnShield();
            }

            Move(Time.fixedDeltaTime);
        }
        private void SpawnShield ()
        {
            var shieldObj = Instantiate(shieldPrefab, spawnPosition.position, spawnPosition.rotation);
            var shield = shieldObj.GetComponent<Shield>();
            shield.Init(10 * level);

            shield.transform.SetParent(spawnPosition);
        }

        private void Move(float delta)
        {
            transform.position +=  _direction * (_isSprint ? speed * 2 : speed) * delta;
        }
    }
}
