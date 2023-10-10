﻿using FluentValidation;
using HK.VocationalSchoolAutomason.Dtos.SchoolDtos.LevelGroupMajorDtos;

namespace HK.VocationalSchoolAutomason.Bussiness.ValidationRules.LevelGroupMajorValidation
{
    public class LevelGroupMajorCreateValidation : AbstractValidator<LevelGroupMajorCreateDto>
    {
        public LevelGroupMajorCreateValidation()
        {
            RuleFor(dto => dto.MajorId)
                .GreaterThan(0).WithMessage("Geçerli bir major kimliği sağlanmalıdır.");

            RuleFor(dto => dto.LevelId)
                .GreaterThan(0).WithMessage("Geçerli bir level kimliği sağlanmalıdır.");

            RuleFor(dto => dto.GruopId)
                .GreaterThan(0).WithMessage("Geçerli bir grup kimliği sağlanmalıdır.");
        }
    }
}
