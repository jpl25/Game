package dungeongame;

import java.util.Random;
import java.util.Scanner;
/**
 *
 * @author jww46
 */
public final class Player
{
    private final String name;
    private final String description;
    private final int maxHitPoints;
    private int hitPoints;
    private int numPotions;
    private final int minDamage;
    private final int maxDamage;
    private final Random random = new Random();
    private final String Class = "";
    
    private Player(String name, String description, int maxHitPoints, int minDamage, int maxDamage, int numPotions)
    {
        this.name = name;
        this.description = description;
        this.maxHitPoints = maxHitPoints;
        this.numPotions = numPotions;
        this.minDamage = minDamage;
        this.maxDamage = maxDamage;
        this.hitPoints = maxHitPoints;
    }
    
    public int attack()
    {
        return random.nextInt(maxDamage - minDamage + 1) + minDamage;
    }
    
    public void defend(Monster monster)
    {
        int attackStrength = monster.attack();
        hitPoints = (hitPoints > attackStrength) ? hitPoints - attackStrength : 0;
        System.out.printf(" " + name + " is hit for %d HP of damage (%s)\n" , attackStrength, getStatus());
        if(hitPoints == 0) 
        {
            System.out.println(" " + name + " has been defeated");
        }            
    }
    
    public void heal() 
    {
        if (numPotions > 0) 
        {
            hitPoints = Math.min(maxHitPoints, hitPoints + 20);
            System.out.printf("  %s drinks healing potion (%s, %d potions left)\n", name,
                    getStatus(), --numPotions);
        } else 
        {
            System.out.println("  You've exhausted your potion supply!");
        }
    }

    public boolean isAlive() 
    {
        return hitPoints > 0;
    }

    public String getStatus() 
    {
        return "Player HP: " + hitPoints;
    }

    @Override
    public String toString() 
    {
        return name;
    }

    public String getDescription() 
    {
        return description;
    }
    public String getPlayerClass()
    {
        switch (numPotions) {
            case 10:
                return "Rouge";
            case 20:
                return "Mage";
            case 3:
                return "Barbarian";
            case 11:
                return "Knight";
            default:
                return "Rouge";
        }
        
    }
    public static Player newInstance() 
    {
        Scanner scan = new Scanner(System.in);
        System.out.println("Choose your CLASS");
        System.out.println("Press 1: Rouge");
        System.out.println("Press 2: Mage");
        System.out.println("Press 3: Barbarian");
        System.out.println("Press 4: Knight\n\n");
        
        int i = scan.nextInt();
        
        switch (i) {
            case 1:
                //25 = maxHitPoints, 3 = minDamage, 35 = maxDamage, 10 = numOfPotions
                return new Player("Rouge", "Hiding in the shadows, waiting to slit your enemeies throats", 25, 3, 35, 10);
            case 2:
                //20 = maxHitPoints, 15 = minDamage, 50 = maxDamage, 20 = numOfPotions
                return new Player("Mage", "Using the Arcane Arts to rain down damage on your foes", 20, 15, 50, 20);
            case 3:
                //25 = maxHitPoints, 3 = minDamage, 35 = maxDamage, 3 = numOfPotions
                return new Player("Barbarian", "With your mighty club, ripping heads from bodies", 50, 20, 60, 3);
            default:
                //32 = maxHitPoints, 13 = minDamage, 48 = maxDamage, 11 = numOfPotions
                return new Player("Knight", "Swinging your mighty broad Sword, Cleaving enemies in half ", 32, 13, 48, 11);
        }
        
    }
}

