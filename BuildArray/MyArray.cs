using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildArray
{
    public class MyArray
    {
        public int Length { get; set; }
        public dynamic[] Data { get; set; }

        //public int arraySize { get; set; }
        //public List<dynamic> Data { get; set; }
        public MyArray()
        {
            this.Length = 0;
            this.Data = new dynamic[2];
        }

        public dynamic getAData(int index)
        {
            if (this.Data == null)
                return null;

            if(this.Data.Length == 0)
                return "undefined";
            
            return this.Data[index];
        }

        public void add(dynamic item)
        {
            this.Data[this.Length] = item;
            this.Length++;
        }
    }
}
