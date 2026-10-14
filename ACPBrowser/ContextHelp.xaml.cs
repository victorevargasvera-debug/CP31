using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using CefSharp;
using CefSharp.Wpf;

namespace ACPBrowser
{
	// Token: 0x02000003 RID: 3
	public partial class ContextHelp : UserControl
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		static ContextHelp()
		{
			short num = (short)445775872;
			short num2 = num;
			num = (short)1850394715;
			short num3 = num;
			num = (short)1474938971;
			switch (num3 == num)
			{
			}
			num = (short)692846592;
			if (num != 0)
			{
			}
			num = (short)1634598913;
			if (num != 0)
			{
			}
			Utility.b();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021CC File Offset: 0x000003CC
		public ContextHelp()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021F0 File Offset: 0x000003F0
		public void ShowSingleFileHelp(string fileName)
		{
			short num = (short)1041432576;
			short num2 = num;
			if (!string.IsNullOrEmpty(fileName))
			{
				num = (short)1996648618;
				short num3 = num;
				num = (short)1268281514;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)375980032;
					if (num != 0)
					{
					}
					string a_ = HelpFilePathProvider.BuildPathForHelpByTagContextMenu(fileName);
					this.a(a_);
					return;
				}
				}
			}
			num = (short)126353409;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022B4 File Offset: 0x000004B4
		public void ShowMultipleFileHelp(string fileName)
		{
			short num = (short)959250432;
			short num2 = num;
			num = (short)938606593;
			if (num != 0)
			{
			}
			if (!string.IsNullOrEmpty(fileName))
			{
				num = (short)351722607;
				short num3 = num;
				num = (short)1298324591;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2016477184;
					if (num != 0)
					{
					}
					string a_ = HelpFilePathProvider.BuildPathForHelpByFileContextMenu(fileName);
					this.a(a_);
					return;
				}
				}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002378 File Offset: 0x00000578
		private void a(string A_0)
		{
			int a_ = 19;
			int num;
			short num2;
			ContextHelp.a a;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						if (!string.IsNullOrEmpty(A_0))
						{
							num2 = (short)17629187;
							num = (int)((IntPtr)num2);
							continue;
						}
						return;
					case 1:
					{
						num2 = (short)1815150593;
						if (num2 != 0)
						{
						}
						num2 = (short)1346720411;
						short num3 = num2;
						num2 = (short)1136415387;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3A;
						default:
							num2 = (short)1217069056;
							if (num2 != 0)
							{
							}
							try
							{
								this.b.Load(A_0);
								this.a = A_0;
								a.b = HelpFilePathProvider.b("愄栆樈縊怌樎缐朒㬔瀖簘漚堜猞䐠丢䀤䤦崨堪漬嘮攰刲刴礶堸嘺堼᜾晀⭂⁄♆ⵈ⹊㽌桎硐ࡒ敔੖睘⥚㡜㉞๠ᕢd佦䁨偪䵬୮Ṱၲt᩶ᱸᕺॼ兾슆ﾐ햖쾚ﲜ슢좤슦膨貪쮬삮\udeb0잲킴얶麸銺达鳀럄ꋆ꓈꓊믌꫎類㮝돖뛘룚꣜닞蓠跢釤짦軨軪駬ꫮ鷰雲飴鋶韸迺軼뷾砀䀂椄昆稈砊䌌渎簐瘒㴔〖樘眚琜笞䐠ย䜤匦䜨పЬ琮İ渲᬴䔶尸嘺刼䤾⑀歂汄籆ⵈ⑊⹌㩎㱐㙒㭔⍖睘㱚㡜⭞①རd੦౨ժᥬᱮ㍰ੲ㙴᭶ᡸࡺ๼ㅾ꾆꺈年벐杖練漢쒠톢芤躦鮪膮쎰횲\ud8b4\ud8b6쾸\udeba閼难變Ꟃ꫄꓆볈ꛊ꣌ꇎꗐ﷒닔닖귘黚뇜뫞賠蛢诤鏦髨ꧪ铬곮鷰鋲蛴蓶럸髺郼髾⤀␂昄栆月缊栌愎攐㸒瘔砖眘漚簜瘞传䘢圤&(瀪ᴬ爮ἰ䀲䄴丶唸帺ጼ圾⑀⩂≄⽆㵈歊灌潎癐㉒⁔⍖㙘籚晜㭞๠bၤ੦౨ժᥬ䅮ᙰᙲŴ㉶ᕸṺၼ᩾얆좊\udb94ﺚ떜뢞슠첢쮤펦좨슪쎬쪮쎰钲鲴覸鎼첾뗀뫂꧄ꋆꛊ곌뷎뛐뫒믔ﯚ﫜퇠鏢鷤샦틨쯪", a_);
								this.b.LoadingStateChanged += a.c;
								return;
							}
							catch (Exception)
							{
								return;
							}
							goto IL_E3;
						}
						break;
					}
					case 2:
						return;
					case 3:
					{
						num2 = (short)1552941056;
						short num4 = num2;
						num2 = (short)606797828;
						num = (int)((IntPtr)num2);
						continue;
					}
					case 4:
						if (this.a.Equals(A_0))
						{
							num2 = (short)818675714;
							num = (int)((IntPtr)num2);
							continue;
						}
						goto IL_E3;
					}
					goto IL_2D;
					IL_E3:
					num2 = (short)1360134145;
					num = (int)((IntPtr)num2);
				}
				return;
			}
			IL_2D:
			a = new ContextHelp.a();
			a.a = this;
			IL_3A:
			num2 = (short)66912256;
			num = (int)((IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x04000003 RID: 3
		private string a = string.Empty;

		// Token: 0x02000004 RID: 4
		[CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600000C RID: 12 RVA: 0x0000270C File Offset: 0x0000090C
			internal void c(object A_0, LoadingStateChangedEventArgs A_1)
			{
				short num = (short)375259138;
				int num2 = (int)((IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.a.b.ExecuteScriptAsyncWhenPageLoaded(this.b, true);
						num = (short)524419073;
						num2 = (int)((IntPtr)num);
						continue;
					case 1:
						goto IL_F6;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					num = (short)376438785;
					if (num != 0)
					{
					}
					if (A_1.IsLoading)
					{
						break;
					}
					num = (short)375374404;
					short num3 = num;
					num = (short)1981334084;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F8;
					default:
						num = (short)543031296;
						if (num != 0)
						{
						}
						num = (short)954007552;
						num2 = (int)((IntPtr)num);
						break;
					}
				}
				IL_F6:
				IL_F8:
				num = (short)544866304;
				short num4 = num;
			}

			// Token: 0x04000006 RID: 6
			public ContextHelp a;

			// Token: 0x04000007 RID: 7
			public string b;
		}
	}
}
