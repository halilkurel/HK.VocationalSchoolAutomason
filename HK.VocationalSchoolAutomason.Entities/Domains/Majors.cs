﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HK.VocationalSchoolAutomason.Entities.Domains
{
    public class Majors : BaseEntity
    {
        public string MajorName { get; set; }
        public List<LevelGruopMojor> LevelGruopMojors { get; set; }

    }
}
