/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dungeongame;

import java.io.IOException;

public final class DungeonGame 
{

    private final Player player = Player.newInstance();

    public void play() throws IOException 
    {
        System.out.println("You are a " + player + " " + player.getDescription());
        Dungeon.newInstance().startQuest(player);
    }

    public static void main(String[] args) throws IOException
    {
        DungeonGame game = new DungeonGame();
        game.play();
    }

}
