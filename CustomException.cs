using System;
namespace ExceptionDemo
{
	public class CustomException : Exception
	{
        public ExceptionTypes exceptionTypes;
        public enum ExceptionTypes
		{
			NULL,
			EUMPTY
		}
		
		public CustomException(string message, ExceptionTypes exceptionTypes) : base(message)
		{
			this.exceptionTypes = exceptionTypes;
		}
	}
}

