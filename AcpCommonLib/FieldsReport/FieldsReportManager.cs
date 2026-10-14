using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Threading;
using AcpCommonLib.Exceptions;

namespace AcpCommonLib.FieldsReport
{
	// Token: 0x02000046 RID: 70
	public class FieldsReportManager : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600027E RID: 638 RVA: 0x00018958 File Offset: 0x00016B58
		// (remove) Token: 0x0600027F RID: 639 RVA: 0x00018A90 File Offset: 0x00016C90
		public event global::AcpCommonLib.FieldsReport.NotifyFieldsReportChangedEventHandler NotifyFieldsReportChangedEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::AcpCommonLib.FieldsReport.NotifyFieldsReportChangedEventHandler notifyFieldsReportChangedEventHandler;
				for (;;)
				{
					IL_0A:
					global::AcpCommonLib.FieldsReport.NotifyFieldsReportChangedEventHandler notifyFieldsReportChangedEventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						IL_38:
						goto IL_3A;
					case 2:
					{
						num2 = (short)217382912;
						short num3 = num2;
						if (notifyFieldsReportChangedEventHandler == notifyFieldsReportChangedEventHandler2)
						{
							num2 = (short)2027552769;
							if (num2 != 0)
							{
							}
							num2 = (short)595329024;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3A;
					}
					}
					goto IL_1C;
					IL_3A:
					notifyFieldsReportChangedEventHandler2 = notifyFieldsReportChangedEventHandler;
					global::AcpCommonLib.FieldsReport.NotifyFieldsReportChangedEventHandler value2 = (global::AcpCommonLib.FieldsReport.NotifyFieldsReportChangedEventHandler)global::System.Delegate.Combine(notifyFieldsReportChangedEventHandler2, value);
					notifyFieldsReportChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpCommonLib.FieldsReport.NotifyFieldsReportChangedEventHandler>(ref this.f, value2, notifyFieldsReportChangedEventHandler2);
					num2 = (short)1735162873;
					short num4 = num2;
					num2 = (short)1436515321;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_38;
					default:
						num2 = (short)1262419968;
						if (num2 != 0)
						{
						}
						num2 = (short)586153986;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				return;
				IL_1C:
				notifyFieldsReportChangedEventHandler = this.f;
				num2 = (short)555089921;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::AcpCommonLib.FieldsReport.NotifyFieldsReportChangedEventHandler notifyFieldsReportChangedEventHandler;
				for (;;)
				{
					IL_0A:
					global::AcpCommonLib.FieldsReport.NotifyFieldsReportChangedEventHandler notifyFieldsReportChangedEventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						IL_37:
						num2 = (short)1915420673;
						if (num2 != 0)
						{
						}
						goto IL_60;
					case 2:
						if (notifyFieldsReportChangedEventHandler == notifyFieldsReportChangedEventHandler2)
						{
							num2 = (short)20971520;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_60;
					}
					goto IL_1C;
					IL_60:
					notifyFieldsReportChangedEventHandler2 = notifyFieldsReportChangedEventHandler;
					global::AcpCommonLib.FieldsReport.NotifyFieldsReportChangedEventHandler value2 = (global::AcpCommonLib.FieldsReport.NotifyFieldsReportChangedEventHandler)global::System.Delegate.Remove(notifyFieldsReportChangedEventHandler2, value);
					notifyFieldsReportChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpCommonLib.FieldsReport.NotifyFieldsReportChangedEventHandler>(ref this.f, value2, notifyFieldsReportChangedEventHandler2);
					num2 = (short)993779187;
					short num3 = num2;
					num2 = (short)1883037171;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_37;
					default:
					{
						num2 = (short)2142502912;
						if (num2 != 0)
						{
						}
						num2 = (short)764936192;
						short num4 = num2;
						num2 = (short)237305858;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				notifyFieldsReportChangedEventHandler = this.f;
				num2 = (short)595853313;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00018BC8 File Offset: 0x00016DC8
		public void Clear()
		{
			int a_ = 3;
			short num = (short)229302662;
			short num2 = num;
			num = (short)2033443206;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1333592064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)972554240;
			if (num != 0)
			{
			}
			num = (short)80871425;
			if (num != 0)
			{
			}
			this.a.Clear();
			this.b.Clear();
			this.FirePropertyChanged(global::AcpCommonLib.Exceptions.AcpSecurityException.b("돴黶鳸韺駼賾", a_));
			this.FirePropertyChanged(global::AcpCommonLib.Exceptions.AcpSecurityException.b("ꃴ黶뿸鋺飼鏾攀瀂", a_));
			this.FirePropertyChanged(global::AcpCommonLib.Exceptions.AcpSecurityException.b("ꃴ黶뫸铺裼釾甀", a_));
			this.FieldsReportChanged = true;
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00018CD4 File Offset: 0x00016ED4
		public bool HasFields
		{
			get
			{
				short num = (short)475823384;
				short num2 = num;
				num = (short)346062104;
				switch (num2 == num)
				{
				default:
				{
					num = (short)117309440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)349896705;
				if (num != 0)
				{
				}
				num = (short)332726272;
				if (num != 0)
				{
				}
				return this.a.Count > 0;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000282 RID: 642 RVA: 0x00018D88 File Offset: 0x00016F88
		public bool UiHasFields
		{
			get
			{
				short num = (short)223833778;
				short num2 = num;
				num = (short)1396666034;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1754071040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)700514305;
				if (num != 0)
				{
				}
				num = (short)740098048;
				if (num != 0)
				{
				}
				return this.b.Count > 0;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00018E40 File Offset: 0x00017040
		public int Count
		{
			get
			{
				short num = (short)719944447;
				short num2 = num;
				num = (short)1348041471;
				switch (num2 == num)
				{
				default:
				{
					num = (short)967966720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1461190656;
				if (num != 0)
				{
				}
				num = (short)1411448833;
				if (num != 0)
				{
				}
				return this.a.Count;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00018EF8 File Offset: 0x000170F8
		public int UiCount
		{
			get
			{
				short num = (short)305421192;
				short num2 = num;
				num = (short)475749256;
				switch (num2 == num)
				{
				default:
				{
					num = (short)985202688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)919797761;
				if (num != 0)
				{
				}
				num = (short)1506344960;
				if (num != 0)
				{
				}
				return this.b.Count;
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00018FAC File Offset: 0x000171AC
		public bool ContainsField(global::AcpCommonLib.IAcpField field)
		{
			global::AcpCommonLib.FieldsReport.FieldsReportManager.a a = new global::AcpCommonLib.FieldsReport.FieldsReportManager.a();
			a.a = field;
			short num;
			if (a.a == null)
			{
				num = (short)874465781;
				short num2 = num;
				num = (short)851986933;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)174325760;
					if (num != 0)
					{
					}
					num = (short)1773993985;
					if (num != 0)
					{
					}
					return false;
				}
			}
			num = (short)2041380864;
			short num3 = num;
			return this.a.Exists(new global::System.Predicate<global::AcpCommonLib.FieldsReport.FieldsReportInfo>(a.b));
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00019084 File Offset: 0x00017284
		public bool ContainsUIField(global::AcpCommonLib.IAcpField field)
		{
			global::AcpCommonLib.FieldsReport.FieldsReportManager.b b = new global::AcpCommonLib.FieldsReport.FieldsReportManager.b();
			b.a = field;
			short num;
			if (b.a == null)
			{
				num = (short)97120937;
				short num2 = num;
				num = (short)181531305;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)594280449;
					if (num != 0)
					{
					}
					num = (short)419102720;
					if (num != 0)
					{
					}
					return false;
				}
			}
			num = (short)620363776;
			short num3 = num;
			return this.b.Exists(new global::System.Predicate<global::AcpCommonLib.FieldsReport.FieldsReportInfo>(b.b));
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0001915C File Offset: 0x0001735C
		public bool ContainsField(global::AcpCommonLib.IAcpFeatureNode node)
		{
			global::AcpCommonLib.FieldsReport.FieldsReportManager.c c = new global::AcpCommonLib.FieldsReport.FieldsReportManager.c();
			c.a = node;
			short num;
			if (c.a == null)
			{
				num = (short)2037182920;
				short num2 = num;
				num = (short)1259270600;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)894828545;
					if (num != 0)
					{
					}
					num = (short)1893662720;
					if (num != 0)
					{
					}
					return false;
				}
			}
			num = (short)831258624;
			short num3 = num;
			return this.a.Exists(new global::System.Predicate<global::AcpCommonLib.FieldsReport.FieldsReportInfo>(c.b));
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00019234 File Offset: 0x00017434
		public global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.FieldsReport.FieldsReportInfo> Fields
		{
			get
			{
				short num = (short)1193931847;
				short num2 = num;
				num = (short)773977159;
				switch (num2 == num)
				{
				default:
				{
					num = (short)966787072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1654849536;
				if (num != 0)
				{
				}
				num = (short)990904321;
				if (num != 0)
				{
				}
				global::AcpCommonLib.FieldsReport.FieldsReportManager.d d = new global::AcpCommonLib.FieldsReport.FieldsReportManager.d(-2);
				d.d = this;
				return d;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000289 RID: 649 RVA: 0x000192F0 File Offset: 0x000174F0
		public global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.FieldsReport.FieldsReportInfo> UiFields
		{
			get
			{
				short num = (short)1741000465;
				short num2 = num;
				num = (short)1333038865;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1782185984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)40173569;
				if (num != 0)
				{
				}
				num = (short)915210240;
				if (num != 0)
				{
				}
				global::AcpCommonLib.FieldsReport.FieldsReportManager.e e = new global::AcpCommonLib.FieldsReport.FieldsReportManager.e(-2);
				e.d = this;
				return e;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600028A RID: 650 RVA: 0x000193A8 File Offset: 0x000175A8
		public global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> AllFields
		{
			get
			{
				short num = (short)1986323260;
				short num2 = num;
				num = (short)66118460;
				switch (num2 == num)
				{
				default:
				{
					num = (short)761921536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)614203393;
				if (num != 0)
				{
				}
				num = (short)1475936256;
				if (num != 0)
				{
				}
				global::AcpCommonLib.FieldsReport.FieldsReportManager.f f = new global::AcpCommonLib.FieldsReport.FieldsReportManager.f(-2);
				f.d = this;
				return f;
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0001945C File Offset: 0x0001765C
		public void RegisterFieldInReport(global::AcpCommonLib.IAcpField field, string message, bool checkValidity)
		{
			int a_ = 2;
			short num = (short)1628766214;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_140;
				case 1:
					if (field.ParentNode != null)
					{
						num = (short)1206845444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_186;
				case 2:
					this.b.Add(new global::AcpCommonLib.FieldsReport.FieldsReportInfo(field, message));
					num = (short)585236480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)798292538;
					short num3 = num;
					num = (short)930019898;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15C;
					default:
						num = (short)1354760192;
						if (num != 0)
						{
						}
						num = (short)1429405701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					num = (short)1158938634;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!field.HiddenStatic)
					{
						num = (short)2024341506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_230;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 7:
				{
					num = (short)2037121024;
					short num4 = num;
					if (field != null)
					{
						num = (short)1614217219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_230;
				}
				case 8:
					goto IL_181;
				case 9:
					num = (short)946864129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_15C;
				}
				IL_5A:
				if (checkValidity)
				{
					num = (short)699400201;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_186;
				IL_15C:
				if (field.ParentNode.Deleted)
				{
					num = (short)2107047944;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_186:
				num = (short)1098448903;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_140:
			goto IL_230;
			IL_181:
			num = (short)880214017;
			if (num != 0)
			{
			}
			return;
			IL_230:
			this.a.Add(new global::AcpCommonLib.FieldsReport.FieldsReportInfo(field, message));
			this.FirePropertyChanged(global::AcpCommonLib.Exceptions.AcpSecurityException.b("닳鿵鷷雹飻跽", a_));
			this.FirePropertyChanged(global::AcpCommonLib.Exceptions.AcpSecurityException.b("ꇳ鿵뻷鏹駻鋽擿焁", a_));
			this.FirePropertyChanged(global::AcpCommonLib.Exceptions.AcpSecurityException.b("ꇳ鿵믷闹觻都瓿", a_));
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000196E8 File Offset: 0x000178E8
		public void RegisterFieldInReport(global::AcpCommonLib.IAcpFeatureNode node, string message)
		{
			int a_ = 19;
			short num = (short)997523458;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_12B;
				case 1:
					num = (short)1689780227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 3:
					num = (short)595918849;
					if (num != 0)
					{
					}
					if (node.Deleted)
					{
						num = (short)928186368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_130;
				}
				IL_3D:
				if (node == null)
				{
					goto IL_130;
				}
				num = (short)691273729;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_12B:
			num = (short)1840615780;
			short num3 = num;
			num = (short)626626916;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_130:
				this.a.Add(new global::AcpCommonLib.FieldsReport.FieldsReportInfo(node, message));
				this.b.Add(new global::AcpCommonLib.FieldsReport.FieldsReportInfo(node, message));
				this.FirePropertyChanged(global::AcpCommonLib.Exceptions.AcpSecurityException.b("䌄渆氈朊椌簎", a_));
				this.FirePropertyChanged(global::AcpCommonLib.Exceptions.AcpSecurityException.b("倄渆伈戊栌挎甐怒", a_));
				this.FirePropertyChanged(global::AcpCommonLib.Exceptions.AcpSecurityException.b("倄渆䨈搊砌愎攐", a_));
				return;
			default:
			{
				num = (short)2103246848;
				short num4 = num;
				num = (short)299433984;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00019888 File Offset: 0x00017A88
		public void UnregisterFieldInReport(global::AcpCommonLib.IAcpField field)
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			short num2;
			int num4;
			int num5;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					num2 = (short)1965948928;
					short num3 = num2;
					if (num4 >= 0)
					{
						num2 = (short)973275140;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					this.a.RemoveAt(num5);
					this.FirePropertyChanged(global::AcpCommonLib.Exceptions.AcpSecurityException.b("뿸鋺飼鏾攀瀂", a_));
					num2 = (short)1984823299;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)783022169;
					short num6 = num2;
					num2 = (short)819460185;
					switch ((num6 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1879113728;
						if (num2 != 0)
						{
						}
						goto IL_11B;
					}
					break;
				}
				case 4:
					this.b.RemoveAt(num4);
					this.FirePropertyChanged(global::AcpCommonLib.Exceptions.AcpSecurityException.b("곸鋺민雾搀漂愄理", a_));
					this.FirePropertyChanged(global::AcpCommonLib.Exceptions.AcpSecurityException.b("곸鋺뻼郾琀洂焄", a_));
					num2 = (short)14942209;
					if (num2 != 0)
					{
					}
					num2 = (short)774569984;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (num5 >= 0)
					{
						num2 = (short)1852702722;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11B;
				}
				goto IL_31;
				IL_11B:
				num2 = (short)578093057;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_31:
			global::AcpCommonLib.FieldsReport.FieldsReportManager.g g = new global::AcpCommonLib.FieldsReport.FieldsReportManager.g();
			g.a = field;
			num5 = this.a.FindIndex(new global::System.Predicate<global::AcpCommonLib.FieldsReport.FieldsReportInfo>(g.b));
			num4 = this.b.FindIndex(new global::System.Predicate<global::AcpCommonLib.FieldsReport.FieldsReportInfo>(g.c));
			num2 = (short)1254883333;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00019A9C File Offset: 0x00017C9C
		public void UnregisterFieldInUIReport(global::AcpCommonLib.IAcpField field)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			int num4;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)2077097984;
					short num3 = num2;
					goto IL_117;
				}
				case 1:
					num2 = (short)1091305473;
					if (num2 != 0)
					{
					}
					this.b.RemoveAt(num4);
					this.FirePropertyChanged(global::AcpCommonLib.Exceptions.AcpSecurityException.b("꟱鷳냵釷鿹郻髽珿", a_));
					this.FirePropertyChanged(global::AcpCommonLib.Exceptions.AcpSecurityException.b("꟱鷳뗵韷迹鋻諽", a_));
					num2 = (short)344981504;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (num4 >= 0)
					{
						goto IL_65;
					}
					goto IL_117;
				}
				goto IL_25;
				IL_65:
				num2 = (short)315752449;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_117:
				num2 = (short)644655511;
				short num5 = num2;
				num2 = (short)1304799639;
				switch ((num5 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_65;
				default:
					goto IL_14D;
				}
			}
			IL_14D:
			num2 = (short)537657344;
			if (num2 != 0)
			{
			}
			return;
			IL_25:
			global::AcpCommonLib.FieldsReport.FieldsReportManager.h h = new global::AcpCommonLib.FieldsReport.FieldsReportManager.h();
			h.a = field;
			num4 = this.b.FindIndex(new global::System.Predicate<global::AcpCommonLib.FieldsReport.FieldsReportInfo>(h.b));
			num2 = (short)2008350722;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00019C0C File Offset: 0x00017E0C
		public void UnregisterFieldInReport(global::AcpCommonLib.IAcpFeatureNode node)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			short num2;
			int num4;
			int num5;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					num2 = (short)705167361;
					if (num2 != 0)
					{
					}
					num2 = (short)1373372416;
					short num3 = num2;
					if (num4 >= 0)
					{
						num2 = (short)2030960644;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					this.a.RemoveAt(num5);
					num2 = (short)454885379;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)31443961;
					short num6 = num2;
					num2 = (short)941607929;
					switch ((num6 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)763559936;
						if (num2 != 0)
						{
						}
						goto IL_E0;
					}
					break;
				}
				case 4:
					this.b.RemoveAt(num4);
					this.FirePropertyChanged(global::AcpCommonLib.Exceptions.AcpSecurityException.b("꫾栀䀂樄爆月缊", a_));
					num2 = (short)489357312;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (num5 >= 0)
					{
						num2 = (short)1957167106;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E0;
				}
				goto IL_31;
				IL_E0:
				num2 = (short)98369537;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_31:
			global::AcpCommonLib.FieldsReport.FieldsReportManager.i i = new global::AcpCommonLib.FieldsReport.FieldsReportManager.i();
			i.a = node;
			num5 = this.a.FindIndex(new global::System.Predicate<global::AcpCommonLib.FieldsReport.FieldsReportInfo>(i.b));
			num4 = this.b.FindIndex(new global::System.Predicate<global::AcpCommonLib.FieldsReport.FieldsReportInfo>(i.c));
			num2 = (short)1197932549;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00019DFC File Offset: 0x00017FFC
		internal bool a(string A_0)
		{
			global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.FieldsReport.FieldsReportInfo> enumerator = this.Fields.GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)796065805;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)671678465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_206;
					case 2:
						num = (short)1477443588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_16B;
					case 4:
					{
						global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo;
						if (fieldsReportInfo.Message.Contains(A_0))
						{
							num = (short)1801453575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						result = true;
						num = (short)609681411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo;
						if (fieldsReportInfo.Path != null)
						{
							num = (short)821166089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AF;
					}
					case 7:
						result = true;
						num = (short)845873163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo;
						if (fieldsReportInfo.Path.Contains(A_0))
						{
							num = (short)552337413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AF;
					}
					case 9:
						num = (short)458293256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)537985024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo = enumerator.Current;
						num = (short)261226502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_87;
					case 12:
					{
						global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo;
						if (fieldsReportInfo.Message != null)
						{
							num = (short)369688578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 13:
						switch (0)
						{
						case 0:
							goto IL_6C;
						}
						continue;
					}
					IL_111:
					num = (short)296157194;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C:
					goto IL_111;
					IL_1AF:
					num = (short)1630208012;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_87:
				IL_16B:
				goto IL_2E8;
				IL_206:
				return false;
			}
			finally
			{
				num = (short)1877213186;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1616597845;
						short num3 = num;
						num = (short)284382037;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_25A;
						default:
							goto IL_2AA;
						}
						break;
					}
					case 1:
						goto IL_25A;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_23D;
						}
						continue;
					}
					IL_23D:
					if (enumerator != null)
					{
						num = (short)163446785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E7;
					IL_25A:
					enumerator.Dispose();
					num = (short)311492608;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2AA:
				num = (short)2116222977;
				if (num != 0)
				{
				}
				num = (short)752680960;
				if (num != 0)
				{
				}
				IL_2E7:;
			}
			IL_2E8:
			num = (short)1875968000;
			short num4 = num;
			return result;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000291 RID: 657 RVA: 0x0001A138 File Offset: 0x00018338
		// (set) Token: 0x06000292 RID: 658 RVA: 0x0001A1E8 File Offset: 0x000183E8
		public bool FieldsReportChanged
		{
			get
			{
				short num = (short)1861938817;
				short num2 = num;
				num = (short)429649537;
				switch (num2 == num)
				{
				}
				num = (short)1473839104;
				short num3 = num;
				num = (short)758448129;
				if (num != 0)
				{
				}
				num = (short)1591541760;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						num2 = (short)1992753152;
						short num3 = num2;
						num2 = (short)288495607;
						short num4 = num2;
						num2 = (short)1473517559;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_164;
						default:
							num2 = (short)1245446144;
							if (num2 != 0)
							{
							}
							num2 = (short)1923678211;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						goto IL_164;
					case 3:
						if (this.f != null)
						{
							num2 = (short)1004208130;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 4:
						if (!this.SuppressReportDisplay)
						{
							num2 = (short)270008321;
							if (num2 != 0)
							{
							}
							num2 = (short)1987706881;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					goto IL_24;
					IL_164:
					this.f(null, new global::AcpCommonLib.FieldsReport.NotifyFieldsReportChangedEventArgs());
					num2 = (short)1795883008;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_24:
				this.c = value;
				num2 = (short)1490354180;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0001A360 File Offset: 0x00018560
		// (set) Token: 0x06000294 RID: 660 RVA: 0x0001A410 File Offset: 0x00018610
		public bool SuppressReportDisplay
		{
			get
			{
				short num = (short)1696577895;
				short num2 = num;
				num = (short)1344452967;
				switch (num2 == num)
				{
				}
				num = (short)1569325056;
				short num3 = num;
				num = (short)135856129;
				if (num != 0)
				{
				}
				num = (short)1155399680;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1796029767;
				short num2 = num;
				num = (short)134692167;
				switch (num2 == num)
				{
				}
				num = (short)211681280;
				short num3 = num;
				num = (short)2105606145;
				if (num != 0)
				{
				}
				num = (short)1515978752;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0001A4C0 File Offset: 0x000186C0
		public void PostFieldsReport()
		{
			short num = (short)457310214;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_ED;
				case 1:
				{
					if (this.d != null)
					{
						this.d.Stop();
						num = (short)1348206595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)353836994;
					short num3 = num;
					num = (short)979050434;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_ED;
					default:
						num = (short)396296192;
						if (num != 0)
						{
						}
						num = (short)1772552197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					num = (short)2123759617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1329135617;
					if (num != 0)
					{
					}
					goto IL_17C;
				case 4:
					return;
				case 5:
					this.d = new global::System.Windows.Threading.DispatcherTimer(global::System.Windows.Threading.DispatcherPriority.Normal);
					this.d.Tick += this.a;
					num = (short)1700397056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				}
				IL_41:
				if (!this.SuppressReportDisplay)
				{
					num = (short)1824129026;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_17C:
				this.d.Interval = global::System.TimeSpan.FromMilliseconds(100.0);
				this.d.Start();
				num = (short)686161920;
				short num4 = num;
				num = (short)472907780;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_ED:
				goto IL_17C;
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0001A6B0 File Offset: 0x000188B0
		private void a(object A_0, global::System.EventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_79;
				case 1:
					this.d.Stop();
					num2 = (short)870711296;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (this.d != null)
					{
						goto IL_3F;
					}
					goto IL_79;
				}
				goto IL_1C;
				IL_3F:
				num2 = (short)437452801;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_79:
				num2 = (short)125370368;
				short num3 = num2;
				num2 = (short)900194500;
				short num4 = num2;
				num2 = (short)1345904836;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3F;
				default:
					goto IL_DA;
				}
			}
			IL_DA:
			num2 = (short)1405878273;
			if (num2 != 0)
			{
			}
			num2 = (short)1534984192;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			this.FieldsReportChanged = true;
			num2 = (short)985595906;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000297 RID: 663 RVA: 0x0001A7D4 File Offset: 0x000189D4
		// (remove) Token: 0x06000298 RID: 664 RVA: 0x0001A908 File Offset: 0x00018B08
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)1129971712;
						short num3 = num2;
						num2 = (short)200611059;
						short num4 = num2;
						num2 = (short)1065030899;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_61;
						default:
							goto IL_110;
						}
						break;
					}
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)2006581248;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_61;
					case 2:
						num2 = (short)715522049;
						if (num2 != 0)
						{
						}
						goto IL_61;
					}
					goto IL_1C;
					IL_61:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.g, value2, propertyChangedEventHandler2);
					num2 = (short)1087373313;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_110:
				num2 = (short)1652686848;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.g;
				num2 = (short)1775108098;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)746455040;
						short num3 = num2;
						num2 = (short)1828222850;
						short num4 = num2;
						num2 = (short)1136097154;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_39;
						default:
							goto IL_E2;
						}
						break;
					}
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)95027200;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_39:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.g, value2, propertyChangedEventHandler2);
					num2 = (short)1194983425;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_E2:
				num2 = (short)2041708545;
				if (num2 != 0)
				{
				}
				num2 = (short)292290560;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.g;
				num2 = (short)2131886082;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0001AA38 File Offset: 0x00018C38
		public void FirePropertyChanged(string name)
		{
			short num = (short)1238237186;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1044427189;
					short num3 = num;
					num = (short)810201525;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_54;
					default:
						goto IL_103;
					}
					break;
				}
				case 1:
					goto IL_54;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				}
				IL_32:
				if (this.g != null)
				{
					num = (short)730136577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_54:
				num = (short)1454833665;
				if (num != 0)
				{
				}
				num = (short)1885536256;
				short num4 = num;
				this.g(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
				num = (short)1733885952;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_103:
			num = (short)1663500288;
			if (num != 0)
			{
			}
		}

		// Token: 0x040000CF RID: 207
		private global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo> a = new global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo>();

		// Token: 0x040000D0 RID: 208
		private global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo> b = new global::System.Collections.Generic.List<global::AcpCommonLib.FieldsReport.FieldsReportInfo>();

		// Token: 0x040000D1 RID: 209
		private bool c;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Threading.DispatcherTimer d;

		// Token: 0x040000D3 RID: 211
		private bool e;

		// Token: 0x040000D4 RID: 212
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpCommonLib.FieldsReport.NotifyFieldsReportChangedEventHandler f;

		// Token: 0x040000D5 RID: 213
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler g;

		// Token: 0x02000047 RID: 71
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600029C RID: 668 RVA: 0x0001ABA0 File Offset: 0x00018DA0
			internal bool b(global::AcpCommonLib.FieldsReport.FieldsReportInfo A_0)
			{
				short num = (short)1373096586;
				short num2 = num;
				num = (short)31378058;
				switch (num2 == num)
				{
				}
				num = (short)2053636096;
				short num3 = num;
				num = (short)1766981632;
				if (num != 0)
				{
				}
				num = (short)1693122561;
				if (num != 0)
				{
				}
				return A_0.Field == this.a;
			}

			// Token: 0x040000D6 RID: 214
			public global::AcpCommonLib.IAcpField a;
		}

		// Token: 0x02000048 RID: 72
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x0600029E RID: 670 RVA: 0x0001AC6C File Offset: 0x00018E6C
			internal bool b(global::AcpCommonLib.FieldsReport.FieldsReportInfo A_0)
			{
				short num = (short)1522459335;
				short num2 = num;
				num = (short)90694343;
				switch (num2 == num)
				{
				}
				num = (short)2124414976;
				short num3 = num;
				num = (short)1804337153;
				if (num != 0)
				{
				}
				num = (short)1000341504;
				if (num != 0)
				{
				}
				return A_0.Field == this.a;
			}

			// Token: 0x040000D7 RID: 215
			public global::AcpCommonLib.IAcpField a;
		}

		// Token: 0x02000049 RID: 73
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x060002A0 RID: 672 RVA: 0x0001AD38 File Offset: 0x00018F38
			internal bool b(global::AcpCommonLib.FieldsReport.FieldsReportInfo A_0)
			{
				short num = (short)1197481106;
				short num2 = num;
				num = (short)81927314;
				switch (num2 == num)
				{
				}
				num = (short)482541568;
				short num3 = num;
				num = (short)1418526721;
				if (num != 0)
				{
				}
				num = (short)1696399360;
				if (num != 0)
				{
				}
				return A_0.Node == this.a;
			}

			// Token: 0x040000D8 RID: 216
			public global::AcpCommonLib.IAcpFeatureNode a;
		}

		// Token: 0x0200004D RID: 77
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class g
		{
			// Token: 0x060002BD RID: 701 RVA: 0x0001CC94 File Offset: 0x0001AE94
			internal bool b(global::AcpCommonLib.FieldsReport.FieldsReportInfo A_0)
			{
				short num = (short)2107359889;
				short num2 = num;
				num = (short)779666065;
				switch (num2 == num)
				{
				}
				num = (short)410779649;
				if (num != 0)
				{
				}
				num = (short)1658322944;
				if (num != 0)
				{
				}
				num = (short)1331036160;
				short num3 = num;
				return A_0.Field == this.a;
			}

			// Token: 0x060002BE RID: 702 RVA: 0x0001CD4C File Offset: 0x0001AF4C
			internal bool c(global::AcpCommonLib.FieldsReport.FieldsReportInfo A_0)
			{
				short num = (short)1994236075;
				short num2 = num;
				num = (short)1551081643;
				switch (num2 == num)
				{
				}
				num = (short)1331494912;
				if (num != 0)
				{
				}
				num = (short)1517813761;
				if (num != 0)
				{
				}
				num = (short)443088896;
				short num3 = num;
				return A_0.Field == this.a;
			}

			// Token: 0x040000E8 RID: 232
			public global::AcpCommonLib.IAcpField a;
		}

		// Token: 0x0200004E RID: 78
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class h
		{
			// Token: 0x060002C0 RID: 704 RVA: 0x0001CE14 File Offset: 0x0001B014
			internal bool b(global::AcpCommonLib.FieldsReport.FieldsReportInfo A_0)
			{
				short num = (short)1806549444;
				short num2 = num;
				num = (short)2129772996;
				switch (num2 == num)
				{
				}
				num = (short)909443073;
				if (num != 0)
				{
				}
				num = (short)1469186048;
				if (num != 0)
				{
				}
				num = (short)1303838720;
				short num3 = num;
				return A_0.Field == this.a;
			}

			// Token: 0x040000E9 RID: 233
			public global::AcpCommonLib.IAcpField a;
		}

		// Token: 0x0200004F RID: 79
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class i
		{
			// Token: 0x060002C2 RID: 706 RVA: 0x0001CEE0 File Offset: 0x0001B0E0
			internal bool b(global::AcpCommonLib.FieldsReport.FieldsReportInfo A_0)
			{
				short num = (short)2040503380;
				short num2 = num;
				num = (short)1527815252;
				switch (num2 == num)
				{
				}
				num = (short)1579352065;
				if (num != 0)
				{
				}
				num = (short)1426063360;
				if (num != 0)
				{
				}
				num = (short)1774911488;
				short num3 = num;
				return A_0.Node == this.a;
			}

			// Token: 0x060002C3 RID: 707 RVA: 0x0001CF9C File Offset: 0x0001B19C
			internal bool c(global::AcpCommonLib.FieldsReport.FieldsReportInfo A_0)
			{
				short num = (short)211048894;
				short num2 = num;
				num = (short)252795326;
				switch (num2 == num)
				{
				}
				num = (short)1832452097;
				if (num != 0)
				{
				}
				num = (short)460587008;
				if (num != 0)
				{
				}
				num = (short)370606080;
				short num3 = num;
				return A_0.Node == this.a;
			}

			// Token: 0x040000EA RID: 234
			public global::AcpCommonLib.IAcpFeatureNode a;
		}
	}
}
