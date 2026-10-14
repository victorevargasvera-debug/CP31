using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000FF RID: 255
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class RefSet : global::Motorola.CommonCPS.Server.EntityModel.DBNode
	{
		// Token: 0x06000F74 RID: 3956 RVA: 0x000A5A10 File Offset: 0x000A3C10
		public override void Accept(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.IDBNodeVisitor visitor)
		{
			short num = (short)640240781;
			short num2 = num;
			num = (short)1547062413;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2111504385;
				if (num != 0)
				{
				}
				num = (short)893911040;
				if (num != 0)
				{
				}
				num = (short)1309147136;
				short num3 = num;
				visitor.VisitRefSet_Begin(this);
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator = base.ChildNodesList.GetEnumerator())
				{
					num = (short)1623916547;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_159;
						case 1:
							if (!enumerator.MoveNext())
							{
								num = (short)1016201220;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.Accept(visitor);
							num = (short)1137115138;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_E7;
							}
							continue;
						case 4:
							num = (short)792264704;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_10C:
						num = (short)1969422337;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_E7:
						goto IL_10C;
					}
					IL_159:;
				}
				break;
			}
			}
			visitor.VisitRefSet_End(this);
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x000A5BA0 File Offset: 0x000A3DA0
		// (set) Token: 0x06000F76 RID: 3958 RVA: 0x000A5C50 File Offset: 0x000A3E50
		[global::System.Xml.Serialization.XmlAttribute("IsForceLoadSet")]
		[global::System.Runtime.Serialization.DataMember]
		public bool IsForceLoadSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)628854061;
				short num2 = num;
				num = (short)864652589;
				switch (num2 == num)
				{
				}
				num = (short)1376845825;
				if (num != 0)
				{
				}
				num = (short)758710272;
				if (num != 0)
				{
				}
				num = (short)304676864;
				short num3 = num;
				return this.<IsForceLoadSet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1554029345;
				short num2 = num;
				num = (short)160733985;
				switch (num2 == num)
				{
				}
				num = (short)1630470144;
				if (num != 0)
				{
				}
				num = (short)1514209281;
				if (num != 0)
				{
				}
				num = (short)806551552;
				short num3 = num;
				this.<IsForceLoadSet>k__BackingField = value;
			}
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x000A5D04 File Offset: 0x000A3F04
		public bool ShouldSerializeIsGlobalRefSet()
		{
			short num = (short)1574651737;
			short num2 = num;
			num = (short)824002393;
			switch (num2 == num)
			{
			}
			num = (short)1914044417;
			if (num != 0)
			{
			}
			num = (short)1152909312;
			if (num != 0)
			{
			}
			num = (short)897187840;
			short num3 = num;
			return this.IsForceLoadSet;
		}
	}
}
