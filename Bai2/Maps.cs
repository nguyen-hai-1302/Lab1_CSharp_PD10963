using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bai2
{
    public class Maps
    {
        public string ID {  get; set; }
        public string Name { get; set; }
        public string _inGame = "lien minh huyen thoai";
        public Maps(string id,  string name)
        {
            ID = id;
            Name = name;
        }
        public Maps() 
        { 
            
        }
        public string showData()
        {
            return "ID: " + ID + " |Name: " + Name + " |InGame: " + _inGame;
        }
    }
}
