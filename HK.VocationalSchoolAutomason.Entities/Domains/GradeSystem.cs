﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HK.VocationalSchoolAutomason.Entities.Domains
{
    public class GradeSystem : BaseEntity
    {
        public int CourseId { get; set; }
        public int StudentMajorLevelGroupId { get; set; }
        public decimal NoteOne { get; set; }
        public decimal NoteTwo { get; set; }
        public decimal NoteThree { get; set; }
        public decimal OralGrade { get; set; }
        public decimal Average { get; set; }
        public bool Status { get; set; }

        public Course Course { get; set; }
        public StudentMajorLevelGroup StudentMajorLevelGroup { get; set; }

    }
}
