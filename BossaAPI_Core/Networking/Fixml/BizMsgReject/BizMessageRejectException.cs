using System;
using System.Runtime.Serialization;

namespace BossaAPI_Core.Fixml
{
	public class BizMessageRejectException : FixmlErrorMsgException
	{
		public new BizMessageRejectMsg Msg { get { return msg as BizMessageRejectMsg; } }

		public BizMessageRejectException(string str, BizMessageRejectMsg msg) : base(str, msg) { }
		public BizMessageRejectException(BizMessageRejectMsg msg) : base(msg) { }

		protected BizMessageRejectException(SerializationInfo info, StreamingContext context) : base(info, context) { }
	}
}
