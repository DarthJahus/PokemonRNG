namespace PokémonRNG
{
	partial class frmGen
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Species = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Nature = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.HP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ATK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DEF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SPATK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SPDEF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SPEED = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txtSeed = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.barProgress = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PID,
            this.Species,
            this.Gender,
            this.Nature,
            this.HP,
            this.ATK,
            this.DEF,
            this.SPATK,
            this.SPDEF,
            this.SPEED});
			this.listView1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView1.Location = new System.Drawing.Point(12, 41);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(870, 257);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// PID
			// 
			this.PID.Text = "PID";
			// 
			// Species
			// 
			this.Species.Text = "Species";
			this.Species.Width = 120;
			// 
			// Gender
			// 
			this.Gender.Text = "Gender";
			// 
			// Nature
			// 
			this.Nature.Text = "Nature";
			// 
			// HP
			// 
			this.HP.Text = "HP";
			this.HP.Width = 45;
			// 
			// ATK
			// 
			this.ATK.Text = "Atk";
			this.ATK.Width = 45;
			// 
			// DEF
			// 
			this.DEF.Text = "Def";
			this.DEF.Width = 45;
			// 
			// SPATK
			// 
			this.SPATK.Text = "SpAtk";
			this.SPATK.Width = 51;
			// 
			// SPDEF
			// 
			this.SPDEF.Text = "SpDef";
			this.SPDEF.Width = 48;
			// 
			// SPEED
			// 
			this.SPEED.Text = "Speed";
			this.SPEED.Width = 50;
			// 
			// txtSeed
			// 
			this.txtSeed.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSeed.Location = new System.Drawing.Point(782, 13);
			this.txtSeed.Name = "txtSeed";
			this.txtSeed.Size = new System.Drawing.Size(100, 23);
			this.txtSeed.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(744, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Seed";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.Black;
			this.textBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.ForeColor = System.Drawing.Color.PaleGreen;
			this.textBox2.Location = new System.Drawing.Point(12, 304);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox2.Size = new System.Drawing.Size(870, 249);
			this.textBox2.TabIndex = 4;
			// 
			// barProgress
			// 
			this.barProgress.Location = new System.Drawing.Point(93, 12);
			this.barProgress.Name = "barProgress";
			this.barProgress.Size = new System.Drawing.Size(645, 23);
			this.barProgress.Step = 1;
			this.barProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.barProgress.TabIndex = 5;
			this.barProgress.UseWaitCursor = true;
			// 
			// frmGen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(894, 565);
			this.Controls.Add(this.barProgress);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSeed);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.button1);
			this.Name = "frmGen";
			this.Text = "PokémonRNG";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.TextBox txtSeed;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ColumnHeader PID;
		private System.Windows.Forms.ColumnHeader Species;
		private System.Windows.Forms.ColumnHeader Gender;
		private System.Windows.Forms.ColumnHeader Nature;
		private System.Windows.Forms.ColumnHeader HP;
		private System.Windows.Forms.ColumnHeader ATK;
		private System.Windows.Forms.ColumnHeader DEF;
		private System.Windows.Forms.ColumnHeader SPATK;
		private System.Windows.Forms.ColumnHeader SPDEF;
		private System.Windows.Forms.ColumnHeader SPEED;
		private System.Windows.Forms.ProgressBar barProgress;
	}
}

