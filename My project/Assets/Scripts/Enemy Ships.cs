using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShips : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string mode = "Easy";
        if (mode == "Easy") 
            EnemyShip enemy1 = new(1,10,20,10)
        




    }

    // Update is called once per frame
    void Update()
    {
        class EnemyShip
    {
        private int Tier;
        private float Damage: // values change based on diffuculty 
        private int Position_X; // random x position same y 
        private int Health; // values change based on diffucluty 


        public EnemyShip(string tier, float Damage, int size, int position, int health)
        {
           
            this.Damage = Damage;
            this.Tier = tier;
            this.Position_X = position; 
            this.Health = health;
        }

        public void SpawnShip()
        {
            if (this.Tier == 1)
        }


        public float GetDamage()
        {
            return this.Damage; // once bullet comes in contact with ship it will use this variable to reduce the players health 
        }

        public int GetTier()
        {
            
                
        }
        public float GetDamage()
        {
            return this.
        }


    }
    }
}
