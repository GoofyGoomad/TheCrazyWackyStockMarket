using System;
using System.Collections.Generic;
using Godot;

public partial class Display : GridContainer
{
	private Label Stock;
	private Label stockTitle;
	private int stockIdIndicator = 0;
	private List<int> stockId = new List<int>() {};
	public void StockCreator(string name)
	{
		stockIdIndicator++;
		for (int i = (10 - stockIdIndicator.ToString().Length); i > 0; i--)
		{
			stockId.Add(0);
		}
		stockId.Add(stockIdIndicator);

		Stock = new Label();
        Stock.Name = $"Stock{String.Join("", stockId)}";
        Stock.Text = name;
        AddChild(Stock);

        stockId = new List<int>() {};
	}
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		foreach (string stock in Stocks.stockList)
		{
			StockCreator(stock);
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
