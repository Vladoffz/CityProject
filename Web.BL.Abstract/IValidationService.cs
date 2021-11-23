using System;
using System.Collections.Generic;
using System.Text;

namespace Web.BL.Abstract
{
    public interface IValidationService
    {
        public bool VerifyPossibilityOfSettlement(int FlatID);
    }
}
