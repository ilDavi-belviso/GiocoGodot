using Godot;
using System;

public partial class Player : CharacterBody3D
{
    [Export]private AnimationPlayer animationPlayer;
    [Export] private Sprite3D sprite3D;
    private Vector2 direction = new();
    public override void _Ready()
    {

    }
    public override void _PhysicsProcess(double delta)
    {
        //GD.Print("Sto eseguendo il player");
        Velocity = new Vector3(direction.X, 0, direction.Y);
        Velocity *= 5;
        MoveAndSlide();
    }
    public override void _Input(InputEvent @event)
    {
        GD.Print(Input.GetVector("MoveLeft", "MoveRight", "MoveForward", "MoveBackeard"));
        //direction = Input.GetVector("MoveLeft", "MoveRight", "MoveForward", "MoveBackeard");
        //if (direction == Vector2.Zero)
        //{
            
        //}
    }
}
