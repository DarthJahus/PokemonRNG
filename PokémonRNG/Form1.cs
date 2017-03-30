using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Jahus, 2017
 * This work has not been finished and may never be.
 * If you need parts of this code, feel free to copy them.
 * 
 * This article on Smogon Univerity
 * describes the steps that have been coded here.
 * http://www.smogon.com/ingame/rng/pid_iv_creation
 * 
 * Pushed to GitHub on 2017-03-30 @ 00:57 GMT+1
 * 
 */

namespace PokémonRNG
{
	
	public partial class frmGen : Form
	{
		private bool bDebug = true; // If true, shows the output to the textbox.
		                            // Set to false if you generate more than 100 (10^2)
		private static Random rnd = new Random();
		public frmGen()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Pokémon Creation
			// CSV file
			using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"PocketMonsters.csv"))
			{
				file.WriteLine(String.Format("\"{0}\";\"{1}\";\"{2}\";\"{3}\";\"{4}\";\"{5}\";\"{6}\";\"{7}\";\"{8}\";\"{9}\";\"{10}\";\"{11}\"", "PID", "Species", "Gender", "Ability", "Nature", "HP", "Atk", "Def", "SpAtk", "SpDef", "Speed", "Seed"));
				int max_i = (int)Math.Pow(10, 2); // Define how many Pokémon to generate,
												  // you can go up to 100 000 (10^5) if you don't show the output (bDEBUG = false)
				barProgress.Maximum = max_i;
				for (int i = 0; i < max_i; i++)
				{
					Pokemon NewMonster = new Pokemon("");
					decimal GenderRatio = decimal.Divide(1, 8);
					if (bDebug) { 
						txtSeed.Text = String.Format("0x{0:X}", NewMonster.Seed);
						LogIt(String.Format("{0} = 0x{1:X}", "Seed", NewMonster.SeedInit));
						LogIt(String.Format("{0} = 0x{1:X} ({1:0000000000})", "PID", (UInt32)NewMonster.PID));
						LogIt(String.Format("Nature: {0}", NewMonster.Nature));
						LogIt(string.Format("Gender: {0} ({1} prob.)", NewMonster.Gender, NewMonster.GenderProba));
						LogIt(string.Format("Ability: [{0}]", NewMonster.Ability));
						LogIt("Pokémon stats:");
						LogIt(String.Format("\t{0}   0x{1:X} ({1})", "HP ", NewMonster.IV_HP));
						LogIt(String.Format("\t{0}   0x{1:X} ({1})", "ATK", NewMonster.IV_ATK));
						LogIt(String.Format("\t{0}   0x{1:X} ({1})", "DEF", NewMonster.IV_DEF));
						LogIt(String.Format("\t{0}   0x{1:X} ({1})", "SPE", NewMonster.IV_SPEED));
						LogIt(String.Format("\t{0}   0x{1:X} ({1})", "SPA", NewMonster.IV_SPATK));
						LogIt(String.Format("\t{0}   0x{1:X} ({1})", "SPD", NewMonster.IV_SPDEF));
						LogIt("");
					}
					file.WriteLine(String.Format("\"{0}\";\"{1}\";\"{2}\";\"{3}\";\"{4}\";\"{5}\";\"{6}\";\"{7}\";\"{8}\";\"{9}\";\"{10}\";\"{11}\"", (UInt32)NewMonster.PID, NewMonster.Species, NewMonster.Gender, NewMonster.Ability, NewMonster.Nature, NewMonster.IV_HP, NewMonster.IV_ATK, NewMonster.IV_DEF, NewMonster.IV_SPATK, NewMonster.IV_SPDEF, NewMonster.IV_SPEED, (UInt32)NewMonster.SeedInit));
					barProgress.PerformStep();
				}
			}
			
		}
		public void LogIt(string text)
		{
			// textBox2.Text += text + "\r\n"; // old way, dumb way. Don't use this, it takes too much time.
			textBox2.AppendText(text + "\r\n");
		}
	}

	class Pokemon
	{
		private static Random rnd = new Random();
		public Boolean bDebug = false;
		public readonly string Species;
		public readonly Int32 PID;
		public readonly Int32 SeedInit;
		public readonly Int32 Seed;
		public readonly string Nature;
		public readonly string Gender;
		public readonly decimal GenderProba;
		public readonly int Ability;
		public readonly Int16 IV_HP;
		public readonly Int16 IV_ATK;
		public readonly Int16 IV_DEF;
		public readonly Int16 IV_SPATK;
		public readonly Int16 IV_SPDEF;
		public readonly Int16 IV_SPEED;
		public readonly bool isInitiated;
		protected string[] NatureConsts = new string[] { "Hardy", "Lonely", "Brave", "Adamant", "Naughty", "Bold", "Docile", "Relaxed", "Impish", "Lax", "Timid", "Hasty", "Serious", "Jolly", "Naive", "Modest", "Mild", "Quiet", "Bashful", "Rash", "Calm", "Gentle", "Sassy", "Careful", "Quirky" };

		public Pokemon(string species)
		{
			// Seed
			SeedInit = rnd.Next(Int32.MinValue, Int32.MaxValue);
			Seed = SeedInit;
			isInitiated = true;
			// 1. Generating PID
			Species = species;
			Int16 PID_1 = RandomGenerator(ref Seed); Int16 PID_2 = RandomGenerator(ref Seed);
			PID = (Int32)(PID_2 << 16) | (Int32)PID_1;
			// 2. Nature / Gender / Ability
			string PIDStr = String.Format("{0:0000000000}", ((UInt32)PID).ToString());
			string NatureStr = PIDStr.Substring(PIDStr.Length - 2);
			int NatureInt = int.Parse(NatureStr);
			while (NatureInt > 24)
			{
				NatureInt -= 25;
			}
			Nature = NatureConsts[NatureInt];
			// 3. Gender
			Int32 GenderInt = PID & 0xFF;
			string GenderStr = "Male";
			decimal GenderRatio = decimal.Divide(1, 8); // Change GenderRatio according to species
			if (GenderRatio == 0)
			{
				GenderStr = "Genderless";
			}
			else
			{
				if (GenderInt < Math.Floor(0xFF * GenderRatio))
				{
					GenderStr = "Female";
					GenderRatio = 1 - GenderRatio;
				}
			}
			Gender = GenderStr;
			GenderProba = 1 - GenderRatio;
			// 4. Ability
			Int16 AbilityInt = (Int16)(PID & 0x01);
			Ability = AbilityInt;
			// 5. IVs
			// Method 2, 3 and 4
			// [PID] [PID] [IVs] [IVs] (Method 2)
			// [PID] [PID] [IVs] [xxxx] [IVs] (Method 4)
			// Use method 1 for legendaries, starters, Eevee (FRLG), Castform and Beldum (RSE)
			// method 1 is used for all DP wild Pokémon
			RandomGenerator(ref Seed); // Remove if method 1
			Int16 IV_num_1 = RandomGenerator(ref Seed);
			IV_HP = (Int16)(IV_num_1 & ((Int16)0x001F));
			IV_ATK = (Int16)((IV_num_1 & ((Int16)0x03E0)) >> 5);
			IV_DEF = (Int16)((IV_num_1 & ((Int16)0x7C00)) >> 10);
			Int16 IV_num_2 = RandomGenerator(ref Seed);
			IV_SPEED = (Int16)(IV_num_2 & ((Int16)0x001F));
			IV_SPATK = (Int16)((IV_num_1 & ((Int16)0x03E0)) >> 5);
			IV_SPDEF = (Int16)((IV_num_1 & ((Int16)0x7C00)) >> 10);
		}

		public Int16 RandomGenerator(ref Int32 rSeed)
		{
			Int64 NewSeed = Seed * 0x41C64E6D + 0x6073;
			rSeed = (Int32)(NewSeed & 0xFFFFFFFF);
			Int16 RandNum = (Int16)((Seed & 0xFFFF0000) >> 16);
			return RandNum;
		}
	}	
}
