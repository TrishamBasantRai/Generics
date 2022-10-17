using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsheetItems
{
    public class Jedi : IIntern
    {
        private string Name { get; set; }
        private int Id { get; set; }
        public string NameID => $"Jedi - {Name} : {Id}";

        public Jedi(string name, int id)
        {
            Name = name;
            Id = id;
            //NameID = $"Jedi - {name}:{id}";
        }
    }
}
