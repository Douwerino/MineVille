using System;
using Raylib_cs;


public class GameScene{

    static void Main(string [] args)
    {
        // Initialize Raylib
        Raylib.InitWindow(1280, 720, "Mine Ville");

        Player player = new Player();

        // Main game loop
        while (!Raylib.WindowShouldClose())
        {
            // Begin drawing
            Raylib.BeginDrawing();

            // Clear the screen
            Raylib.ClearBackground(Color.DarkGreen);

            // Draw something (e.g., a rectangle) (x pos, y pos, x scl, y scl)
            Raylib.DrawRectangle(100, 100, 200, 150, Color.Gray);
            // Raylib.DrawRectangle(100, 50, 200, 50, Color.DarkGray);
            // Raylib.DrawRectangle(100, 250, 200, 50, Color.DarkGray);

            Raylib.DrawText("Coins: " + player.Coins, 20, 20, 30, Color.Gold);

            // End drawing
            Raylib.EndDrawing();
        }

        // Close the window when the loop exits
        Raylib.CloseWindow();
    
        


    }


}