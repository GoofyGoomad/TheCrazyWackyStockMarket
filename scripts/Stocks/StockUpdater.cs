using System;
using Godot;

public partial class StockUpdater : Timer
{
    int stockTruePrice = 50;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        //GetNode<Label>("../Display/StockBuyPrice").Text = $"{stockTruePrice}";
        //GetNode<Label>("../Display/StockSellPrice").Text = $"{Math.Round(((double)stockTruePrice / 100) * 90)}";
        this.Timeout += UpdateStocks;
    }
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
    }
    public void UpdateStocks()
    {
        Random random = new Random();
        int[] plusOrMinusChances = { -1, 0, 1};
        int randomPriceChange = random.Next(plusOrMinusChances.Length);
        
        stockTruePrice += plusOrMinusChances[randomPriceChange];
        //GD.Print("hello"); Use for debugging
    }
}
