// using System;
// using System.Collections.Generic;
// using Godot;

// public class StatsMenu : Control
// {
//     List<Stat> _stats;
//     List<StatsPrototype> _builtStats = new List<StatsPrototype>();
//     StatsContainer _statsContainer;

//     // public override void _Ready()
//     // {
//     //     base._Ready();
//     //     StatsContainer sc = new StatsContainer();
//     //     Init(ref sc);
//     // }

//     public void Init(ref StatsContainer statsContainer)
//     {
//         _statsContainer = statsContainer;

//         Node statsParent = GetNode("Margin/StatsContainer");

//         _stats = DataLoader.LoadData();
//         foreach (Stat stat in _stats)
//         {
//             PackedScene statsPrototypePacked = GD.Load("res://Scenes/UI/StatPrototype.tscn") as PackedScene;
//             StatsPrototype prototype = statsPrototypePacked.Instance() as StatsPrototype;
//             statsParent.AddChild(prototype);
//             prototype.Build(stat, ref _statsContainer);

//             _builtStats.Add(prototype);
//         }

//         Button resetBtn = GetNode("ResetButton") as Button;
//         resetBtn.Connect("pressed", this, "OnStatsReset");

//         UpdatePointsText();
//     }

//     void UpdatePointsText()
//     {
//         Label points = GetNode("Points") as Label;
//         points.Text = $"Points: {_statsContainer.AvailablePoints}";
//     }

//     public void OnStatsReset()
//     {
//         if (_stats != null && _stats.Count <= 0)
//         {
//             return;
//         }

//         for (int i = 0; i < _stats.Count; i++)
//         {
//             _stats[i].Reset();
//             _builtStats[i].DrawTexts(_stats[i]);
//         }

//         _statsContainer.Reset();
//         UpdatePointsText();

//         DataLoader.SaveData(_stats);

//         GD.Print("Stats reset");
//     }
// }