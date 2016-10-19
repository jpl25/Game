/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dungeongame;

import java.util.Scanner;
import java.io.IOException;

public final class Battle 
{

    public Battle(Player player, Monster monster) throws IOException
    {
        System.out.println("You come upon a " + monster + ": " + monster.getDescription() + "\n");
        System.out.println("Encounter with " + monster + " starts (" + player.getStatus() + " / "
                + monster.getStatus() + ")");
        Scanner scan = new Scanner(System.in);
        while (player.isAlive() && monster.isAlive())
        {
            System.out.println("Press 1: Attack");
            System.out.println("Press 2: Heal");
            int action = scan.nextInt();
            if (action == 2)
            {
                player.heal();
            } else 
            {
                monster.defend(player);
            }
            if (monster.isAlive())
            {
                player.defend(monster);
            }
        }
    }

}