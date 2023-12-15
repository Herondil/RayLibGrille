//définir un symbole
#define DEBUG

using static Raylib_cs.Raylib;
using Raylib_cs;
using RayLibGrille;

Console.WriteLine("Début du programme");

IEnumerable<int> _ie = GetSingleDigitNumbers();

foreach(int i in _ie)
{
    Console.WriteLine(i);
}

Raylib.InitWindow(1000, 1000, "Grille");

//On crée les deux GameObjects principaux du jeu
GameObject player   = new GameObject();
GameObject grid     = new GameObject();

//on crée la scène
Scene main = new Scene("main");
MainScene ms = new MainScene("");

//on ajoute les gameobjects dans la scène
main.Add(player);
main.Add(grid);

//Créer un GameObject pour le joueur
//Dans ce GameObject, un component de type Renderer



while (!Raylib.WindowShouldClose())
{
    //mise à jour des objets de la scène
    main.Update();

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);

    if (Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT)){
        Console.WriteLine("Flèche droite");
    }

    //dessin des objets de la scène
    main.Render();

    unsafe { 

    Image WizIdle = LoadImage("imgs/Sprites/Idle.png");
    ImageCrop( &WizIdle, new Rectangle(0, 0, WizIdle.Width / 8, WizIdle.Height));

    }

    Raylib.DrawLine(100, 0, 100, 999, Color.BLACK);
    Raylib.DrawLine(200, 0, 200, 999, Color.BLACK);
    Raylib.DrawLine(300, 0, 300, 999, Color.BLACK);
    Raylib.DrawLine(400, 0, 400, 999, Color.BLACK);
    Raylib.DrawLine(500, 0, 500, 999, Color.BLACK);

    Raylib.EndDrawing();
}

Raylib.CloseWindow();

//iterator method
//qui retourne un énumérable, donc un Enumerator
IEnumerable<int> GetSingleDigitNumbers()
{
    //première itération

    yield return 0; //fin de la première itaration

    //deuxième

    yield return 1;
    yield return 2;
    yield return 44;



    yield return 4;
    yield return 5;
    yield return 6;
    yield return 125;
    yield return 8;
    yield return 9;
}