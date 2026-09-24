using System;
using Godot;

public partial class StockUpdater : Timer
{
    int placeholderNumber = 0;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
        this.Timeout += UpdateStocks;
        //this.Timeout += stockTitle;
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
    }
    public void UpdateStocks()
    {
        GetNode<Label>("/root/Game/StockTitle").Text = $"Coins + {placeholderNumber}";
        GD.Print("hello");
        placeholderNumber++;
    }
}
