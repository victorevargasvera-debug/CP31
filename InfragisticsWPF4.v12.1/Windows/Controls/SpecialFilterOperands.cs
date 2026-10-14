using System;
using System.Collections.Generic;
using System.ComponentModel;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200015E RID: 350
	public class SpecialFilterOperands
	{
		// Token: 0x06000BBA RID: 3002 RVA: 0x00026EC4 File Offset: 0x000250C4
		static SpecialFilterOperands()
		{
			foreach (global::Infragistics.Windows.Controls.SpecialFilterOperandBase specialFilterOperandBase in global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.GetBuiltInOperands())
			{
				string name = specialFilterOperandBase.Name;
				global::Infragistics.Windows.Controls.SpecialFilterOperands.g_builtInOperands.Add(name, specialFilterOperandBase);
				global::Infragistics.Windows.Controls.SpecialFilterOperands.g_operands.Add(name, specialFilterOperandBase);
			}
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00026F48 File Offset: 0x00025148
		private SpecialFilterOperands()
		{
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00026F50 File Offset: 0x00025150
		internal static object GetSerializationValue(global::Infragistics.Windows.Controls.SpecialFilterOperandBase source)
		{
			if (source is global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.IGOperand || source is global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper)
			{
				return source;
			}
			global::Infragistics.Windows.Controls.SpecialFilterOperandBase registeredOperand = global::Infragistics.Windows.Controls.SpecialFilterOperands.GetRegisteredOperand(source.Name);
			if (registeredOperand == source)
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper(source.Name);
			}
			return source;
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00026F8C File Offset: 0x0002518C
		internal static void RegisterSerializationInfos(global::Infragistics.Windows.Internal.ObjectSerializerBase serializer)
		{
			serializer.RegisterInfo(typeof(global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper), new global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.OperandWrapperSerializationInfo());
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x00026FA3 File Offset: 0x000251A3
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase CreateDateRangeOperand(global::System.DateTime relativeDate, global::Infragistics.Windows.Controls.DateRangeScope scope)
		{
			return new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand(relativeDate, scope);
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x00026FAC File Offset: 0x000251AC
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase GetBuiltInOperand(string name)
		{
			global::Infragistics.Windows.Controls.SpecialFilterOperandBase result;
			if (global::Infragistics.Windows.Controls.SpecialFilterOperands.g_builtInOperands.TryGetValue(name, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00026FCC File Offset: 0x000251CC
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase GetRegisteredOperand(string name)
		{
			global::Infragistics.Windows.Controls.SpecialFilterOperandBase result;
			lock (global::Infragistics.Windows.Controls.SpecialFilterOperands.g_operands)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperands.g_operands.TryGetValue(name, out result);
			}
			return result;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00027014 File Offset: 0x00025214
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase[] GetRegisteredOperands()
		{
			return global::Infragistics.Windows.Controls.SpecialFilterOperands.GetRegisteredOperands(null);
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0002701C File Offset: 0x0002521C
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase[] GetRegisteredOperands(global::System.Type dataType)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.SpecialFilterOperandBase> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Controls.SpecialFilterOperandBase>();
			lock (global::Infragistics.Windows.Controls.SpecialFilterOperands.g_operands)
			{
				foreach (global::Infragistics.Windows.Controls.SpecialFilterOperandBase specialFilterOperandBase in global::Infragistics.Windows.Controls.SpecialFilterOperands.g_operands.Values)
				{
					if (null == dataType || specialFilterOperandBase.SupportsDataType(dataType))
					{
						list.Add(specialFilterOperandBase);
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x000270BC File Offset: 0x000252BC
		public static void Register(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
		{
			lock (global::Infragistics.Windows.Controls.SpecialFilterOperands.g_operands)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperands.g_operands[operand.Name] = operand;
				global::Infragistics.Windows.Controls.SpecialFilterOperands.g_registeredOperandsVersion++;
			}
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00027114 File Offset: 0x00025314
		public static void Unregister(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
		{
			lock (global::Infragistics.Windows.Controls.SpecialFilterOperands.g_operands)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperands.g_operands.Remove(operand.Name);
				global::Infragistics.Windows.Controls.SpecialFilterOperands.g_registeredOperandsVersion++;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x0002716C File Offset: 0x0002536C
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Blanks
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Blanks");
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x00027178 File Offset: 0x00025378
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase NonBlanks
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("NonBlanks");
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x00027184 File Offset: 0x00025384
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase AboveAverage
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("AboveAverage");
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x00027190 File Offset: 0x00025390
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase BelowAverage
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("BelowAverage");
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x0002719C File Offset: 0x0002539C
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Top10
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Top10");
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x000271A8 File Offset: 0x000253A8
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Top10Percentage
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Top10Percentage");
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x000271B4 File Offset: 0x000253B4
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Bottom10
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Bottom10");
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x000271C0 File Offset: 0x000253C0
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Bottom10Percentage
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Bottom10Percentage");
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x000271CC File Offset: 0x000253CC
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Tomorrow
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Tomorrow");
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x000271D8 File Offset: 0x000253D8
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Today
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Today");
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000BCF RID: 3023 RVA: 0x000271E4 File Offset: 0x000253E4
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Yesterday
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Yesterday");
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x000271F0 File Offset: 0x000253F0
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase NextWeek
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("NextWeek");
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x000271FC File Offset: 0x000253FC
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase ThisWeek
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("ThisWeek");
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x00027208 File Offset: 0x00025408
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase LastWeek
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("LastWeek");
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x00027214 File Offset: 0x00025414
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase NextMonth
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("NextMonth");
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x00027220 File Offset: 0x00025420
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase ThisMonth
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("ThisMonth");
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000BD5 RID: 3029 RVA: 0x0002722C File Offset: 0x0002542C
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase LastMonth
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("LastMonth");
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x00027238 File Offset: 0x00025438
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase NextQuarter
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("NextQuarter");
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x00027244 File Offset: 0x00025444
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase ThisQuarter
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("ThisQuarter");
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x00027250 File Offset: 0x00025450
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase LastQuarter
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("LastQuarter");
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x0002725C File Offset: 0x0002545C
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase NextYear
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("NextYear");
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x00027268 File Offset: 0x00025468
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase ThisYear
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("ThisYear");
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x00027274 File Offset: 0x00025474
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase LastYear
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("LastYear");
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x00027280 File Offset: 0x00025480
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase YearToDate
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("YearToDate");
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x0002728C File Offset: 0x0002548C
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Quarter1
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Quarter1");
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x00027298 File Offset: 0x00025498
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Quarter2
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Quarter2");
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x000272A4 File Offset: 0x000254A4
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Quarter3
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Quarter3");
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x000272B0 File Offset: 0x000254B0
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Quarter4
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Quarter4");
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x000272BC File Offset: 0x000254BC
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase January
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("January");
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x000272C8 File Offset: 0x000254C8
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase February
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("February");
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x000272D4 File Offset: 0x000254D4
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase March
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("March");
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x000272E0 File Offset: 0x000254E0
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase April
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("April");
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x000272EC File Offset: 0x000254EC
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase May
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("May");
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x000272F8 File Offset: 0x000254F8
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase June
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("June");
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x00027304 File Offset: 0x00025504
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase July
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("July");
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x00027310 File Offset: 0x00025510
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase August
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("August");
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x0002731C File Offset: 0x0002551C
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase September
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("September");
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00027328 File Offset: 0x00025528
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase October
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("October");
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x00027334 File Offset: 0x00025534
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase November
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("November");
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00027340 File Offset: 0x00025540
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase December
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("December");
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000BED RID: 3053 RVA: 0x0002734C File Offset: 0x0002554C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		public static int Version
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.g_registeredOperandsVersion;
			}
		}

		// Token: 0x04000559 RID: 1369
		private static int g_registeredOperandsVersion = 1;

		// Token: 0x0400055A RID: 1370
		private static global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.Controls.SpecialFilterOperandBase> g_builtInOperands = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.Controls.SpecialFilterOperandBase>();

		// Token: 0x0400055B RID: 1371
		private static global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.Controls.SpecialFilterOperandBase> g_operands = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.Controls.SpecialFilterOperandBase>();

		// Token: 0x0200015F RID: 351
		internal class OperandWrapper : global::Infragistics.Windows.Controls.SpecialFilterOperandBase
		{
			// Token: 0x06000BEF RID: 3055 RVA: 0x0002735F File Offset: 0x0002555F
			private OperandWrapper(string operandName)
			{
				this._operandName = operandName;
			}

			// Token: 0x06000BF0 RID: 3056 RVA: 0x00027370 File Offset: 0x00025570
			protected override bool EqualsOverride(global::Infragistics.Windows.Controls.SpecialFilterOperandBase obj)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandBase source = this.Source;
				global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper operandWrapper = obj as global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper;
				global::Infragistics.Windows.Controls.SpecialFilterOperandBase specialFilterOperandBase;
				if (operandWrapper != null)
				{
					specialFilterOperandBase = operandWrapper.Source;
					if (source == null && specialFilterOperandBase == null)
					{
						return this.Name == operandWrapper.Name;
					}
				}
				else
				{
					specialFilterOperandBase = obj;
				}
				return source != null && specialFilterOperandBase != null && source.Equals(specialFilterOperandBase);
			}

			// Token: 0x06000BF1 RID: 3057 RVA: 0x000273C0 File Offset: 0x000255C0
			public override int GetHashCode()
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandBase source = this.Source;
				if (source == null)
				{
					return 0;
				}
				return source.GetHashCode();
			}

			// Token: 0x06000BF2 RID: 3058 RVA: 0x000273E0 File Offset: 0x000255E0
			public override string ToString()
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandBase source = this.Source;
				if (source == null)
				{
					return this.Name;
				}
				return source.ToString();
			}

			// Token: 0x1700024A RID: 586
			// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x00027404 File Offset: 0x00025604
			private global::Infragistics.Windows.Controls.SpecialFilterOperandBase Source
			{
				get
				{
					if (this._verifiedRegisteredOperandsVersion != global::Infragistics.Windows.Controls.SpecialFilterOperands.g_registeredOperandsVersion)
					{
						this._verifiedRegisteredOperandsVersion = global::Infragistics.Windows.Controls.SpecialFilterOperands.g_registeredOperandsVersion;
						global::Infragistics.Windows.Controls.SpecialFilterOperandBase specialFilterOperandBase = global::Infragistics.Windows.Controls.SpecialFilterOperands.GetRegisteredOperand(this._operandName);
						if (specialFilterOperandBase == null)
						{
							specialFilterOperandBase = global::Infragistics.Windows.Controls.SpecialFilterOperands.GetBuiltInOperand(this._operandName);
						}
						if (specialFilterOperandBase != null)
						{
							this._cachedOperand = specialFilterOperandBase;
						}
					}
					return this._cachedOperand;
				}
			}

			// Token: 0x1700024B RID: 587
			// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x00027454 File Offset: 0x00025654
			public override object Description
			{
				get
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandBase source = this.Source;
					if (source == null)
					{
						return string.Empty;
					}
					return source.Description;
				}
			}

			// Token: 0x1700024C RID: 588
			// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x00027478 File Offset: 0x00025678
			public override object DisplayContent
			{
				get
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandBase source = this.Source;
					if (source == null)
					{
						return null;
					}
					return source.DisplayContent;
				}
			}

			// Token: 0x1700024D RID: 589
			// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x00027498 File Offset: 0x00025698
			public override string Name
			{
				get
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandBase source = this.Source;
					if (source == null)
					{
						return this._operandName;
					}
					return source.Name;
				}
			}

			// Token: 0x1700024E RID: 590
			// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x000274BC File Offset: 0x000256BC
			public override bool UsesAllValues
			{
				get
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandBase source = this.Source;
					return source != null && source.UsesAllValues;
				}
			}

			// Token: 0x06000BF8 RID: 3064 RVA: 0x000274DC File Offset: 0x000256DC
			internal static global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper GetWrapper(string operandName)
			{
				lock (global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.g_wrappers)
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper operandWrapper;
					if (global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.g_wrappers.TryGetValue(operandName, out operandWrapper))
					{
						return operandWrapper;
					}
					operandWrapper = new global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper(operandName);
					if (operandWrapper.Source != null)
					{
						global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.g_wrappers[operandName] = operandWrapper;
						return operandWrapper;
					}
				}
				return null;
			}

			// Token: 0x06000BF9 RID: 3065 RVA: 0x0002754C File Offset: 0x0002574C
			public override bool IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandBase source = this.Source;
				return source != null && source.IsMatch(comparisonOperator, value, context);
			}

			// Token: 0x06000BFA RID: 3066 RVA: 0x00027570 File Offset: 0x00025770
			public override bool SupportsOperator(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandBase source = this.Source;
				return source != null && source.SupportsOperator(comparisonOperator);
			}

			// Token: 0x06000BFB RID: 3067 RVA: 0x00027590 File Offset: 0x00025790
			public override bool SupportsDataType(global::System.Type type)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandBase source = this.Source;
				return source != null && source.SupportsDataType(type);
			}

			// Token: 0x0400055C RID: 1372
			private string _operandName;

			// Token: 0x0400055D RID: 1373
			private int _verifiedRegisteredOperandsVersion;

			// Token: 0x0400055E RID: 1374
			private global::Infragistics.Windows.Controls.SpecialFilterOperandBase _cachedOperand;

			// Token: 0x0400055F RID: 1375
			private static global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper> g_wrappers = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper>();

			// Token: 0x02000160 RID: 352
			internal class OperandWrapperSerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
			{
				// Token: 0x1700024F RID: 591
				// (get) Token: 0x06000BFC RID: 3068 RVA: 0x000275B0 File Offset: 0x000257B0
				public override global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> SerializedProperties
				{
					get
					{
						if (this._props == null)
						{
							this._props = new global::Infragistics.Windows.Internal.PropertySerializationInfo[]
							{
								new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(string), "Name")
							};
						}
						return this._props;
					}
				}

				// Token: 0x06000BFD RID: 3069 RVA: 0x000275F0 File Offset: 0x000257F0
				public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper operandWrapper = (global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper)obj;
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
					dictionary["Name"] = operandWrapper.Name;
					return dictionary;
				}

				// Token: 0x06000BFE RID: 3070 RVA: 0x0002761C File Offset: 0x0002581C
				public override object Deserialize(global::System.Collections.Generic.Dictionary<string, object> values)
				{
					object obj;
					if (values.TryGetValue("Name", out obj))
					{
						return new global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper((string)obj);
					}
					return null;
				}

				// Token: 0x04000560 RID: 1376
				private const string NameProp = "Name";

				// Token: 0x04000561 RID: 1377
				private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
			}
		}
	}
}
