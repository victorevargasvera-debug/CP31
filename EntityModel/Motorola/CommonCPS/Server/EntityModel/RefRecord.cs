using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000100 RID: 256
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class RefRecord : global::Motorola.CommonCPS.Server.EntityModel.DBNode
	{
		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x000A5DC8 File Offset: 0x000A3FC8
		// (set) Token: 0x06000F7A RID: 3962 RVA: 0x000A5E78 File Offset: 0x000A4078
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute("UUID")]
		public string RefUUID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)30801921;
				if (num != 0)
				{
				}
				num = (short)71310585;
				short num2 = num;
				num = (short)96410873;
				switch (num2 == num)
				{
				}
				num = (short)713359360;
				if (num != 0)
				{
				}
				num = (short)1732771840;
				short num3 = num;
				return this.<RefUUID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)128730209;
				short num2 = num;
				num = (short)1825850465;
				switch (num2 == num)
				{
				}
				num = (short)1268580352;
				if (num != 0)
				{
				}
				num = (short)1307377665;
				if (num != 0)
				{
				}
				num = (short)552075264;
				short num3 = num;
				this.<RefUUID>k__BackingField = value;
			}
		}
	}
}
