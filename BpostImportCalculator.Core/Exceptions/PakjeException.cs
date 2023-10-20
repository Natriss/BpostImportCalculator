using System;
using System.Runtime.Serialization;

namespace BpostImportCalculator.Core.Exceptions
{
	[Serializable]
	public class PakjeException : Exception
	{
		public PakjeException()
		{
		}

		public PakjeException(string message) : base(message)
		{
		}

		public PakjeException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected PakjeException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
