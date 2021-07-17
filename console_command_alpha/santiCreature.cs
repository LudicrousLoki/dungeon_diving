using Godot;
using System;

public class santiCreature : Node2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	private int stat_agi;
	//agi = agility, this is the dodge stat impacting base ac and reflex saves
	private int stat_fin;
	//fin = finnesse, this is the stat that is used for skills and attacks with "dexterity"
	private int stat_vit;
	//vit = vitality, this is like strength + consitiution in most systems, used for damage and hit point scaling and fortitude saves
	private int stat_cha;
	//cha = charisma, this is used for skills and certain types of spellcasting and will saves
	private int stat_int;
	//int = intelligance, this is used for skills, number of skills and certain types of spellcasting
	private int stat_wis;
	//wis = wisdom, this is used for skills certain spellcasting and perception which rules who acts first on first turn of combat
	
	public int askAction(){
		
		
	}
	
	private int takeDamage(int damage, int toHit){
		
	}

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
