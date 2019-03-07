using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToyLanguageCS.Model.DataStructures
{
	class FileTuple
	{
		private string fileName;
		private StreamReader streamReader;
		//private BufferedStream bufferedStream;
		public FileTuple(string fileName, StreamReader streamReader)
		{
			this.fileName = fileName;
			this.streamReader = streamReader;
		}

		public string getFileName()
		{
			return fileName;
		}

		public StreamReader getStreamReader()
		{
			return streamReader;
		}

		
		public override string ToString()
		{
			return "(filename:" + fileName + "," + "c# file descriptor:" + streamReader + ")";

		}

	}
}
