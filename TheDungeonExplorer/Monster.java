package dungeongame;

import java.util.HashSet;
import java.util.Random;
import java.util.Set;

public final class Monster 
{

    private final String name;
    private final String description;
    private int hitPoints;
    private final int minDamage;
    private final int maxDamage;
    private final static Random random = new Random();
    private final static Set<Integer> monstersSeen = new HashSet<>();
    private final static int NUM_MONSTERS = 3;

    public static Monster newRandomInstance()
    {
        if (monstersSeen.size() == NUM_MONSTERS)
        {
            monstersSeen.clear();
        }
        int i;
        do 
        {
            i = random.nextInt(NUM_MONSTERS);
        } while (monstersSeen.contains(i));
        monstersSeen.add(i);

        switch (i) 
        {
            case 0:
                return new Monster("Harpy", "HARPY", 40, 8, 12);
            case 1:
                return new Monster("Gargoyle", "Gargoyle", 26, 4, 6);
            default:
                return new Monster("Hobgoblin", "HOBGOBLIN", 18, 1, 2);
        }
    }

    public static Monster newBossInstance() 
    {
        return new Monster("Dragon", "DRAGON", 60, 10, 20);
    }

    private Monster(String name, String description, int hitPoints, int minDamage, int maxDamage)
    {
        this.name = name;
        this.description = description;
        this.minDamage = minDamage;
        this.maxDamage = maxDamage;
        this.hitPoints = hitPoints;
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

    public String getStatus() 
    {
        return "Monster HP: " + hitPoints;
    }

    public int attack() 
    {
        return random.nextInt(maxDamage - minDamage + 1) + minDamage;
    }

    public void defend(Player player) 
    {
        int attackStrength = player.attack();
        hitPoints = (hitPoints > attackStrength) ? hitPoints - attackStrength : 0;
        System.out.printf("  %s hits %s for %d HP of damage (%s)\n", player, name, attackStrength,
                getStatus());
        if (hitPoints == 0) 
        {
            String playerClass = player.getPlayerClass();
            
            switch (playerClass) {
                case "Rouge":
                    System.out.println("  " + player + " Sneaks up behind the " + name
                            + " and slits its throat");
                    break;
                case "Mage":
                    System.out.println("  " + player + " conjures rain of fire onto the " + name
                            + " and burns the monster to the ground");
                    break;
                case "Barbarian":
                    System.out.println("  " + player + " Raises his mighty club in front of the " + name
                            + " and deals a fatal blow to its head");
                    break;
                case "Knight":
                    System.out.println("  " + player + " Swings its large broadSword at the " + name
                            + " splitting its body in half");
                    break;
                default:
                    break;
            }
        }
    }

    public boolean isAlive() 
    {
        return hitPoints > 0;
    }

}