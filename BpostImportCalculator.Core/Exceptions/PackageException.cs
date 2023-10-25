using System;
using System.Runtime.Serialization;

namespace BpostImportCalculator.Core.Exceptions
{
	[Serializable]
	public class PackageException : Exception
	{
		public PackageException()
		{
		}

		public PackageException(string message) : base(message)
		{
		}

		public PackageException(string message, Exception innerException) : base(message, innerException)
		{
		}

		protected PackageException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
