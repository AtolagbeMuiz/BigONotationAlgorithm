using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildArray
{
    public class NewArray
    {
        public object[] _arrayItems { get; set; }
        public int _Length { get; set; }
        public NewArray(object[] arrayItems)
        {
            _arrayItems = arrayItems;
            _Length = 0;

            //this._arrayItems = arrayItems;
            //this._arrayItems = new dynamic[] { };
            //_Length = 0;            
        }

        public dynamic AddItemToArray(dynamic item)
        {
            //_Length++;
            _arrayItems[_Length - 1] = item;
            _Length++;

            return _arrayItems;
        }

    }
}
