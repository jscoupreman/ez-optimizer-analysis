using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CyberPunk_EZ_Optimizer
{
	// Token: 0x02000002 RID: 2
	public class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		private void button1_Click(object sender, EventArgs e)
		{
			bool flag = !Directory.Exists(".\\engine\\config\\platform\\pc");
			if (flag)
			{
				MessageBox.Show("Place the EZ Optimizer into root(main) Cyberpunk 2077 folder!", "Wrong folder!");
			}
			string path = ".\\\\engine\\\\config\\\\platform\\\\pc\\\\user.ini";
			FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			streamWriter.WriteLine("[Developer/FeatureToggles]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("Antialiasing = True");
			streamWriter.WriteLine("Bloom = True");
			streamWriter.WriteLine("CharacterLightBlockers = False");
			streamWriter.WriteLine("CharacterRimEnhancement = False");
			streamWriter.WriteLine("CharacterSubsurfaceScattering = True");
			streamWriter.WriteLine("ChromaticAberration = True");
			streamWriter.WriteLine("ConstrastAdaptiveSharpening = True");
			streamWriter.WriteLine("ContactShadows = True");
			streamWriter.WriteLine("DepthOfField = True");
			streamWriter.WriteLine("DistantFog = False");
			streamWriter.WriteLine("DistantGI = False");
			streamWriter.WriteLine("DistantShadows = True");
			streamWriter.WriteLine("DistantVolFog = False");
			streamWriter.WriteLine("DynamicDecals = True");
			streamWriter.WriteLine("FilmGrain = True");
			streamWriter.WriteLine("GlobalIllumination = True");
			streamWriter.WriteLine("Hair = True");
			streamWriter.WriteLine("ImageBasedFlares = True");
			streamWriter.WriteLine("LocalShadows = True");
			streamWriter.WriteLine("MotionBlur = False");
			streamWriter.WriteLine("RainMap = True");
			streamWriter.WriteLine("RuntimeTangentUpdate = False");
			streamWriter.WriteLine("ScreenSpaceHeatHaze = False");
			streamWriter.WriteLine("ScreenSpacePlanarReflection = False");
			streamWriter.WriteLine("ScreenSpaceRain = False");
			streamWriter.WriteLine("ScreenSpaceReflection = False");
			streamWriter.WriteLine("ScreenSpaceUnderwater = False");
			streamWriter.WriteLine("SSAO = True");
			streamWriter.WriteLine("VolumetricClouds = False");
			streamWriter.WriteLine("VolumetricFog = False");
			streamWriter.WriteLine("Weather = True");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering/AsyncCompute]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("BuildDepthChain = False");
			streamWriter.WriteLine("DynamicTexture = False");
			streamWriter.WriteLine("Enable = False");
			streamWriter.WriteLine("FlattenNormals = False");
			streamWriter.WriteLine("LutGeneration = False");
			streamWriter.WriteLine("RaytraceASBuild = False");
			streamWriter.WriteLine("SSAO = False");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering/FrostedGlass]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("GlassUseMipChain = True");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("RainMapProxySorting = True");
			streamWriter.WriteLine("UseExperimentalVolFog = False");
			streamWriter.WriteLine("UseSkinningLOD = True");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering/Shadows]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("CascadeFitToWorstCase = True");
			streamWriter.WriteLine("CascadeUseBackfacesAsCullingPlanes = True");
			streamWriter.WriteLine("");
			streamWriter.Flush();
			streamWriter.Close();
			fileStream.Close();
			MessageBox.Show("Max Boost profile applied. Enjoy :)", "EZ Optimizer");
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002398 File Offset: 0x00000598
		private void button2_Click(object sender, EventArgs e)
		{
			bool flag = !Directory.Exists(".\\engine\\config\\platform\\pc");
			if (flag)
			{
				MessageBox.Show("Place the EZ Optimizer into root(main) Cyberpunk 2077 folder!", "Wrong folder!");
			}
			string path = ".\\\\engine\\\\config\\\\platform\\\\pc\\\\user.ini";
			FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			streamWriter.WriteLine("[Developer/FeatureToggles]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("Antialiasing = True");
			streamWriter.WriteLine("Bloom = True");
			streamWriter.WriteLine("CharacterLightBlockers = True");
			streamWriter.WriteLine("CharacterRimEnhancement = True");
			streamWriter.WriteLine("CharacterSubsurfaceScattering = True");
			streamWriter.WriteLine("ChromaticAberration = True");
			streamWriter.WriteLine("ConstrastAdaptiveSharpening = True");
			streamWriter.WriteLine("ContactShadows = True");
			streamWriter.WriteLine("DepthOfField = True");
			streamWriter.WriteLine("DistantFog = True");
			streamWriter.WriteLine("DistantGI = True");
			streamWriter.WriteLine("DistantShadows = True");
			streamWriter.WriteLine("DistantVolFog = True");
			streamWriter.WriteLine("DynamicDecals = True");
			streamWriter.WriteLine("FilmGrain = True");
			streamWriter.WriteLine("GlobalIllumination = True");
			streamWriter.WriteLine("Hair = True");
			streamWriter.WriteLine("ImageBasedFlares = True");
			streamWriter.WriteLine("LocalShadows = True");
			streamWriter.WriteLine("MotionBlur = True");
			streamWriter.WriteLine("RainMap = True");
			streamWriter.WriteLine("RuntimeTangentUpdate = True");
			streamWriter.WriteLine("ScreenSpaceHeatHaze = True");
			streamWriter.WriteLine("ScreenSpacePlanarReflection = True");
			streamWriter.WriteLine("ScreenSpaceRain = True");
			streamWriter.WriteLine("ScreenSpaceReflection = True");
			streamWriter.WriteLine("ScreenSpaceUnderwater = True");
			streamWriter.WriteLine("SSAO = True");
			streamWriter.WriteLine("VolumetricClouds = True");
			streamWriter.WriteLine("VolumetricFog = False");
			streamWriter.WriteLine("Weather = True");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering/AsyncCompute]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("BuildDepthChain = False");
			streamWriter.WriteLine("DynamicTexture = False");
			streamWriter.WriteLine("Enable = False");
			streamWriter.WriteLine("FlattenNormals = False");
			streamWriter.WriteLine("LutGeneration = False");
			streamWriter.WriteLine("RaytraceASBuild = False");
			streamWriter.WriteLine("SSAO = False");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering/FrostedGlass]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("GlassUseMipChain = True");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("RainMapProxySorting = True");
			streamWriter.WriteLine("UseExperimentalVolFog = True");
			streamWriter.WriteLine("UseSkinningLOD = True");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering/Shadows]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("CascadeFitToWorstCase = True");
			streamWriter.WriteLine("CascadeUseBackfacesAsCullingPlanes = True");
			streamWriter.WriteLine("");
			streamWriter.Flush();
			streamWriter.Close();
			fileStream.Close();
			MessageBox.Show("Async Compute Disabled", "EZ Optimizer");
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000026C8 File Offset: 0x000008C8
		private void button5_Click(object sender, EventArgs e)
		{
			bool flag = !Directory.Exists(".\\engine\\config\\platform\\pc");
			if (flag)
			{
				MessageBox.Show("Place the EZ Optimizer into root(main) Cyberpunk 2077 folder!", "Wrong folder!");
			}
			string path = ".\\\\engine\\\\config\\\\platform\\\\pc\\\\user.ini";
			FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			streamWriter.WriteLine("[Developer/FeatureToggles]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("Antialiasing = True");
			streamWriter.WriteLine("Bloom = True");
			streamWriter.WriteLine("CharacterLightBlockers = False");
			streamWriter.WriteLine("CharacterRimEnhancement = False");
			streamWriter.WriteLine("CharacterSubsurfaceScattering = True");
			streamWriter.WriteLine("ChromaticAberration = True");
			streamWriter.WriteLine("ConstrastAdaptiveSharpening = True");
			streamWriter.WriteLine("ContactShadows = True");
			streamWriter.WriteLine("DepthOfField = True");
			streamWriter.WriteLine("DistantFog = False");
			streamWriter.WriteLine("DistantGI = False");
			streamWriter.WriteLine("DistantShadows = True");
			streamWriter.WriteLine("DistantVolFog = False");
			streamWriter.WriteLine("DynamicDecals = True");
			streamWriter.WriteLine("FilmGrain = True");
			streamWriter.WriteLine("GlobalIllumination = True");
			streamWriter.WriteLine("Hair = True");
			streamWriter.WriteLine("ImageBasedFlares = True");
			streamWriter.WriteLine("LocalShadows = True");
			streamWriter.WriteLine("MotionBlur = False");
			streamWriter.WriteLine("RainMap = True");
			streamWriter.WriteLine("RuntimeTangentUpdate = False");
			streamWriter.WriteLine("ScreenSpaceHeatHaze = False");
			streamWriter.WriteLine("ScreenSpacePlanarReflection = False");
			streamWriter.WriteLine("ScreenSpaceRain = False");
			streamWriter.WriteLine("ScreenSpaceReflection = False");
			streamWriter.WriteLine("ScreenSpaceUnderwater = False");
			streamWriter.WriteLine("SSAO = True");
			streamWriter.WriteLine("VolumetricClouds = False");
			streamWriter.WriteLine("VolumetricFog = True");
			streamWriter.WriteLine("Weather = True");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering/AsyncCompute]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("BuildDepthChain = False");
			streamWriter.WriteLine("DynamicTexture = False");
			streamWriter.WriteLine("Enable = False");
			streamWriter.WriteLine("FlattenNormals = False");
			streamWriter.WriteLine("LutGeneration = False");
			streamWriter.WriteLine("RaytraceASBuild = False");
			streamWriter.WriteLine("SSAO = False");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering/FrostedGlass]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("GlassUseMipChain = True");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("RainMapProxySorting = True");
			streamWriter.WriteLine("UseExperimentalVolFog = False");
			streamWriter.WriteLine("UseSkinningLOD = True");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("[Rendering/Shadows]");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("CascadeFitToWorstCase = True");
			streamWriter.WriteLine("CascadeUseBackfacesAsCullingPlanes = True");
			streamWriter.WriteLine("");
			streamWriter.Flush();
			streamWriter.Close();
			fileStream.Close();
			MessageBox.Show("Balanced profile applied. Enjoy :)", "EZ Optimizer");
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000029F8 File Offset: 0x00000BF8
		private void button3_Click(object sender, EventArgs e)
		{
			bool flag = !Directory.Exists(".\\engine\\config\\platform\\pc");
			if (flag)
			{
				MessageBox.Show("Place the EZ Optimizer into root(main) Cyberpunk 2077 folder!", "Wrong folder!");
			}
			string path = ".\\\\engine\\\\config\\\\platform\\\\pc\\\\user.ini";
			File.Delete(path);
			MessageBox.Show("Stock settiggs applied!", "EZ Optimizer");
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002A46 File Offset: 0x00000C46
		private void button9_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/c/EZPCTECH?sub_confirmation=1");
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002A54 File Offset: 0x00000C54
		private void button4_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.paypal.com/pools/c/8mWDayLzDh");
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002A62 File Offset: 0x00000C62
		private void label6_Click(object sender, EventArgs e)
		{
			Process.Start("https://youtu.be/ZfzUoDAEqJY");
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002A70 File Offset: 0x00000C70
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002AA8 File Offset: 0x00000CA8
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			this.button1 = new Button();
			this.button2 = new Button();
			this.button3 = new Button();
			this.label1 = new Label();
			this.label2 = new Label();
			this.label3 = new Label();
			this.button9 = new Button();
			this.label4 = new Label();
			this.label5 = new Label();
			this.button4 = new Button();
			this.groupBox1 = new GroupBox();
			this.label7 = new Label();
			this.button5 = new Button();
			this.label6 = new Label();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.button1.Cursor = Cursors.Hand;
			this.button1.Font = new Font("Bebas Neue", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button1.Location = new Point(563, 29);
			this.button1.Margin = new Padding(2, 3, 2, 3);
			this.button1.Name = "button1";
			this.button1.Size = new Size(144, 40);
			this.button1.TabIndex = 0;
			this.button1.Text = "Max Boost";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += this.button1_Click;
			this.button2.Cursor = Cursors.Hand;
			this.button2.Font = new Font("Bebas Neue", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button2.Location = new Point(563, 211);
			this.button2.Margin = new Padding(2, 3, 2, 3);
			this.button2.Name = "button2";
			this.button2.Size = new Size(144, 40);
			this.button2.TabIndex = 1;
			this.button2.Text = "DISABLE ASYNC COMPUTE";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += this.button2_Click;
			this.button3.Cursor = Cursors.Hand;
			this.button3.Font = new Font("Bebas Neue", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button3.Location = new Point(563, 152);
			this.button3.Margin = new Padding(2, 3, 2, 3);
			this.button3.Name = "button3";
			this.button3.Size = new Size(144, 40);
			this.button3.TabIndex = 2;
			this.button3.Text = "DEFAULT";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += this.button3_Click;
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Neo Sans", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.Yellow;
			this.label1.Location = new Point(17, 40);
			this.label1.Margin = new Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(541, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Optimize all parameters for Max FPS (Recommended for older systems)";
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Neo Sans", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.Yellow;
			this.label2.Location = new Point(17, 222);
			this.label2.Margin = new Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new Size(534, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "Stock, only disables Async Compute (Not recommended for RTX GPUs)";
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Neo Sans", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.Yellow;
			this.label3.Location = new Point(17, 162);
			this.label3.Margin = new Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new Size(322, 19);
			this.label3.TabIndex = 5;
			this.label3.Text = "Resets all settings to default parameters";
			this.button9.BackColor = Color.Red;
			this.button9.Cursor = Cursors.Hand;
			this.button9.FlatAppearance.BorderColor = Color.Black;
			this.button9.Font = new Font("Arial Narrow", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button9.ForeColor = SystemColors.ControlLightLight;
			this.button9.Location = new Point(575, 302);
			this.button9.Margin = new Padding(2, 3, 2, 3);
			this.button9.Name = "button9";
			this.button9.Size = new Size(144, 43);
			this.button9.TabIndex = 18;
			this.button9.Text = "  ►";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += this.button9_Click;
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Neo Sans", 9.749999f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label4.ForeColor = SystemColors.Control;
			this.label4.Location = new Point(17, 320);
			this.label4.Name = "label4";
			this.label4.Size = new Size(553, 16);
			this.label4.TabIndex = 19;
			this.label4.Text = "If my app helped you and you want to say \"THANKS\" - subscribe to my YT channel!";
			this.label5.AutoSize = true;
			this.label5.ForeColor = SystemColors.ButtonShadow;
			this.label5.Location = new Point(149, 412);
			this.label5.Name = "label5";
			this.label5.Size = new Size(390, 14);
			this.label5.TabIndex = 20;
			this.label5.Text = "©2020-2021 Oleg Kasumov aka CodeZ1LLa/EZ-PC Tech. All Rights Reserved";
			this.button4.BackColor = Color.DodgerBlue;
			this.button4.Cursor = Cursors.Hand;
			this.button4.Font = new Font("Neo Sans", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.button4.Location = new Point(575, 351);
			this.button4.Name = "button4";
			this.button4.Size = new Size(144, 42);
			this.button4.TabIndex = 21;
			this.button4.Text = "PayPal ☺";
			this.button4.TextImageRelation = TextImageRelation.ImageBeforeText;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += this.button4_Click;
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.button5);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size(726, 266);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Neo Sans", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label7.ForeColor = Color.Yellow;
			this.label7.Location = new Point(17, 98);
			this.label7.Margin = new Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new Size(466, 19);
			this.label7.TabIndex = 7;
			this.label7.Text = "Balanced parameters for decent quality and good FPS boost ";
			this.button5.Font = new Font("Bebas Neue", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button5.Location = new Point(563, 89);
			this.button5.Name = "button5";
			this.button5.Size = new Size(144, 40);
			this.button5.TabIndex = 6;
			this.button5.Text = "BALANCED";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += this.button5_Click;
			this.label6.AutoSize = true;
			this.label6.BackColor = Color.Transparent;
			this.label6.Cursor = Cursors.Hand;
			this.label6.Font = new Font("Neo Sans", 9.749999f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label6.ForeColor = SystemColors.MenuHighlight;
			this.label6.Location = new Point(245, 377);
			this.label6.Name = "label6";
			this.label6.Size = new Size(223, 16);
			this.label6.TabIndex = 23;
			this.label6.Text = "CLICK TO WATCH THE TUTORIAL";
			this.label6.Click += this.label6_Click;
			base.AutoScaleDimensions = new SizeF(6f, 14f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Black;
			base.ClientSize = new Size(749, 437);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button9);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.groupBox1);
			this.Font = new Font("Neo Sans", 8.249999f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new Padding(2, 3, 2, 3);
			base.Name = "Form1";
			base.Opacity = 0.9;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "EZ Optimizer V1.0 by CodeZ1LLa(c) for CyberPunk 2077";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private IContainer components = null;

		// Token: 0x04000002 RID: 2
		private Button button1;

		// Token: 0x04000003 RID: 3
		private Button button2;

		// Token: 0x04000004 RID: 4
		private Button button3;

		// Token: 0x04000005 RID: 5
		private Label label1;

		// Token: 0x04000006 RID: 6
		private Label label2;

		// Token: 0x04000007 RID: 7
		private Label label3;

		// Token: 0x04000008 RID: 8
		private Button button9;

		// Token: 0x04000009 RID: 9
		private Label label4;

		// Token: 0x0400000A RID: 10
		private Label label5;

		// Token: 0x0400000B RID: 11
		private Button button4;

		// Token: 0x0400000C RID: 12
		private GroupBox groupBox1;

		// Token: 0x0400000D RID: 13
		private Label label6;

		// Token: 0x0400000E RID: 14
		private Label label7;

		// Token: 0x0400000F RID: 15
		private Button button5;
	}
}