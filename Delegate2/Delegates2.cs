using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{
    internal class Delegate
    {
        public delegate void DataUpload(int percentDone);
        public void iCloudSaver(DataUpload DU )
        {
                for (int i = 0; i < 50000; i++)
                {
                    var Uploaded = i.ToString();
                    DU(i);

                }
        }

                

    }
}

