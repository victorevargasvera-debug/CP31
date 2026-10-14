using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000075 RID: 117
	public class FreezableBinding : global::System.Windows.Freezable
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000270 RID: 624 RVA: 0x000292B8 File Offset: 0x000274B8
		protected global::System.Windows.Data.Binding Binding
		{
			get
			{
				short num = (short)858783745;
				if (num != 0)
				{
				}
				num = (short)1613430104;
				short num2 = num;
				num = (short)810286424;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1163329536;
					if (num != 0)
					{
					}
					num = (short)782303232;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)205651968;
						short num4 = num;
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_CA;
							}
							continue;
						case 1:
							goto IL_109;
						case 2:
							this.a = new global::System.Windows.Data.Binding();
							num = (short)226885633;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_CA:
						if (this.a != null)
						{
							break;
						}
						num = (short)767754242;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_109:
					break;
				}
				}
				return this.a;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000271 RID: 625 RVA: 0x000293D8 File Offset: 0x000275D8
		// (set) Token: 0x06000272 RID: 626 RVA: 0x0002948C File Offset: 0x0002768C
		[global::System.ComponentModel.DefaultValue(null)]
		public object AsyncState
		{
			get
			{
				short num = (short)146981052;
				short num2 = num;
				num = (short)1395245244;
				switch (num2 == num)
				{
				}
				num = (short)2083586049;
				if (num != 0)
				{
				}
				num = (short)697565184;
				if (num != 0)
				{
				}
				num = (short)928514048;
				short num3 = num;
				return this.Binding.AsyncState;
			}
			set
			{
				short num = (short)564771596;
				short num2 = num;
				num = (short)712227596;
				switch (num2 == num)
				{
				}
				num = (short)1876230145;
				if (num != 0)
				{
				}
				num = (short)251592704;
				if (num != 0)
				{
				}
				num = (short)2023555072;
				short num3 = num;
				this.Binding.AsyncState = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00029540 File Offset: 0x00027740
		// (set) Token: 0x06000274 RID: 628 RVA: 0x000295F4 File Offset: 0x000277F4
		[global::System.ComponentModel.DefaultValue(false)]
		public bool BindsDirectlyToSource
		{
			get
			{
				short num = (short)629789530;
				short num2 = num;
				num = (short)2021380954;
				switch (num2 == num)
				{
				}
				num = (short)10158081;
				if (num != 0)
				{
				}
				num = (short)1477378048;
				if (num != 0)
				{
				}
				num = (short)1944584192;
				short num3 = num;
				return this.Binding.BindsDirectlyToSource;
			}
			set
			{
				short num = (short)1502369001;
				short num2 = num;
				num = (short)2077906153;
				switch (num2 == num)
				{
				}
				num = (short)877461505;
				if (num != 0)
				{
				}
				num = (short)265289728;
				if (num != 0)
				{
				}
				num = (short)1197146112;
				short num3 = num;
				this.Binding.BindsDirectlyToSource = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000275 RID: 629 RVA: 0x000296AC File Offset: 0x000278AC
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00029760 File Offset: 0x00027960
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Data.IValueConverter Converter
		{
			get
			{
				short num = (short)20804332;
				short num2 = num;
				num = (short)1777496812;
				switch (num2 == num)
				{
				}
				num = (short)1618804736;
				if (num != 0)
				{
				}
				num = (short)953221121;
				if (num != 0)
				{
				}
				num = (short)1301741568;
				short num3 = num;
				return this.Binding.Converter;
			}
			set
			{
				short num = (short)1362267995;
				short num2 = num;
				num = (short)1712688987;
				switch (num2 == num)
				{
				}
				num = (short)1899888640;
				if (num != 0)
				{
				}
				num = (short)345899009;
				if (num != 0)
				{
				}
				num = (short)187695104;
				short num3 = num;
				this.Binding.Converter = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00029814 File Offset: 0x00027A14
		// (set) Token: 0x06000278 RID: 632 RVA: 0x000298CC File Offset: 0x00027ACC
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.CultureInfoIetfLanguageTagConverter))]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Globalization.CultureInfo ConverterCulture
		{
			get
			{
				short num = (short)1294318572;
				short num2 = num;
				num = (short)1135328236;
				switch (num2 == num)
				{
				}
				num = (short)1018494976;
				if (num != 0)
				{
				}
				num = (short)1764687873;
				if (num != 0)
				{
				}
				num = (short)2102198272;
				short num3 = num;
				return this.Binding.ConverterCulture;
			}
			set
			{
				short num = (short)592917311;
				short num2 = num;
				num = (short)651834175;
				switch (num2 == num)
				{
				}
				num = (short)1808596992;
				if (num != 0)
				{
				}
				num = (short)695992321;
				if (num != 0)
				{
				}
				num = (short)1584529408;
				short num3 = num;
				this.Binding.ConverterCulture = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00029984 File Offset: 0x00027B84
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00029A38 File Offset: 0x00027C38
		[global::System.ComponentModel.DefaultValue(null)]
		public object ConverterParameter
		{
			get
			{
				short num = (short)1647650872;
				short num2 = num;
				num = (short)878520376;
				switch (num2 == num)
				{
				}
				num = (short)1191641089;
				if (num != 0)
				{
				}
				num = (short)1859649536;
				if (num != 0)
				{
				}
				num = (short)1450835968;
				short num3 = num;
				return this.Binding.ConverterParameter;
			}
			set
			{
				short num = (short)1337949004;
				short num2 = num;
				num = (short)911440716;
				switch (num2 == num)
				{
				}
				num = (short)698679297;
				if (num != 0)
				{
				}
				num = (short)164691968;
				if (num != 0)
				{
				}
				num = (short)131268608;
				short num3 = num;
				this.Binding.ConverterParameter = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00029AEC File Offset: 0x00027CEC
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00029BA0 File Offset: 0x00027DA0
		[global::System.ComponentModel.DefaultValue(null)]
		public string ElementName
		{
			get
			{
				short num = (short)215560235;
				short num2 = num;
				num = (short)665137195;
				switch (num2 == num)
				{
				}
				num = (short)271187969;
				if (num != 0)
				{
				}
				num = (short)277217280;
				if (num != 0)
				{
				}
				num = (short)416808960;
				short num3 = num;
				return this.Binding.ElementName;
			}
			set
			{
				short num = (short)1634057907;
				short num2 = num;
				num = (short)110411443;
				switch (num2 == num)
				{
				}
				num = (short)866713601;
				if (num != 0)
				{
				}
				num = (short)1767964672;
				if (num != 0)
				{
				}
				num = (short)396165120;
				short num3 = num;
				this.Binding.ElementName = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00029C54 File Offset: 0x00027E54
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00029D0C File Offset: 0x00027F0C
		[global::System.ComponentModel.DefaultValue(null)]
		public object FallbackValue
		{
			get
			{
				short num = (short)1786080581;
				short num2 = num;
				num = (short)881880389;
				switch (num2 == num)
				{
				}
				num = (short)59834368;
				if (num != 0)
				{
				}
				num = (short)2031157249;
				if (num != 0)
				{
				}
				num = (short)67502080;
				short num3 = num;
				return this.Binding.FallbackValue;
			}
			set
			{
				short num = (short)1621012648;
				short num2 = num;
				num = (short)473149608;
				switch (num2 == num)
				{
				}
				num = (short)162594817;
				if (num != 0)
				{
				}
				num = (short)768606208;
				if (num != 0)
				{
				}
				num = (short)344522752;
				short num3 = num;
				this.Binding.FallbackValue = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00029DC4 File Offset: 0x00027FC4
		// (set) Token: 0x06000280 RID: 640 RVA: 0x00029E78 File Offset: 0x00028078
		[global::System.ComponentModel.DefaultValue(false)]
		public bool IsAsync
		{
			get
			{
				short num = (short)77135570;
				short num2 = num;
				num = (short)2088697554;
				switch (num2 == num)
				{
				}
				num = (short)900726785;
				if (num != 0)
				{
				}
				num = (short)359923712;
				if (num != 0)
				{
				}
				num = (short)1847787520;
				short num3 = num;
				return this.Binding.IsAsync;
			}
			set
			{
				short num = (short)2091902192;
				short num2 = num;
				num = (short)83551472;
				switch (num2 == num)
				{
				}
				num = (short)53673985;
				if (num != 0)
				{
				}
				num = (short)46596096;
				if (num != 0)
				{
				}
				num = (short)1323565056;
				short num3 = num;
				this.Binding.IsAsync = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00029F30 File Offset: 0x00028130
		// (set) Token: 0x06000282 RID: 642 RVA: 0x00029FE4 File Offset: 0x000281E4
		[global::System.ComponentModel.DefaultValue(global::System.Windows.Data.BindingMode.Default)]
		public global::System.Windows.Data.BindingMode Mode
		{
			get
			{
				short num = (short)1161052462;
				short num2 = num;
				num = (short)920600878;
				switch (num2 == num)
				{
				}
				num = (short)572063744;
				if (num != 0)
				{
				}
				num = (short)1712193537;
				if (num != 0)
				{
				}
				num = (short)1064173568;
				short num3 = num;
				return this.Binding.Mode;
			}
			set
			{
				short num = (short)721682433;
				if (num != 0)
				{
				}
				num = (short)1743607045;
				short num2 = num;
				num = (short)1665422597;
				switch (num2 == num)
				{
				}
				num = (short)983105536;
				if (num != 0)
				{
				}
				num = (short)2020147200;
				short num3 = num;
				this.Binding.Mode = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0002A098 File Offset: 0x00028298
		// (set) Token: 0x06000284 RID: 644 RVA: 0x0002A14C File Offset: 0x0002834C
		[global::System.ComponentModel.DefaultValue(false)]
		public bool NotifyOnSourceUpdated
		{
			get
			{
				short num = (short)1305799727;
				short num2 = num;
				num = (short)2145446959;
				switch (num2 == num)
				{
				}
				num = (short)1779761153;
				if (num != 0)
				{
				}
				num = (short)863043584;
				if (num != 0)
				{
				}
				num = (short)987824128;
				short num3 = num;
				return this.Binding.NotifyOnSourceUpdated;
			}
			set
			{
				short num = (short)1813865996;
				short num2 = num;
				num = (short)1347970572;
				switch (num2 == num)
				{
				}
				num = (short)1078984705;
				if (num != 0)
				{
				}
				num = (short)181534720;
				if (num != 0)
				{
				}
				num = (short)907345920;
				short num3 = num;
				this.Binding.NotifyOnSourceUpdated = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0002A200 File Offset: 0x00028400
		// (set) Token: 0x06000286 RID: 646 RVA: 0x0002A2B8 File Offset: 0x000284B8
		[global::System.ComponentModel.DefaultValue(false)]
		public bool NotifyOnTargetUpdated
		{
			get
			{
				short num = (short)847526407;
				short num2 = num;
				num = (short)764492295;
				switch (num2 == num)
				{
				}
				num = (short)901054465;
				if (num != 0)
				{
				}
				num = (short)1388707840;
				if (num != 0)
				{
				}
				num = (short)809369600;
				short num3 = num;
				return this.Binding.NotifyOnTargetUpdated;
			}
			set
			{
				short num = (short)592642872;
				short num2 = num;
				num = (short)480707384;
				switch (num2 == num)
				{
				}
				num = (short)1038417920;
				if (num != 0)
				{
				}
				num = (short)858062849;
				if (num != 0)
				{
				}
				num = (short)2141782016;
				short num3 = num;
				this.Binding.NotifyOnTargetUpdated = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0002A36C File Offset: 0x0002856C
		// (set) Token: 0x06000288 RID: 648 RVA: 0x0002A424 File Offset: 0x00028624
		[global::System.ComponentModel.DefaultValue(false)]
		public bool NotifyOnValidationError
		{
			get
			{
				short num = (short)2093934661;
				short num2 = num;
				num = (short)1710942277;
				switch (num2 == num)
				{
				}
				num = (short)1060110337;
				if (num != 0)
				{
				}
				num = (short)1774190592;
				if (num != 0)
				{
				}
				num = (short)1529544704;
				short num3 = num;
				return this.Binding.NotifyOnValidationError;
			}
			set
			{
				short num = (short)1187444631;
				short num2 = num;
				num = (short)101775255;
				switch (num2 == num)
				{
				}
				num = (short)2047934464;
				if (num != 0)
				{
				}
				num = (short)1700003841;
				if (num != 0)
				{
				}
				num = (short)1943666688;
				short num3 = num;
				this.Binding.NotifyOnValidationError = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0002A4D8 File Offset: 0x000286D8
		// (set) Token: 0x0600028A RID: 650 RVA: 0x0002A58C File Offset: 0x0002878C
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.PropertyPath Path
		{
			get
			{
				short num = (short)874216018;
				short num2 = num;
				num = (short)1804368466;
				switch (num2 == num)
				{
				}
				num = (short)935788545;
				if (num != 0)
				{
				}
				num = (short)1672478720;
				if (num != 0)
				{
				}
				num = (short)1578565632;
				short num3 = num;
				return this.Binding.Path;
			}
			set
			{
				short num = (short)583844951;
				short num2 = num;
				num = (short)1716372567;
				switch (num2 == num)
				{
				}
				num = (short)1317404673;
				if (num != 0)
				{
				}
				num = (short)1969160192;
				if (num != 0)
				{
				}
				num = (short)419758080;
				short num3 = num;
				this.Binding.Path = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0002A644 File Offset: 0x00028844
		// (set) Token: 0x0600028C RID: 652 RVA: 0x0002A6F8 File Offset: 0x000288F8
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Data.RelativeSource RelativeSource
		{
			get
			{
				short num = (short)1041179677;
				short num2 = num;
				num = (short)562766877;
				switch (num2 == num)
				{
				}
				num = (short)1356595201;
				if (num != 0)
				{
				}
				num = (short)738721792;
				if (num != 0)
				{
				}
				num = (short)1432223744;
				short num3 = num;
				return this.Binding.RelativeSource;
			}
			set
			{
				short num = (short)1695741504;
				short num2 = num;
				num = (short)1648948800;
				switch (num2 == num)
				{
				}
				num = (short)627048448;
				if (num != 0)
				{
				}
				num = (short)746913793;
				if (num != 0)
				{
				}
				num = (short)2007826432;
				short num3 = num;
				this.Binding.RelativeSource = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0002A7B0 File Offset: 0x000289B0
		// (set) Token: 0x0600028E RID: 654 RVA: 0x0002A868 File Offset: 0x00028A68
		[global::System.ComponentModel.DefaultValue(null)]
		public object Source
		{
			get
			{
				short num = (short)1457774226;
				short num2 = num;
				num = (short)684646034;
				switch (num2 == num)
				{
				}
				num = (short)1780678656;
				if (num != 0)
				{
				}
				num = (short)1469579265;
				if (num != 0)
				{
				}
				num = (short)508887040;
				short num3 = num;
				return this.Binding.Source;
			}
			set
			{
				short num = (short)397901380;
				short num2 = num;
				num = (short)713457220;
				switch (num2 == num)
				{
				}
				num = (short)1530920961;
				if (num != 0)
				{
				}
				num = (short)2011561984;
				if (num != 0)
				{
				}
				num = (short)1243152384;
				short num3 = num;
				this.Binding.Source = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0002A920 File Offset: 0x00028B20
		// (set) Token: 0x06000290 RID: 656 RVA: 0x0002A9D8 File Offset: 0x00028BD8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Data.UpdateSourceExceptionFilterCallback UpdateSourceExceptionFilter
		{
			get
			{
				short num = (short)156040286;
				short num2 = num;
				num = (short)1589640286;
				switch (num2 == num)
				{
				}
				num = (short)1827799041;
				if (num != 0)
				{
				}
				num = (short)1187512320;
				if (num != 0)
				{
				}
				num = (short)1634992128;
				short num3 = num;
				return this.Binding.UpdateSourceExceptionFilter;
			}
			set
			{
				short num = (short)841875457;
				if (num != 0)
				{
				}
				num = (short)280810895;
				short num2 = num;
				num = (short)258790799;
				switch (num2 == num)
				{
				}
				num = (short)1257439232;
				if (num != 0)
				{
				}
				num = (short)1141178368;
				short num3 = num;
				this.Binding.UpdateSourceExceptionFilter = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000291 RID: 657 RVA: 0x0002AA90 File Offset: 0x00028C90
		// (set) Token: 0x06000292 RID: 658 RVA: 0x0002AB44 File Offset: 0x00028D44
		[global::System.ComponentModel.DefaultValue(global::System.Windows.Data.UpdateSourceTrigger.PropertyChanged)]
		public global::System.Windows.Data.UpdateSourceTrigger UpdateSourceTrigger
		{
			get
			{
				short num = (short)1324648080;
				short num2 = num;
				num = (short)488539792;
				switch (num2 == num)
				{
				}
				num = (short)952631297;
				if (num != 0)
				{
				}
				num = (short)374013952;
				if (num != 0)
				{
				}
				num = (short)983695360;
				short num3 = num;
				return this.Binding.UpdateSourceTrigger;
			}
			set
			{
				short num = (short)2127298561;
				if (num != 0)
				{
				}
				num = (short)1797516283;
				short num2 = num;
				num = (short)1815211003;
				switch (num2 == num)
				{
				}
				num = (short)392953856;
				short num3 = num;
				num = (short)378994688;
				if (num != 0)
				{
				}
				this.Binding.UpdateSourceTrigger = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0002ABFC File Offset: 0x00028DFC
		// (set) Token: 0x06000294 RID: 660 RVA: 0x0002ACB0 File Offset: 0x00028EB0
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ValidatesOnDataErrors
		{
			get
			{
				short num = (short)963049493;
				short num2 = num;
				num = (short)431093781;
				switch (num2 == num)
				{
				}
				num = (short)1270415361;
				if (num != 0)
				{
				}
				num = (short)1729560576;
				short num3 = num;
				num = (short)1401683968;
				if (num != 0)
				{
				}
				return this.Binding.ValidatesOnDataErrors;
			}
			set
			{
				short num = (short)819525063;
				short num2 = num;
				num = (short)425063879;
				switch (num2 == num)
				{
				}
				num = (short)905314305;
				if (num != 0)
				{
				}
				num = (short)1252851712;
				short num3 = num;
				num = (short)970194944;
				if (num != 0)
				{
				}
				this.Binding.ValidatesOnDataErrors = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0002AD64 File Offset: 0x00028F64
		// (set) Token: 0x06000296 RID: 662 RVA: 0x0002AE1C File Offset: 0x0002901C
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ValidatesOnExceptions
		{
			get
			{
				short num = (short)1175446765;
				short num2 = num;
				num = (short)1009706221;
				switch (num2 == num)
				{
				}
				num = (short)826933249;
				if (num != 0)
				{
				}
				num = (short)1465188352;
				short num3 = num;
				num = (short)378404864;
				if (num != 0)
				{
				}
				return this.Binding.ValidatesOnExceptions;
			}
			set
			{
				short num = (short)1164206743;
				short num2 = num;
				num = (short)683238039;
				switch (num2 == num)
				{
				}
				num = (short)2082996224;
				if (num != 0)
				{
				}
				num = (short)1244397568;
				short num3 = num;
				num = (short)1799421953;
				if (num != 0)
				{
				}
				this.Binding.ValidatesOnExceptions = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0002AED4 File Offset: 0x000290D4
		// (set) Token: 0x06000298 RID: 664 RVA: 0x0002AF88 File Offset: 0x00029188
		[global::System.ComponentModel.DefaultValue(null)]
		public string XPath
		{
			get
			{
				short num = (short)514981889;
				if (num != 0)
				{
				}
				num = (short)171638009;
				short num2 = num;
				num = (short)1492450553;
				switch (num2 == num)
				{
				}
				num = (short)2046492672;
				short num3 = num;
				num = (short)1387528192;
				if (num != 0)
				{
				}
				return this.Binding.XPath;
			}
			set
			{
				short num = (short)1653472682;
				short num2 = num;
				num = (short)632487338;
				switch (num2 == num)
				{
				}
				num = (short)1986330625;
				if (num != 0)
				{
				}
				num = (short)1857028096;
				short num3 = num;
				num = (short)777191424;
				if (num != 0)
				{
				}
				this.Binding.XPath = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0002B040 File Offset: 0x00029240
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Collections.ObjectModel.Collection<global::System.Windows.Controls.ValidationRule> ValidationRules
		{
			get
			{
				short num = (short)430553985;
				short num2 = num;
				num = (short)1215282049;
				switch (num2 == num)
				{
				}
				num = (short)383713281;
				if (num != 0)
				{
				}
				num = (short)935854080;
				short num3 = num;
				num = (short)835780608;
				if (num != 0)
				{
				}
				return this.Binding.ValidationRules;
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0002B0F8 File Offset: 0x000292F8
		protected override void CloneCore(global::System.Windows.Freezable sourceFreezable)
		{
			switch (0)
			{
			case 0:
				goto IL_61;
			}
			short num;
			int num3;
			global::Motorola.CommonCPS.RadioManagement.Controls.FreezableBinding freezableBinding;
			for (;;)
			{
				IL_0A:
				num = (short)1561133056;
				short num2 = num;
				global::System.Collections.Generic.IEnumerator<global::System.Windows.Controls.ValidationRule> enumerator;
				switch (num3)
				{
				case 0:
					goto IL_A4;
				case 1:
					if (freezableBinding.Source != null)
					{
						num = (short)118292481;
						if (num != 0)
						{
						}
						num = (short)955449350;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A4;
				case 2:
					if (freezableBinding.RelativeSource != null)
					{
						num = (short)1816199172;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_394;
				case 3:
					goto IL_A4;
				case 4:
					this.RelativeSource = freezableBinding.RelativeSource;
					num = (short)517931011;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (freezableBinding.ElementName != null)
					{
						num = (short)452067337;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1354432514;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.Source = freezableBinding.Source;
					num = (short)1546715136;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_A4;
				case 8:
					try
					{
						num = (short)1449787396;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
							{
								num = (short)902670130;
								short num4 = num;
								num = (short)1146791730;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1488846848;
									if (num != 0)
									{
									}
									num = (short)228917249;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_326;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1301872640;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Windows.Controls.ValidationRule item = enumerator.Current;
								this.ValidationRules.Add(item);
								num = (short)1972699139;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								switch (0)
								{
								case 0:
									goto IL_266;
								}
								continue;
							}
							IL_291:
							num = (short)470417410;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_266:
							goto IL_291;
						}
						IL_326:
						goto IL_424;
					}
					finally
					{
						num = (short)54132738;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								enumerator.Dispose();
								num = (short)586874881;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_391;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_35C;
								}
								continue;
							}
							IL_35C:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1610874880;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_391:;
					}
					goto IL_394;
				case 9:
					this.ElementName = freezableBinding.ElementName;
					num = (short)439222279;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_61;
				IL_A4:
				this.AsyncState = freezableBinding.AsyncState;
				this.BindsDirectlyToSource = freezableBinding.BindsDirectlyToSource;
				this.Converter = freezableBinding.Converter;
				this.ConverterCulture = freezableBinding.ConverterCulture;
				this.ConverterParameter = freezableBinding.ConverterParameter;
				this.FallbackValue = freezableBinding.FallbackValue;
				this.IsAsync = freezableBinding.IsAsync;
				this.Mode = freezableBinding.Mode;
				this.NotifyOnSourceUpdated = freezableBinding.NotifyOnSourceUpdated;
				this.NotifyOnTargetUpdated = freezableBinding.NotifyOnTargetUpdated;
				this.NotifyOnValidationError = freezableBinding.NotifyOnValidationError;
				this.Path = freezableBinding.Path;
				this.UpdateSourceExceptionFilter = freezableBinding.UpdateSourceExceptionFilter;
				this.UpdateSourceTrigger = freezableBinding.UpdateSourceTrigger;
				this.ValidatesOnDataErrors = freezableBinding.ValidatesOnDataErrors;
				this.ValidatesOnExceptions = freezableBinding.ValidatesOnExceptions;
				this.XPath = this.XPath;
				enumerator = freezableBinding.ValidationRules.GetEnumerator();
				num = (short)1274806280;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_394:
				num = (short)201785345;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_424:
			base.CloneCore(sourceFreezable);
			return;
			IL_61:
			freezableBinding = (sourceFreezable as global::Motorola.CommonCPS.RadioManagement.Controls.FreezableBinding);
			num = (short)128712709;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0002B540 File Offset: 0x00029740
		protected override global::System.Windows.Freezable CreateInstanceCore()
		{
			short num = (short)54664797;
			short num2 = num;
			num = (short)292494941;
			switch (num2 == num)
			{
			}
			num = (short)1087176705;
			if (num != 0)
			{
			}
			num = (short)525336576;
			short num3 = num;
			num = (short)848625664;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.Controls.FreezableBinding();
		}

		// Token: 0x040000BA RID: 186
		private global::System.Windows.Data.Binding a;
	}
}
