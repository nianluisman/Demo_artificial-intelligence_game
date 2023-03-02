using Godot;
using System;

public class Seek : Node2D
{
	private Player mainCharacter;
	public override void _Ready()
	{
	}

	public Vector2 SeekCalulate(Vector2 startPosition, Vector2 Target, Vector2 Velocity){
		var desired_velocity = new Vector2(Target - startPosition).Normalized();
		var steering = desired_velocity - Velocity;
		   // var flee =  steering * -1;

		return steering;
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.

}
