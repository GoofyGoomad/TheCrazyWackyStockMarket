using System;
using System.Collections.Generic;
using Godot;

public partial class Stocks : Node
{

	private Label StockGodot;
	private Label stockTitle;
	private int stockIdIndicator = 0;
	public static List<string> stockList = new List<string>() { "Apple", "Banana", "Cherry" };
	public static Dictionary<int, string> stocksDict = new Dictionary<int, string>();
	private List<int> stockId = new List<int>() { };

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		/*
		// For when configs are actually made
		// Loops through each stock in stockList
		foreach (string stockName in stockList)
		{
			stockIdIndicator++;
			//Stock thing = new Stock("Apple");
			stocksDict.Add(stockIdIndicator, stockName);
			for (int i = (10 - stockIdIndicator.ToString().Length); i > 0; i--)
			{
				stockId.Add(0);
			}
			stockId.Add(stockIdIndicator);

			StockGodot = new Label();
			StockGodot.Name = $"Stock{String.Join("", stockId)}";
			StockGodot.Text = stockName;
			GetNode<GridContainer>("Display").AddChild(StockGodot);

			stockId = new List<int>() { };
		}
		*/
	}

	public override void _Process(double delta)
	{
		// Called every frame. 'delta' is the elapsed time since the previous frame.
	}
}
public class Stock
{
	string name;
	int id;
	string code;
	float buyPrice;
	float sellPrice;
	public Stock(string name, int id, string code, float buyPrice, float sellPrice)
	{
		this.name = name;
		this.id = id;
		this.code = code;
		this.buyPrice = buyPrice;
		this.sellPrice = sellPrice;
	}
}
