using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication
{
	// Token: 0x02000018 RID: 24
	public class HttpListLicense : global::Motorola.Common.Communication.HttpPbbMessageBase
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000045 RID: 69 RVA: 0x0000545C File Offset: 0x0000365C
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00005510 File Offset: 0x00003710
		public global::Motorola.Common.Communication.LicenseInventory ResponseData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1638924289;
				if (num != 0)
				{
				}
				num = (short)1736959267;
				short num2 = num;
				num = (short)1278010659;
				switch (num2 == num)
				{
				}
				num = (short)530382848;
				short num3 = num;
				num = (short)972292096;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1882191516;
				short num2 = num;
				num = (short)522843804;
				switch (num2 == num)
				{
				}
				num = (short)1373700097;
				if (num != 0)
				{
				}
				num = (short)856424448;
				short num3 = num;
				num = (short)48693248;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000055C0 File Offset: 0x000037C0
		public HttpListLicense()
		{
			int a_ = 12;
			base..ctor(global::System.Net.Http.HttpMethod.Get, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꯆꃈ꣊꣌ꇎꋐ뛒鳔맖꿘뻚돜ꯞ軠釢鳤", a_));
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꛆ마믊ꇌꛎ닐닒ꇔ뻖뛘뗚뗞鋠賢诤", a_)));
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000562C File Offset: 0x0000382C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)1591666591;
			short num2 = num;
			num = (short)18081695;
			switch (num2 == num)
			{
			}
			num = (short)1707540481;
			if (num != 0)
			{
			}
			num = (short)1990066176;
			short num3 = num;
			num = (short)1979449344;
			if (num != 0)
			{
			}
			base.DecodeReplyMessage(replyBuffer, offset, length);
			string @string = global::System.Text.Encoding.UTF8.GetString(base._myReplyBuffer, offset, length);
			this.ResponseData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.LicenseInventory>(@string);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000056FC File Offset: 0x000038FC
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)1223329952;
			short num2 = num;
			num = (short)403212448;
			switch (num2 == num)
			{
			}
			num = (short)531693569;
			if (num != 0)
			{
			}
			num = (short)634519552;
			short num3 = num;
			num = (short)1763377152;
			if (num != 0)
			{
			}
			base.HandleResponse(response);
			string result = response.Content.ReadAsStringAsync().Result;
			this.ResponseData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.LicenseInventory>(result);
		}

		// Token: 0x0400003B RID: 59
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.LicenseInventory a;
	}
}
