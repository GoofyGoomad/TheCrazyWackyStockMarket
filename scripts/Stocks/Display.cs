using Godot;
using System;
using System.Collections.Generic;

public partial class Display : GridContainer
{
	private Node2D Stock;
	private Label stockTitle;
	private int stockNumIndicator = 0;
	private List<int> stockNum = new List<int>() {};
	public void StockCreator()
	{
		stockNumIndicator += 1;
		for (int i = (10 - stockNumIndicator.ToString().Length); i > 0; i--)
		{
			stockNum.Add(0);
		}
		stockNum.Add(stockNumIndicator);

		Stock = new Node2D();
		Stock.Name = $"Stock{String.Join("", stockNum)}";
		AddChild(Stock);

		stockTitle = new Label();
		stockTitle.Text = "This is text";

		stockNum = new List<int>() {};
	}
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		for (int i = 0; i < 100; i++)
		{
			StockCreator();
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
