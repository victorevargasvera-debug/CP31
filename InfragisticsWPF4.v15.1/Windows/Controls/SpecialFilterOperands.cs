using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000180 RID: 384
	public class SpecialFilterOperands
	{
		// Token: 0x06000CCE RID: 3278 RVA: 0x0002B044 File Offset: 0x00029244
		static SpecialFilterOperands()
		{
			foreach (global::Infragistics.Windows.Controls.SpecialFilterOperandBase specialFilterOperandBase in global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.GetBuiltInOperands())
			{
				string name = specialFilterOperandBase.Name;
				global::Infragistics.Windows.Controls.SpecialFilterOperands.g_builtInOperands.Add(name, specialFilterOperandBase);
				global::Infragistics.Windows.Controls.SpecialFilterOperands.g_operands.Add(name, specialFilterOperandBase);
			}
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x0002B0C8 File Offset: 0x000292C8
		private SpecialFilterOperands()
		{
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x0002B0D0 File Offset: 0x000292D0
		internal static global::Infragistics.Windows.Controls.SpecialFilterOperandBase CreateInOperand(global::System.Collections.IEnumerable items)
		{
			return new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.InOperand(items);
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0002B0D8 File Offset: 0x000292D8
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

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0002B114 File Offset: 0x00029314
		internal static void RegisterSerializationInfos(global::Infragistics.Windows.Internal.ObjectSerializerBase serializer)
		{
			serializer.RegisterInfo(typeof(global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper), new global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.OperandWrapperSerializationInfo());
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0002B12B File Offset: 0x0002932B
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase CreateDateRangeOperand(global::System.DateTime relativeDate, global::Infragistics.Windows.Controls.DateRangeScope scope)
		{
			return new global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.DateRangeOperand(relativeDate, scope);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0002B134 File Offset: 0x00029334
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase GetBuiltInOperand(string name)
		{
			global::Infragistics.Windows.Controls.SpecialFilterOperandBase result;
			if (global::Infragistics.Windows.Controls.SpecialFilterOperands.g_builtInOperands.TryGetValue(name, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0002B154 File Offset: 0x00029354
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase GetRegisteredOperand(string name)
		{
			global::Infragistics.Windows.Controls.SpecialFilterOperandBase result;
			lock (global::Infragistics.Windows.Controls.SpecialFilterOperands.g_operands)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperands.g_operands.TryGetValue(name, out result);
			}
			return result;
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x0002B19C File Offset: 0x0002939C
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase[] GetRegisteredOperands()
		{
			return global::Infragistics.Windows.Controls.SpecialFilterOperands.GetRegisteredOperands(null);
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0002B1A4 File Offset: 0x000293A4
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

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0002B244 File Offset: 0x00029444
		public static void Register(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
		{
			lock (global::Infragistics.Windows.Controls.SpecialFilterOperands.g_operands)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperands.g_operands[operand.Name] = operand;
				global::Infragistics.Windows.Controls.SpecialFilterOperands.g_registeredOperandsVersion++;
			}
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0002B29C File Offset: 0x0002949C
		public static void Unregister(global::Infragistics.Windows.Controls.SpecialFilterOperandBase operand)
		{
			lock (global::Infragistics.Windows.Controls.SpecialFilterOperands.g_operands)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperands.g_operands.Remove(operand.Name);
				global::Infragistics.Windows.Controls.SpecialFilterOperands.g_registeredOperandsVersion++;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x0002B2F4 File Offset: 0x000294F4
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Blanks
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Blanks");
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x0002B300 File Offset: 0x00029500
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase NonBlanks
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("NonBlanks");
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x0002B30C File Offset: 0x0002950C
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase AboveAverage
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("AboveAverage");
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x0002B318 File Offset: 0x00029518
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase BelowAverage
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("BelowAverage");
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0002B324 File Offset: 0x00029524
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Top10
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Top10");
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x0002B330 File Offset: 0x00029530
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Top10Percentage
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Top10Percentage");
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x0002B33C File Offset: 0x0002953C
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Bottom10
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Bottom10");
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x0002B348 File Offset: 0x00029548
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Bottom10Percentage
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Bottom10Percentage");
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x0002B354 File Offset: 0x00029554
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Tomorrow
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Tomorrow");
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x0002B360 File Offset: 0x00029560
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Today
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Today");
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x0002B36C File Offset: 0x0002956C
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Yesterday
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Yesterday");
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0002B378 File Offset: 0x00029578
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase NextWeek
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("NextWeek");
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x0002B384 File Offset: 0x00029584
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase ThisWeek
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("ThisWeek");
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x0002B390 File Offset: 0x00029590
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase LastWeek
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("LastWeek");
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0002B39C File Offset: 0x0002959C
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase NextMonth
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("NextMonth");
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x0002B3A8 File Offset: 0x000295A8
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase ThisMonth
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("ThisMonth");
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x0002B3B4 File Offset: 0x000295B4
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase LastMonth
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("LastMonth");
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x0002B3C0 File Offset: 0x000295C0
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase NextQuarter
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("NextQuarter");
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x0002B3CC File Offset: 0x000295CC
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase ThisQuarter
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("ThisQuarter");
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x0002B3D8 File Offset: 0x000295D8
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase LastQuarter
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("LastQuarter");
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0002B3E4 File Offset: 0x000295E4
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase NextYear
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("NextYear");
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x0002B3F0 File Offset: 0x000295F0
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase ThisYear
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("ThisYear");
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x0002B3FC File Offset: 0x000295FC
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase LastYear
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("LastYear");
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x0002B408 File Offset: 0x00029608
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase YearToDate
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("YearToDate");
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x0002B414 File Offset: 0x00029614
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Quarter1
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Quarter1");
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x0002B420 File Offset: 0x00029620
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Quarter2
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Quarter2");
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x0002B42C File Offset: 0x0002962C
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Quarter3
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Quarter3");
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x0002B438 File Offset: 0x00029638
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase Quarter4
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("Quarter4");
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x0002B444 File Offset: 0x00029644
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase January
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("January");
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x0002B450 File Offset: 0x00029650
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase February
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("February");
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x0002B45C File Offset: 0x0002965C
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase March
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("March");
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x0002B468 File Offset: 0x00029668
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase April
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("April");
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x0002B474 File Offset: 0x00029674
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase May
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("May");
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000CFB RID: 3323 RVA: 0x0002B480 File Offset: 0x00029680
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase June
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("June");
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x0002B48C File Offset: 0x0002968C
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase July
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("July");
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000CFD RID: 3325 RVA: 0x0002B498 File Offset: 0x00029698
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase August
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("August");
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x0002B4A4 File Offset: 0x000296A4
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase September
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("September");
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x0002B4B0 File Offset: 0x000296B0
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase October
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("October");
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x0002B4BC File Offset: 0x000296BC
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase November
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("November");
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x0002B4C8 File Offset: 0x000296C8
		public static global::Infragistics.Windows.Controls.SpecialFilterOperandBase December
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper.GetWrapper("December");
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x0002B4D4 File Offset: 0x000296D4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		public static int Version
		{
			get
			{
				return global::Infragistics.Windows.Controls.SpecialFilterOperands.g_registeredOperandsVersion;
			}
		}

		// Token: 0x0400061A RID: 1562
		private static int g_registeredOperandsVersion = 1;

		// Token: 0x0400061B RID: 1563
		private static global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.Controls.SpecialFilterOperandBase> g_builtInOperands = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.Controls.SpecialFilterOperandBase>();

		// Token: 0x0400061C RID: 1564
		private static global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.Controls.SpecialFilterOperandBase> g_operands = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.Controls.SpecialFilterOperandBase>();

		// Token: 0x02000181 RID: 385
		internal class OperandWrapper : global::Infragistics.Windows.Controls.SpecialFilterOperandBase
		{
			// Token: 0x06000D04 RID: 3332 RVA: 0x0002B4E7 File Offset: 0x000296E7
			private OperandWrapper(string operandName)
			{
				this._operandName = operandName;
			}

			// Token: 0x06000D05 RID: 3333 RVA: 0x0002B4F8 File Offset: 0x000296F8
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

			// Token: 0x06000D06 RID: 3334 RVA: 0x0002B548 File Offset: 0x00029748
			public override int GetHashCode()
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandBase source = this.Source;
				if (source == null)
				{
					return 0;
				}
				return source.GetHashCode();
			}

			// Token: 0x06000D07 RID: 3335 RVA: 0x0002B568 File Offset: 0x00029768
			public override string ToString()
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandBase source = this.Source;
				if (source == null)
				{
					return this.Name;
				}
				return source.ToString();
			}

			// Token: 0x17000266 RID: 614
			// (get) Token: 0x06000D08 RID: 3336 RVA: 0x0002B58C File Offset: 0x0002978C
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

			// Token: 0x17000267 RID: 615
			// (get) Token: 0x06000D09 RID: 3337 RVA: 0x0002B5DC File Offset: 0x000297DC
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

			// Token: 0x17000268 RID: 616
			// (get) Token: 0x06000D0A RID: 3338 RVA: 0x0002B600 File Offset: 0x00029800
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

			// Token: 0x17000269 RID: 617
			// (get) Token: 0x06000D0B RID: 3339 RVA: 0x0002B620 File Offset: 0x00029820
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

			// Token: 0x1700026A RID: 618
			// (get) Token: 0x06000D0C RID: 3340 RVA: 0x0002B644 File Offset: 0x00029844
			public override bool UsesAllValues
			{
				get
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperandBase source = this.Source;
					return source != null && source.UsesAllValues;
				}
			}

			// Token: 0x06000D0D RID: 3341 RVA: 0x0002B664 File Offset: 0x00029864
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

			// Token: 0x06000D0E RID: 3342 RVA: 0x0002B6D4 File Offset: 0x000298D4
			public override bool IsMatch(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, object value, global::Infragistics.Windows.Controls.ConditionEvaluationContext context)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandBase source = this.Source;
				return source != null && source.IsMatch(comparisonOperator, value, context);
			}

			// Token: 0x06000D0F RID: 3343 RVA: 0x0002B6F8 File Offset: 0x000298F8
			public override bool SupportsOperator(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandBase source = this.Source;
				return source != null && source.SupportsOperator(comparisonOperator);
			}

			// Token: 0x06000D10 RID: 3344 RVA: 0x0002B718 File Offset: 0x00029918
			public override bool SupportsDataType(global::System.Type type)
			{
				global::Infragistics.Windows.Controls.SpecialFilterOperandBase source = this.Source;
				return source != null && source.SupportsDataType(type);
			}

			// Token: 0x0400061D RID: 1565
			private string _operandName;

			// Token: 0x0400061E RID: 1566
			private int _verifiedRegisteredOperandsVersion;

			// Token: 0x0400061F RID: 1567
			private global::Infragistics.Windows.Controls.SpecialFilterOperandBase _cachedOperand;

			// Token: 0x04000620 RID: 1568
			private static global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper> g_wrappers = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper>();

			// Token: 0x02000182 RID: 386
			internal class OperandWrapperSerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
			{
				// Token: 0x1700026B RID: 619
				// (get) Token: 0x06000D11 RID: 3345 RVA: 0x0002B738 File Offset: 0x00029938
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

				// Token: 0x06000D12 RID: 3346 RVA: 0x0002B778 File Offset: 0x00029978
				public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
				{
					global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper operandWrapper = (global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper)obj;
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
					dictionary["Name"] = operandWrapper.Name;
					return dictionary;
				}

				// Token: 0x06000D13 RID: 3347 RVA: 0x0002B7A4 File Offset: 0x000299A4
				public override object Deserialize(global::System.Collections.Generic.Dictionary<string, object> values)
				{
					object obj;
					if (values.TryGetValue("Name", out obj))
					{
						return new global::Infragistics.Windows.Controls.SpecialFilterOperands.OperandWrapper((string)obj);
					}
					return null;
				}

				// Token: 0x04000621 RID: 1569
				private const string NameProp = "Name";

				// Token: 0x04000622 RID: 1570
				private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
			}
		}
	}
}
