﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHRApp
{
    public class ApplicationSettings
    {
        public string FhirBaseUrl { get; set; }
        public string organization { get; set; }
        public string practitioner { get; set; }
        public string practitionerrole { get; set; }
    }
}
