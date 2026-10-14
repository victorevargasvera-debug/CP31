using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000098 RID: 152
	[global::System.Diagnostics.DebuggerDisplay("Name: {Name}")]
	public abstract class FieldBase : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::Motorola.CommonCPS.RadioManagement.UIModels.IFieldEdit, global::Motorola.CommonCPS.RadioManagement.UIModels.ITreeNode
	{
		// Token: 0x0600056F RID: 1391 RVA: 0x00050E74 File Offset: 0x0004F074
		public FieldBase()
		{
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00050E98 File Offset: 0x0004F098
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase Null
		{
			get
			{
				short num = (short)716228559;
				short num2 = num;
				num = (short)1157482447;
				switch (num2 == num)
				{
				}
				num = (short)1251934209;
				if (num != 0)
				{
				}
				num = (short)626262016;
				if (num != 0)
				{
				}
				num = (short)1931935744;
				short num3 = num;
				return new global::Motorola.CommonCPS.RadioManagement.UIModels.NullField();
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00050F44 File Offset: 0x0004F144
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x00050FF4 File Offset: 0x0004F1F4
		public bool IsSelfChangeOnly
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1389913619;
				short num2 = num;
				num = (short)817522195;
				switch (num2 == num)
				{
				}
				num = (short)2131558400;
				if (num != 0)
				{
				}
				num = (short)969211905;
				if (num != 0)
				{
				}
				num = (short)1968766976;
				short num3 = num;
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)909967361;
				if (num != 0)
				{
				}
				num = (short)2062419988;
				short num2 = num;
				num = (short)360712212;
				switch (num2 == num)
				{
				}
				num = (short)2031419392;
				if (num != 0)
				{
				}
				num = (short)1537015808;
				short num3 = num;
				this.h = value;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x000510A4 File Offset: 0x0004F2A4
		public virtual bool IsApplicable
		{
			get
			{
				short num = (short)754066587;
				short num2 = num;
				num = (short)1798513819;
				switch (num2 == num)
				{
				}
				num = (short)161021953;
				if (num != 0)
				{
				}
				num = (short)207814656;
				if (num != 0)
				{
				}
				num = (short)1381957632;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x00051150 File Offset: 0x0004F350
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x000511FC File Offset: 0x0004F3FC
		public virtual bool IsEditable
		{
			get
			{
				short num = (short)1713233698;
				short num2 = num;
				num = (short)1375395618;
				switch (num2 == num)
				{
				}
				num = (short)1145372672;
				if (num != 0)
				{
				}
				num = (short)349896705;
				if (num != 0)
				{
				}
				num = (short)1500119040;
				short num3 = num;
				return this.b;
			}
			set
			{
				int a_ = 13;
				short num = (short)517831268;
				short num2 = num;
				num = (short)397900388;
				switch (num2 == num)
				{
				}
				num = (short)127598592;
				if (num != 0)
				{
				}
				num = (short)920190977;
				if (num != 0)
				{
				}
				num = (short)1837957120;
				short num3 = num;
				this.b = value;
				this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Ň㥉ो⩍㥏♑㕓㑕㑗㽙", a_));
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x000512CC File Offset: 0x0004F4CC
		public virtual bool IsValid
		{
			get
			{
				short num = (short)1659616151;
				short num2 = num;
				num = (short)186694551;
				switch (num2 == num)
				{
				}
				num = (short)400883713;
				if (num != 0)
				{
				}
				num = (short)1485766656;
				if (num != 0)
				{
				}
				num = (short)721879040;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00051378 File Offset: 0x0004F578
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x00051428 File Offset: 0x0004F628
		public bool IsDisplayAllowed
		{
			get
			{
				short num = (short)405409975;
				short num2 = num;
				num = (short)487592119;
				switch (num2 == num)
				{
				}
				num = (short)2081095681;
				if (num != 0)
				{
				}
				num = (short)2135228416;
				if (num != 0)
				{
				}
				num = (short)699269120;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)804707483;
				short num2 = num;
				num = (short)1382735003;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_61:
					switch (0)
					{
					case 0:
						goto IL_7D;
					}
					break;
				default:
					num = (short)1139146752;
					if (num != 0)
					{
					}
					num = (short)946077697;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					IL_6B:
					switch (num3)
					{
					case 0:
						goto IL_10B;
					case 1:
						goto IL_61;
					case 2:
					{
						num = (short)856162304;
						short num4 = num;
						this.c = value;
						num = (short)2019295232;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_7D;
				}
				IL_10B:
				return;
				IL_7D:
				num = (short)1638268929;
				if (num != 0)
				{
				}
				if (this.c != value)
				{
					num = (short)1867513858;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_6B;
				}
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x00051544 File Offset: 0x0004F744
		public virtual bool IsVisible
		{
			get
			{
				short num = (short)1944059904;
				short num2 = num;
				if (!this.IsDisplayAllowed)
				{
					num = (short)402481709;
					short num3 = num;
					num = (short)256401965;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)249036800;
						if (num != 0)
						{
						}
						num = (short)1140129793;
						if (num != 0)
						{
						}
						return false;
					}
				}
				return true;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x000515FC File Offset: 0x0004F7FC
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x000516B0 File Offset: 0x0004F8B0
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)249775061;
				short num2 = num;
				num = (short)1546929109;
				switch (num2 == num)
				{
				}
				num = (short)58392577;
				if (num != 0)
				{
				}
				num = (short)848822272;
				if (num != 0)
				{
				}
				num = (short)142213120;
				short num3 = num;
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2066481153;
				if (num != 0)
				{
				}
				num = (short)405520445;
				short num2 = num;
				num = (short)365609021;
				switch (num2 == num)
				{
				}
				num = (short)2094399488;
				if (num != 0)
				{
				}
				num = (short)745996288;
				short num3 = num;
				this.i = value;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x00051760 File Offset: 0x0004F960
		// (set) Token: 0x0600057D RID: 1405 RVA: 0x00051810 File Offset: 0x0004FA10
		public string Label
		{
			get
			{
				short num = (short)1871027346;
				short num2 = num;
				num = (short)161455250;
				switch (num2 == num)
				{
				}
				num = (short)1643249665;
				if (num != 0)
				{
				}
				num = (short)1970667520;
				if (num != 0)
				{
				}
				num = (short)742719488;
				short num3 = num;
				return this.a;
			}
			set
			{
				int a_ = 9;
				short num = (short)689131273;
				short num2 = num;
				num = (short)1737182985;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_153:
					if (base.IsLoading)
					{
						return;
					}
					num = (short)1412562944;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)930414592;
					if (num != 0)
					{
					}
					num = (short)961085440;
					short num4 = num;
					num = (short)95551489;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ࡃ❅⩇⽉⁋", a_));
						num = (short)1282211844;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_B5;
						}
						continue;
					case 2:
						goto IL_153;
					case 3:
						num = (short)904921089;
						if (num != 0)
						{
						}
						this.a = value;
						num = (short)1395326978;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return;
					}
					IL_B5:
					if (!(value != this.a))
					{
						break;
					}
					num = (short)1713438723;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x00051994 File Offset: 0x0004FB94
		public bool UseMVODefault
		{
			get
			{
				short num = (short)1373460997;
				short num2 = num;
				num = (short)341531141;
				switch (num2 == num)
				{
				}
				num = (short)1115422721;
				if (num != 0)
				{
				}
				num = (short)1590427648;
				if (num != 0)
				{
				}
				num = (short)99352576;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00051A3C File Offset: 0x0004FC3C
		public bool IsMVODynamic
		{
			get
			{
				short num = (short)1382967300;
				short num2 = num;
				num = (short)609839108;
				switch (num2 == num)
				{
				}
				num = (short)948043777;
				if (num != 0)
				{
				}
				num = (short)865075200;
				if (num != 0)
				{
				}
				num = (short)1624244224;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x00051AE8 File Offset: 0x0004FCE8
		public bool IsValueVisible
		{
			get
			{
				short num = (short)1859295308;
				short num2 = num;
				num = (short)1170643020;
				switch (num2 == num)
				{
				}
				num = (short)1180434432;
				if (num != 0)
				{
				}
				num = (short)2130640897;
				if (num != 0)
				{
				}
				num = (short)1213202432;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00051B90 File Offset: 0x0004FD90
		public virtual bool IsPasteable
		{
			get
			{
				short num = (short)1599340544;
				short num2 = num;
				if (this.IsVisible)
				{
					num = (short)526969504;
					short num3 = num;
					num = (short)1508895392;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)863895553;
						if (num != 0)
						{
						}
						num = (short)826474496;
						if (num != 0)
						{
						}
						return this.IsEditable;
					}
				}
				return false;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x00051C4C File Offset: 0x0004FE4C
		public virtual bool IsCopyable
		{
			get
			{
				short num = (short)737642166;
				short num2 = num;
				num = (short)534152886;
				switch (num2 == num)
				{
				}
				num = (short)55312384;
				if (num != 0)
				{
				}
				num = (short)2043150337;
				if (num != 0)
				{
				}
				num = (short)1665925120;
				short num3 = num;
				return this.IsVisible;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00051CFC File Offset: 0x0004FEFC
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00051DB0 File Offset: 0x0004FFB0
		public bool TelePortMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2070049766;
				short num2 = num;
				num = (short)149910502;
				switch (num2 == num)
				{
				}
				num = (short)106430464;
				if (num != 0)
				{
				}
				num = (short)724172801;
				if (num != 0)
				{
				}
				num = (short)299499520;
				short num3 = num;
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2121596929;
				if (num != 0)
				{
				}
				num = (short)247486280;
				short num2 = num;
				num = (short)273700680;
				switch (num2 == num)
				{
				}
				num = (short)2054225920;
				if (num != 0)
				{
				}
				num = (short)1727004672;
				short num3 = num;
				this.j = value;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00051E64 File Offset: 0x00050064
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x00051F14 File Offset: 0x00050114
		public global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase> FieldValueChangedHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1460181737;
				short num2 = num;
				num = (short)342661865;
				switch (num2 == num)
				{
				}
				num = (short)2079850497;
				if (num != 0)
				{
				}
				num = (short)1718157312;
				if (num != 0)
				{
				}
				num = (short)158072832;
				short num3 = num;
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)562789363;
				short num2 = num;
				num = (short)1538817011;
				switch (num2 == num)
				{
				}
				num = (short)1257177088;
				if (num != 0)
				{
				}
				num = (short)387579905;
				if (num != 0)
				{
				}
				num = (short)814546944;
				short num3 = num;
				this.k = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00051FC8 File Offset: 0x000501C8
		public virtual string ValueForCompare
		{
			get
			{
				int a_ = 16;
				short num = (short)773259264;
				short num2 = num;
				num = (short)726410302;
				short num3 = num;
				num = (short)1908286526;
				switch (num3 == num)
				{
				}
				num = (short)587071489;
				if (num != 0)
				{
				}
				num = (short)221970432;
				if (num != 0)
				{
				}
				global::System.Console.WriteLine(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Պ⡌⩎㕐獒⅔㡖祘㍚㱜ㅞՠརd䝦ᵨͪѬᱮ兰ݲ౴ݶᱸ孺᭼ᙾꞆﾌ꾎ﲒ놞슢좤슦覨險趬", a_) + this.Name);
				return string.Empty;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x0005209C File Offset: 0x0005029C
		public bool IsCps2Only
		{
			get
			{
				short num = (short)1731067904;
				short num2 = num;
				num = (short)1092265155;
				short num3 = num;
				num = (short)738763971;
				switch (num3 == num)
				{
				}
				num = (short)163119105;
				if (num != 0)
				{
				}
				num = (short)1123090432;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00052144 File Offset: 0x00050344
		public global::System.Xml.Linq.XElement ToCopy()
		{
			int a_ = 3;
			short num = (short)1423900674;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Xml.Linq.XElement xelement;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)942538758;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1008205825;
					if (num != 0)
					{
					}
					xelement = this.ToCopyOverride();
					num = (short)229244932;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 3:
					return xelement;
				case 4:
					if (xelement != null)
					{
						goto IL_1A6;
					}
					return xelement;
				case 5:
				{
					xelement.SetAttributeValue(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("匽㘿ⵁ", a_), this.UseMVODefault);
					num = (short)2010564984;
					short num3 = num;
					num = (short)1933953400;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A6;
					default:
					{
						num = (short)139132928;
						if (num != 0)
						{
						}
						num = (short)975372288;
						short num4 = num;
						num = (short)1778515971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 6:
					if (this.IsMVODynamic)
					{
						num = (short)1251606533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return xelement;
				}
				IL_4A:
				if (this.IsCopyable)
				{
					num = (short)950599681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1C3;
				IL_1A6:
				num = (short)2104754176;
				num2 = (int)((global::System.IntPtr)num);
			}
			return xelement;
			IL_1C3:
			return null;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00052318 File Offset: 0x00050518
		protected virtual global::System.Xml.Linq.XElement ToCopyOverride()
		{
			int a_ = 6;
			short num = (short)1036124160;
			short num2 = num;
			num = (short)820666456;
			short num3 = num;
			num = (short)743268440;
			switch (num3 == num)
			{
			}
			num = (short)364707841;
			if (num != 0)
			{
			}
			num = (short)1938161664;
			if (num != 0)
			{
			}
			return new global::System.Xml.Linq.XElement(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("❀⩂⁄⭆ⵈ", a_), new object[]
			{
				new global::System.Xml.Linq.XAttribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("⽀≂⡄≆", a_), this.Name),
				this.ToString()
			});
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00052414 File Offset: 0x00050614
		public global::System.Collections.IList Children
		{
			get
			{
				short num = (short)688259072;
				short num2 = num;
				num = (short)2007797533;
				short num3 = num;
				num = (short)1429573405;
				switch (num3 == num)
				{
				}
				num = (short)1219952641;
				if (num != 0)
				{
				}
				num = (short)81199104;
				if (num != 0)
				{
				}
				return null;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x000524BC File Offset: 0x000506BC
		public int ChildrenCount
		{
			get
			{
				short num = (short)1634009088;
				short num2 = num;
				num = (short)91069724;
				short num3 = num;
				num = (short)414620956;
				switch (num3 == num)
				{
				}
				num = (short)912195584;
				if (num != 0)
				{
				}
				num = (short)169082881;
				if (num != 0)
				{
				}
				return 0;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00052568 File Offset: 0x00050768
		public global::System.Type ChildType
		{
			get
			{
				short num = (short)444137472;
				short num2 = num;
				num = (short)522211985;
				short num3 = num;
				num = (short)693523089;
				switch (num3 == num)
				{
				}
				num = (short)1271988225;
				if (num != 0)
				{
				}
				num = (short)1173618688;
				if (num != 0)
				{
				}
				return null;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00052610 File Offset: 0x00050810
		public global::System.Type CurrentType
		{
			get
			{
				short num = (short)821821440;
				short num2 = num;
				num = (short)297184000;
				short num3 = num;
				num = (short)395946752;
				switch (num3 == num)
				{
				}
				num = (short)1125318657;
				if (num != 0)
				{
				}
				num = (short)1809055744;
				if (num != 0)
				{
				}
				return null;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x000526BC File Offset: 0x000508BC
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x0005276C File Offset: 0x0005096C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ITreeNode Parent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1261568000;
				short num2 = num;
				num = (short)1561495930;
				short num3 = num;
				num = (short)2025228666;
				switch (num3 == num)
				{
				}
				num = (short)93388800;
				if (num != 0)
				{
				}
				num = (short)2020540417;
				if (num != 0)
				{
				}
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)343277568;
				short num2 = num;
				num = (short)415947588;
				short num3 = num;
				num = (short)135912260;
				switch (num3 == num)
				{
				}
				num = (short)599523329;
				if (num != 0)
				{
				}
				num = (short)23134208;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0005281C File Offset: 0x00050A1C
		public virtual void Accept(global::Motorola.CommonCPS.RadioManagement.UIModels.UIVisitor v, object context)
		{
			short num = (short)683016192;
			short num2 = num;
			num = (short)1902777987;
			short num3 = num;
			num = (short)669456003;
			switch (num3 == num)
			{
			}
			num = (short)824049664;
			if (num != 0)
			{
			}
			num = (short)1751777281;
			if (num != 0)
			{
			}
			v.VisitField(this, context);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x000528CC File Offset: 0x00050ACC
		public virtual void RaisePropertyChanged()
		{
			int a_ = 5;
			short num = (short)2144731136;
			short num2 = num;
			num = (short)1120177817;
			short num3 = num;
			num = (short)948342425;
			switch (num3 == num)
			{
			}
			num = (short)1341521921;
			if (num != 0)
			{
			}
			num = (short)989265920;
			if (num != 0)
			{
			}
			this.CleanCacheData();
			this.IsSelfChangeOnly = true;
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("िㅁՃ㙅㡇♉╋ⵍㅏけ㡓㍕", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("िㅁŃ≅ⅇ㹉ⵋⱍ㱏㝑", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("िㅁቃ❅⑇⍉⡋", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("िㅁቃ⽅㭇⍉⹋≍㕏", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("िㅁቃ❅⑇㽉⥋ᡍ㥏⅑㵓㑕㑗㽙", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᔿㅁ⅃୅ṇՉࡋ⭍㙏㍑⅓㩕ⱗ", a_));
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00052A00 File Offset: 0x00050C00
		public global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult PasteFrom(global::System.Xml.Linq.XElement xmlElement, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Xml.Linq.XElement>> setsToAdd, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>> setsToRemove, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.PasteContext pasteContext)
		{
			int a_ = 14;
			short num = (short)2078736384;
			switch (num)
			{
			default:
			{
				num = (short)1344471042;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						if (!flag)
						{
							num = (short)566231046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Changed;
					case 1:
						if (this.IsMVODynamic)
						{
							num = (short)1822621704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8;
					case 2:
					{
						num = (short)123384258;
						short num3 = num;
						num = (short)298889666;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1565327360;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_D3;
							}
							continue;
						}
						break;
					}
					case 3:
						flag = true;
						num = (short)3080201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::System.Xml.Linq.XAttribute xattribute;
						if (xattribute != null)
						{
							num = (short)391381005;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8;
					}
					case 5:
						return global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Unchanged;
					case 6:
						return global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Unchanged;
					case 7:
						num = (short)260505600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::System.Xml.Linq.XAttribute xattribute = xmlElement.Attribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("⑈㵊≌", a_));
						num = (short)1185415172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_F8;
					case 10:
					{
						if (this.UseMVODefault)
						{
							num = (short)2063007751;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult result = this.PasteFromOverride(xmlElement, ref setsToAdd, ref setsToRemove, pasteContext);
						num = (short)1217921038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult result;
						return result;
					}
					case 12:
					{
						bool flag2;
						if (flag2 != this.UseMVODefault)
						{
							num = (short)1035272192;
							short num4 = num;
							num = (short)1342308355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8;
					}
					case 13:
					{
						global::System.Xml.Linq.XAttribute xattribute;
						bool flag2 = global::System.Convert.ToBoolean(xattribute.Value);
						num = (short)22151180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						num = (short)782696449;
						if (num != 0)
						{
						}
						if (!flag)
						{
							num = (short)1108279307;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Changed;
					}
					IL_D3:
					if (!this.IsPasteable)
					{
						num = (short)1683357701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					flag = false;
					num = (short)1339752449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F8:
					num = (short)797048842;
					num2 = (int)((global::System.IntPtr)num);
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Unchanged;
			}
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00052D1C File Offset: 0x00050F1C
		protected virtual global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult PasteFromOverride(global::System.Xml.Linq.XElement xmlElement, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Xml.Linq.XElement>> setsToAdd, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>> setsToRemove, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.PasteContext pasteContext)
		{
			short num = (short)1109917696;
			short num2 = num;
			num = (short)2122976822;
			short num3 = num;
			num = (short)1065029174;
			switch (num3 == num)
			{
			}
			num = (short)1254686721;
			if (num != 0)
			{
			}
			num = (short)358940672;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Unchanged;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00052DC4 File Offset: 0x00050FC4
		protected virtual void CleanCacheData()
		{
			short num = (short)1349386240;
			short num2 = num;
			num = (short)834797569;
			if (num != 0)
			{
			}
			num = (short)1962953055;
			short num3 = num;
			num = (short)502483295;
			switch (num3 == num)
			{
			}
			num = (short)1852506112;
			if (num != 0)
			{
			}
			this.blEditable = null;
			this.d = null;
			this.e = null;
			this.blVisible = null;
			this.f = null;
			this.g = null;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x00052EB4 File Offset: 0x000510B4
		protected void DoModifyBlValue(global::System.Action action)
		{
			short num = (short)1520435200;
			short num2 = num;
			num = (short)1428750337;
			if (num != 0)
			{
			}
			num = (short)504007269;
			short num3 = num;
			num = (short)1828883045;
			switch (num3 == num)
			{
			}
			num = (short)1441005568;
			if (num != 0)
			{
			}
			action();
			this.OnFieldValueChanged();
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00052F6C File Offset: 0x0005116C
		protected void OnFieldValueChanged()
		{
			for (;;)
			{
				IL_00:
				short num = (short)946208768;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1958608897;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					case 1:
						return;
					case 2:
						this.FieldValueChangedHandler(this);
						num = (short)1335164929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_59:
					num = (short)1931712685;
					short num3 = num;
					num = (short)818518189;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					case 1:
						break;
					default:
					{
						num = (short)2016346112;
						short num4 = num;
						break;
					}
					}
					num = (short)1009123328;
					if (num != 0)
					{
					}
					if (this.FieldValueChangedHandler == null)
					{
						return;
					}
					num = (short)486801410;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x04000294 RID: 660
		private string a;

		// Token: 0x04000295 RID: 661
		private bool b = true;

		// Token: 0x04000296 RID: 662
		private bool c = true;

		// Token: 0x04000297 RID: 663
		protected bool? blEditable;

		// Token: 0x04000298 RID: 664
		private bool? d;

		// Token: 0x04000299 RID: 665
		private bool? e;

		// Token: 0x0400029A RID: 666
		protected bool? blVisible;

		// Token: 0x0400029B RID: 667
		private bool? f;

		// Token: 0x0400029C RID: 668
		private bool? g;

		// Token: 0x0400029D RID: 669
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool h;

		// Token: 0x0400029E RID: 670
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string i;

		// Token: 0x0400029F RID: 671
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool j;

		// Token: 0x040002A0 RID: 672
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase> k;

		// Token: 0x040002A1 RID: 673
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ITreeNode l;
	}
}
