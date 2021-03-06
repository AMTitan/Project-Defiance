﻿using person.code;
using UnityEngine;
using UnityEngine.Serialization;

namespace other
{
    public class health_heart_5 : MonoBehaviour
    {

        [FormerlySerializedAs("Player")] public GameObject player;

        private health _playerHealth;

        [FormerlySerializedAs("Max_Player_health")] public int maxPlayerHealth = 100;

        private double _healthThing;

        private float _heathThing3;

        private decimal _healthThing2;
        private health _health;
        private Transform _heart1;
        private Transform _heart2;

        // Start is called before the first frame update
        private void Start()
        {
            _heart2 = transform.Find("heart_red");
            _heart1 = transform.Find("heart_red");
            _health = player.GetComponent<health>();
            _playerHealth = player.GetComponent<health>();

            maxPlayerHealth = _playerHealth.startHealth;
        }

        // Update is called once per frame
        private void Update()
        {
            _playerHealth = _health;

            if (_playerHealth.Health >= ((maxPlayerHealth / 5)) * 5)
            {
                _heart1.localScale = new Vector3(0.76f, 0.7875f);
            }

            if (_playerHealth.Health >= ((maxPlayerHealth / 5)) * 5) return;
            _healthThing = ((_playerHealth.Health - ((maxPlayerHealth / 5) * 4)) * 3.8);

            _healthThing2 = (decimal)_healthThing / maxPlayerHealth;

            _heathThing3 = (float)_healthThing2;

            _heart2.localScale = new Vector3(_heathThing3, 0.7875f);
        }
    }
}
