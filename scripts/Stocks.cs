using Godot;
using System;

public partial class Stocks : Node
{
	private Label stockTitle;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		/*
		stockTitle = new Label();
		stockTitle.Text = "This is text";
		GetNode<GridContainer>("Display").AddChild(stockTitle);
		*/
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
