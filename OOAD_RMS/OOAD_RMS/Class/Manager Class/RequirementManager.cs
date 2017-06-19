using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOAD_RMS
{
    public class RequirementManager
    {
        private List<Requirement> _requirements = new List<Requirement>();

        public void addRequirement(Requirement requirement)
        {
            _requirements.Add(requirement);
        }

        public void editRequirement(Requirement requirement)
        {
        }

        public void deleteRequirement(Requirement requirement)
        {
            _requirements.Remove(requirement);
        }

        public List<Requirement> GetRequirements(Project project)
        {
            return _requirements.OrderBy(y => y.RequirementName).ToList().FindAll(c => c.Project == project);
        }
    }
}
