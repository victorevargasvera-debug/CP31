namespace MackinawCPS.InitializationScreen
{
	// Token: 0x0200007A RID: 122
	public partial class SplashScreen : global::System.Windows.Forms.Form
	{
		// Token: 0x0600054A RID: 1354 RVA: 0x000E876C File Offset: 0x000E696C
		protected override void Dispose(bool disposing)
		{
			short num = (short)166068224;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 1:
					goto IL_14F;
				case 2:
					if (this.components != null)
					{
						num = (short)751960065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_154;
				case 3:
				{
					num = (short)1759643506;
					short num3 = num;
					num = (short)962004850;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14F;
					default:
					{
						num = (short)404357120;
						if (num != 0)
						{
						}
						num = (short)171245568;
						short num4 = num;
						num = (short)69337089;
						if (num != 0)
						{
						}
						num = (short)382795778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 4:
					goto IL_75;
				}
				IL_3A:
				if (disposing)
				{
					num = (short)766312451;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_14F:
				this.components.Dispose();
				num = (short)221642756;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_75:
			IL_154:
			base.Dispose(disposing);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x000E88D4 File Offset: 0x000E6AD4
		private void InitializeComponent()
		{
			int a_ = 16;
			short num = (short)1623148569;
			short num2 = num;
			num = (short)1764050969;
			switch (num2 == num)
			{
			}
			num = (short)1411710976;
			short num3 = num;
			num = (short)1280376832;
			if (num != 0)
			{
			}
			num = (short)117243905;
			if (num != 0)
			{
			}
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MackinawCPS.InitializationScreen.SplashScreen));
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel2 = new global::System.Windows.Forms.TableLayoutPanel();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.versionLabel = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.timingLabel = new global::System.Windows.Forms.Label();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel2.BackColor = global::System.Drawing.Color.Transparent;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("蓯鏱雳髵鷷뛹鷻蟽濿省瀃嘅椇搉椋戍∏", a_);
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new global::System.Drawing.Size(676, 68);
			this.tableLayoutPanel2.TabIndex = 1;
			this.label3.AutoSize = true;
			this.label3.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.label3.Font = new global::System.Drawing.Font(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("맯鿱蓳韵鯷軹", a_), 42f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new global::System.Drawing.Point(3, 0);
			this.label3.Name = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("鳯鏱雳鏵铷짹", a_);
			this.label3.Size = new global::System.Drawing.Size(670, 68);
			this.label3.TabIndex = 0;
			this.label3.Text = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뇯ꋱ곳훵믷꫹꿻", a_);
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.BackColor = global::System.Drawing.Color.Black;
			this.label2.Font = new global::System.Drawing.Font(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뷯鯱音蓵韷觹鏻飽瓿∁圃朅昇礉Ⰻ崍甏怑紓瀕", a_), 6.5f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.InactiveCaption;
			this.label2.Location = new global::System.Drawing.Point(25, 397);
			this.label2.Name = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("鳯鏱雳鏵铷죹", a_);
			this.label2.Size = new global::System.Drawing.Size(525, 10);
			this.label2.TabIndex = 0;
			this.label2.Text = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("姯틱웳웵짷쏹\udcfb돽俿嘁䬃吅䜇䘉䴋⸍䌏崑堓䌕䰗匙匛倝猟มУ漥昧椩ȫอု戱昳礵氷缹缻樽Կف摃хᅇ橉᥋恍͏籑瑓᝕ᙗṙ籛᝝⹟㙡Ⅳ㑥♧⭩㡫❭㽯㱱㕳㩵塷㥹㍻⹽\ud97f킁춃솅삇\ude89겋슍톏양잓", a_);
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.versionLabel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.versionLabel.AutoSize = true;
			this.versionLabel.Font = new global::System.Drawing.Font(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뷯鯱音蓵韷觹鏻飽瓿∁圃朅昇礉Ⰻ崍甏怑紓瀕", a_), 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.versionLabel.ForeColor = global::System.Drawing.Color.FromArgb(0, 175, 209);
			this.versionLabel.Location = new global::System.Drawing.Point(415, 298);
			this.versionLabel.Name = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("蛯韱蛳藵釷闹鋻닽懿态愃樅", a_);
			this.versionLabel.Size = new global::System.Drawing.Size(135, 16);
			this.versionLabel.TabIndex = 0;
			this.versionLabel.Text = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꛯ韱蛳藵釷闹鋻쓽⃿威尃⠅倇刉∋嘍䠏㰑䴓伕", a_);
			this.panel1.BackColor = global::System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.timingLabel);
			this.panel1.Controls.Add(this.versionLabel);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("胯鏱髳鏵铷쯹", a_);
			this.panel1.Size = new global::System.Drawing.Size(578, 439);
			this.panel1.TabIndex = 1;
			this.timingLabel.AutoSize = true;
			this.timingLabel.ForeColor = global::System.Drawing.SystemColors.Window;
			this.timingLabel.Location = new global::System.Drawing.Point(22, 357);
			this.timingLabel.Name = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("蓯鯱駳鿵雷鷹냻鿽拿朁栃", a_);
			this.timingLabel.Size = new global::System.Drawing.Size(104, 13);
			this.timingLabel.TabIndex = 1;
			this.timingLabel.Text = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꓯ鯱駳鿵雷鷹\udcfb닽懿态愃樅⠇䈉攋樍琏眑稓", a_);
			this.timingLabel.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("퓯蛱鳳鿵请퓹뻻鿽揿椁挃琅朇缉戋樍夏缑甓焕紗", a_));
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(578, 439);
			base.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꏯ英飳韵请鋹꿻鷽狿朁愃栅", a_);
			base.Opacity = 0.99;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꏯ英飳韵请鋹꿻鷽狿朁愃栅㨇", a_);
			base.TopMost = true;
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000312 RID: 786
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000313 RID: 787
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000314 RID: 788
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

		// Token: 0x04000315 RID: 789
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000316 RID: 790
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000317 RID: 791
		private global::System.Windows.Forms.Label versionLabel;

		// Token: 0x04000318 RID: 792
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000319 RID: 793
		private global::System.Windows.Forms.Label timingLabel;
	}
}
