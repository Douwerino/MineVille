using System;
using Raylib_cs;
using MineVille;

public class GameScene{

    static void Main(string [] args)
    {
        // Initialize Raylib
        Raylib.InitWindow(1280, 720, "Mine Ville");

        Player player = new Player(new Texture2D(), Color.Beige);

        // Main game loop
        while (!Raylib.WindowShouldClose())
        {
            // Begin drawing
            Raylib.BeginDrawing();

            // Clear the screen
            Raylib.ClearBackground(Color.DarkGreen);

            // Drawing of the mine (x pos, y pos, x scl, y scl)
            Raylib.DrawRectangle(0, 100, 1280, 150, Color.Gray); //top ground
            Raylib.DrawRectangle(0, 0, 1280, 100, Color.DarkGray);
            Raylib.DrawRectangle(0, 100, 150, 175, Color.DarkGray);
            Raylib.DrawRectangle(250, 175, 500, 100, Color.DarkGray);


            //Raylib.DrawText("Coins: " + player.Coins, 20, 20, 30, Color.Gold);

            // End drawing
            Raylib.EndDrawing();
        }

        // Close the window when the loop exits
        Raylib.CloseWindow();
    
        


    }



}