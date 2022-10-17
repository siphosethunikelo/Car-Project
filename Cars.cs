using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Day29_Car_Project
{
    internal class Cars
    {
        public string type;
        public string model;
        public string yearModel;
        public string engineNum;
    
        
        public Cars(string aType,string aModel,string aYearModel,string aEngineNum)
        {
            type = aType;
            model = aModel;
            yearModel = aYearModel;
            engineNum = aEngineNum; 
        }

    }
    
}
