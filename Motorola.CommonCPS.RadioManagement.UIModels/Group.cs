using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000C0 RID: 192
	public class Group : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x0006D630 File Offset: 0x0006B830
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x0006D6E4 File Offset: 0x0006B8E4
		public string Name
		{
			get
			{
				short num = (short)1221786255;
				short num2 = num;
				num = (short)264632975;
				switch (num2 == num)
				{
				}
				num = (short)1210777601;
				if (num != 0)
				{
				}
				num = (short)1423507456;
				short num3 = num;
				num = (short)1286340608;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)338362370;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)412549120;
					short num3 = num;
					num = (short)1049082287;
					short num4 = num;
					num = (short)1812314543;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_166;
					default:
						num = (short)960561152;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							if (!base.IsLoading)
							{
								num = (short)1556742147;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_166;
						case 1:
							this.a = value;
							num = (short)1773338624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_AB;
							}
							continue;
						case 3:
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Group)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Group.get_Name())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)54460420;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_121;
						}
						IL_AB:
						if (!(value != this.a))
						{
							goto IL_166;
						}
						num = (short)1426718721;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_121:
				IL_166:
				num = (short)28508161;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x0006D880 File Offset: 0x0006BA80
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x0006D934 File Offset: 0x0006BB34
		public byte[] Timestamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1601765377;
				if (num != 0)
				{
				}
				num = (short)461899733;
				short num2 = num;
				num = (short)1344997333;
				switch (num2 == num)
				{
				}
				num = (short)221970432;
				short num3 = num;
				num = (short)764215296;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2065689551;
				short num2 = num;
				num = (short)1609493455;
				switch (num2 == num)
				{
				}
				num = (short)954073089;
				if (num != 0)
				{
				}
				num = (short)1001062400;
				short num3 = num;
				num = (short)2097152000;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x0006D9E8 File Offset: 0x0006BBE8
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x0006DA98 File Offset: 0x0006BC98
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> Children
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)140354788;
				short num2 = num;
				num = (short)282895588;
				switch (num2 == num)
				{
				}
				num = (short)38404097;
				if (num != 0)
				{
				}
				num = (short)556269568;
				short num3 = num;
				num = (short)1679818752;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1545255881;
				short num2 = num;
				num = (short)2087041993;
				switch (num2 == num)
				{
				}
				num = (short)97255424;
				if (num != 0)
				{
				}
				num = (short)390856704;
				short num3 = num;
				num = (short)1157431297;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x0006DB48 File Offset: 0x0006BD48
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x0006DBF8 File Offset: 0x0006BDF8
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Group Parent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1508507649;
				if (num != 0)
				{
				}
				num = (short)1248980850;
				short num2 = num;
				num = (short)323153778;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1637875712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1011679232;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)473956882;
				short num2 = num;
				num = (short)814416402;
				switch (num2 == num)
				{
				}
				num = (short)497352704;
				short num3 = num;
				num = (short)1685389313;
				if (num != 0)
				{
				}
				num = (short)837615616;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0006DCA4 File Offset: 0x0006BEA4
		public global::Motorola.CommonCPS.Server.EntityModel.ValidatedField AsValidatedField()
		{
			short num = (short)593113695;
			short num2 = num;
			num = (short)1535914591;
			switch (num2 == num)
			{
			}
			num = (short)298450944;
			short num3 = num;
			num = (short)1258487808;
			if (num != 0)
			{
			}
			num = (short)1744633857;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField(this.ID.Value, global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Group, this.Timestamp);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0006DD64 File Offset: 0x0006BF64
		public override string ToString()
		{
			short num = (short)1331232273;
			short num2 = num;
			num = (short)518323729;
			switch (num2 == num)
			{
			}
			num = (short)25821184;
			short num3 = num;
			num = (short)1546846209;
			if (num != 0)
			{
			}
			num = (short)2134114304;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x04000307 RID: 775
		private string a = global::Motorola.CommonCPS.ResourceRepository.Resources.Group_Field_None;

		// Token: 0x04000308 RID: 776
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private byte[] b;

		// Token: 0x04000309 RID: 777
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> c = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>();

		// Token: 0x0400030A RID: 778
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Group d = (global::Motorola.CommonCPS.RadioManagement.UIModels.Group)global::System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Group));
	}
}
