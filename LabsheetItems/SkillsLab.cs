using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsheetItems
{
    public class SkillsLab : IIntern
    {
        private string Name { get; set; }
        private int Id { get; set; }
        public string NameID => $"SkillsLab - {Name} : {Id}";

        public SkillsLab(string name, int id)
        {
            Name = name;
            Id = id;
            //NameID = $"SkillsLab - {name}:{id}";
        }
    }
}
