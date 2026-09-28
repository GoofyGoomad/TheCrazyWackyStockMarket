using System;
using Godot;
using System.Collections.Generic;

public partial class Stocks : Node
{
	public static List<string> stockList = new List<string>() {"Apple", "Banana", "Cherry"};
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
