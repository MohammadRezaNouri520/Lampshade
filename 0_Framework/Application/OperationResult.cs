using System;

namespace _0_Framework.Application
{
    public class OperationResult
    {
        public bool IsSuccedded { get; set; }
        public string Message { get; set; }

        public OperationResult()
        {
            IsSuccedded = false;
        }

        public OperationResult Succedded(string message = "عملیات با موفقیت انجام شد")
        {
            IsSuccedded = true;
            Message = message;
            return this;
        }

        public OperationResult Failed(string message = "اطلاعات وارد شده اشتباه است!")
        {
            IsSuccedded = false;
            Message = message;
            return this;
        }

        public OperationResult Failed(object passwordsNotMatch)
        {
            IsSuccedded = false;
            Message = "نام کاربری یا رمز عبور اشتباه است!";
            return this;
        }
    }
}
