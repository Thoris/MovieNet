using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieNet.Extract
{
    public class Extractor
    {
        #region Methods

        public void Execute(string file)
        {
            StreamReader reader = new StreamReader(file);


            reader.Close();
        }

        #endregion
    }
}
