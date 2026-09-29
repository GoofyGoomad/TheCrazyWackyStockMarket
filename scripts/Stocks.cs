using System;
using System.Collections.Generic;
using Godot;

public partial class Stocks : Node
{
    
    private Label Stock;
	private Label stockTitle;
    private int stockIdIndicator = 0;
    public static List<string> stockList = new List<string>() { "Apple", "Banana", "Cherry" };
    public static Dictionary<int, string> stocksDict = new Dictionary<int, string>();
    private List<int> stockId = new List<int>() { };
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
    	// Loops through each stock in stockList and 
        foreach (string stockName in stockList)
		{
            stockIdIndicator++;
            stocksDict.Add(stockIdIndicator, stockName);
            for (int i = (10 - stockIdIndicator.ToString().Length); i > 0; i--)
			{
				stockId.Add(0);
			}
			stockId.Add(stockIdIndicator);

			Stock = new Label();
			Stock.Name = $"Stock{String.Join("", stockId)}";
			Stock.Text = stockName;
			GetNode<GridContainer>("Display").AddChild(Stock);

			stockId = new List<int>() {};
		}
	}

	public override void _Process(double delta)
    {
    	// Called every frame. 'delta' is the elapsed time since the previous frame.
    }
}
