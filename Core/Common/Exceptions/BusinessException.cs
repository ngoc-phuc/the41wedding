using System;

namespace Common.Exceptions
{
    public class BusinessException : Exception
    {
        public BusinessException() : base("Business exception")
        {
        }

        public BusinessException(string errorMessage) : base(errorMessage)
        {
        }
    }
}