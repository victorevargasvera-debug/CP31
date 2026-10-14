using System;
using System.Text;

namespace NPOI.DDF
{
	// Token: 0x02000541 RID: 1345
	public abstract class EscherProperty
	{
		// Token: 0x060032D7 RID: 13015 RVA: 0x0009F023 File Offset: 0x0009D223
		public EscherProperty(short id)
		{
			this.id = id;
		}

		// Token: 0x060032D8 RID: 13016 RVA: 0x0009F032 File Offset: 0x0009D232
		public EscherProperty(short propertyNumber, bool isComplex, bool isBlipId)
		{
			this.id = propertyNumber + (isComplex ? short.MinValue : 0) + (isBlipId ? 16384 : 0);
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x060032D9 RID: 13017 RVA: 0x0009F05A File Offset: 0x0009D25A
		public virtual short Id
		{
			get
			{
				return this.id;
			}
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x060032DA RID: 13018 RVA: 0x0009F062 File Offset: 0x0009D262
		public virtual short PropertyNumber
		{
			get
			{
				return this.id & 16383;
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x060032DB RID: 13019 RVA: 0x0009F071 File Offset: 0x0009D271
		public virtual bool IsComplex
		{
			get
			{
				return (this.id & short.MinValue) != 0;
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x060032DC RID: 13020 RVA: 0x0009F082 File Offset: 0x0009D282
		public virtual bool IsBlipId
		{
			get
			{
				return (this.id & 16384) != 0;
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x060032DD RID: 13021 RVA: 0x0009F093 File Offset: 0x0009D293
		public virtual string Name
		{
			get
			{
				return global::NPOI.DDF.EscherProperties.GetPropertyName(this.PropertyNumber);
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x060032DE RID: 13022 RVA: 0x00017F5F File Offset: 0x0001615F
		public virtual int PropertySize
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x0009F0A0 File Offset: 0x0009D2A0
		public virtual string ToXml(string tab)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append("<").Append(base.GetType().Name).Append(" id=\"").Append(this.Id).Append("\" name=\"").Append(this.Name).Append("\" blipId=\"").Append(this.IsBlipId).Append("\"/>\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060032E0 RID: 13024
		public abstract int SerializeSimplePart(byte[] data, int pos);

		// Token: 0x060032E1 RID: 13025
		public abstract int SerializeComplexPart(byte[] data, int pos);

		// Token: 0x040017E5 RID: 6117
		protected short id;
	}
}
