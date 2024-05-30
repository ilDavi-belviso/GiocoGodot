using Godot;
using System;

public partial class Player : CharacterBody3D
{
    [ExportGroup("Required Nodes")]
    [Export]private AnimationPlayer animPlayerNode;
    [Export] private Sprite3D spriteNode;
    private Vector2 direction = new();
    public override void _Ready()
    {
            GD.Print(animPlayerNode.Name);
            GD.Print(spriteNode.Name);
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
        //GD.Print(Input.GetVector("MoveLeft", "MoveRight", "MoveForward", "MoveBackeard"));
        //direction = Input.GetVector("MoveLeft", "MoveRight", "MoveForward", "MoveBackeard");
    }
}
