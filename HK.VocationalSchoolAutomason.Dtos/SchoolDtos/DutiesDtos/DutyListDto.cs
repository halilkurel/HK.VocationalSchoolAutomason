﻿using HK.VocationalSchoolAutomason.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HK.VocationalSchoolAutomason.Dtos.SchoolDtos.DutiesDtos
{
    public class DutyListDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
