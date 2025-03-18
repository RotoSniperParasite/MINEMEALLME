class Player
{
    // auto property 
    public Room CurrentRoom { get; set; }

    private int health;
    
    // constructor 
    public Player()
    {
        CurrentRoom = null;
        health = 100;
    }
    public void Damage(int amount) { /*...*/ } // player loses some health 
    public void Heal(int amount) { /*...*/ } // player's health restores 
    public void IsAlive() { /*...*/ } // checks whether the player is alive or not
}