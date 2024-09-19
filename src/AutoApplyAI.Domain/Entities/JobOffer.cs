using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoApplyAI.Domain.Entities
{
    public class JobOffer
    {
        public int Id { get; set; }
        public string JobTitle { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string JobDescription { get; set; } = string.Empty;
        public string RequiredSkills { get; set; } = string.Empty;
    }
}
