﻿using UnityEngine;

namespace other
{
    public class bullet3 : MonoBehaviour
    {

        public float speed = 20f;

        public Rigidbody2D RB;

        public int dmg = 3;

        public int hardhit = 0;

        public int selected;

        private breakable_wall breakable_Wall;
    
        // Start is called before the first frame update
        void Start()
        {
            RB.velocity = transform.right * speed;

            selected = PlayerPrefs.GetInt("Selcted");

            if(selected == 1)
            {
                dmg = 10;
            }

            if (selected == 2)
            {
                dmg = 7;
            }

            if (selected == 4)
            {
                dmg = 15;
            }

            if (selected == 5)
            {
                dmg = 2;
            }

            hardhit = 0;

        }

        void Update()
        {
        

        }

        void OnTriggerEnter2D(Collider2D col)
        {

            //Debug.Log(col);
            //Debug.Log(col.gameObject.name);
            if (gameObject.tag == "Bullet" && col.gameObject.tag != "Bullet" && col.gameObject.tag != "Player" && col.gameObject.tag != "EniBullet" && col.gameObject.tag != "healthPod")
            {
                if (col.gameObject.tag == "destrutable_wall")
                {
                    breakable_Wall = col.gameObject.GetComponent<breakable_wall>();

                    breakable_Wall.health -= dmg;
                }

                if (gameObject.tag == "Bullet" && col.gameObject.tag == "Eni" || col.gameObject.tag == "Zombie")
                {
                    eni.eni Eni = col.gameObject.GetComponent<eni.eni>();
                    // decrese my health by the bullet damage
                    Eni.health -= dmg;
                }

                //Destroy(gameObject);
            }

        }
    

    }
}
