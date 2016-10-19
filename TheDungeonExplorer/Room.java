package dungeongame;

import java.io.IOException;
import java.util.HashSet;
import java.util.Random;
import java.util.Set;

public final class Room 
{

    private final String description;
    private final Monster monster;
    private final Boolean isBossRoom;
    private final static Random random = new Random();
    private final static Set<Integer> roomsSeen = new HashSet<>();
    private final static int NUM_ROOMS = 7;

    private Room(String description, Monster monster, Boolean isBossRoom)
    {
        this.description = description;
        this.monster = monster;
        this.isBossRoom = isBossRoom;
    }

    public static Room newRegularInstance()
    {
        if (roomsSeen.size() == NUM_ROOMS)
        {
            roomsSeen.clear();
        }
        int i;
        do 
        {
            i = random.nextInt(NUM_ROOMS);
        } while (roomsSeen.contains(i));
        roomsSeen.add(i);

        String roomDescription = null;
        switch (i) 
        {
            case 0:
                roomDescription = "A fetid, dank room teeming with foul beasts";
                break;
            case 1:
                roomDescription = "An endless hall with a seeminly long rug";
                break;
            case 2:
                roomDescription = "A prison cell, covered in blood";
                break;
            case 3:
                roomDescription = "A long hallway dark with the eyes of the damned";
                break;
            case 4:
                roomDescription =
                        "A large room with the damp smell of the dead";
                break;
            case 5:
                roomDescription =
                        "A balcony overlooking the black sea";
                break;
            case 6:
                roomDescription = "A Dungeon room filled with bones of the dead";
                break;
            default:
                break;
        }
        return new Room(roomDescription, Monster.newRandomInstance(), false);
    }

    public static Room newBossInstance() 
    {
        return new Room("a huge cavern thick with the smell of sulfur", Monster.newBossInstance(),
                true);
    }

    public boolean isBossRoom()
    {
        return isBossRoom;
    }

    public boolean isComplete()
    {
        return !monster.isAlive();
    }

    @Override
    public String toString() 
    {
        return description;
    }

    public void enter(Player player) throws IOException
    {
        System.out.println("You are in " + description);
        if (monster.isAlive())
        {
            Battle battle = new Battle(player, monster);
        }
    }

}