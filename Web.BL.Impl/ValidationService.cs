using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Web.BL.Abstract;
using Web.DAL.Abstract;

namespace Web.BL.Impl
{
    public class ValidationService : IValidationService
    {
        private readonly IFlatRepository _FlatRepository;
        private readonly IResidentOfFlatRepository _ResidentOfFlatRepository;

        public ValidationService(IFlatRepository FlatRepository, IResidentOfFlatRepository ResidentOfFlatRepository)
        {
            _FlatRepository = FlatRepository;
            _ResidentOfFlatRepository = ResidentOfFlatRepository;
        }

        public bool VerifyPossibilityOfSettlement(int FlatID)
        {
           int SquareOfFlat = _FlatRepository.GetEntity(FlatID).Square;
           int NumberOfResidentsOfFlat = _ResidentOfFlatRepository.ListEntities(obj => obj.FlatID == FlatID).Count();

           return (SquareOfFlat / (NumberOfResidentsOfFlat + 1) >= 9);

        }
    }
}
