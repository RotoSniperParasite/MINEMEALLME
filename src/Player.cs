class Player
{
    // auto property 
    public Room CurrentRoom { get; set; }

    public int health;


    // constructor 
    public Player()
    {
        CurrentRoom = null;
        health = 100;
    }
    public void Damage(int amount)
    {
        health -= amount;
    }

    public void Heal(int amount)
    {
        health += amount;
    } // player's health restores

    public bool IsAlive() {
        return health > 0;
    }
}

