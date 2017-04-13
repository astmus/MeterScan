using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MeterScan
{
	public class Logger
	{
		private string pathToCurrentLogFile;
		private Logger()
		{
			pathToCurrentLogFile = DateTime.Now.Date.ToString("yyyy_MM_") + "log.txt";
			CreateFileIfNotExists(pathToCurrentLogFile);
		}

		private static Logger _instance = null;
		private static object _lockObj = new object();
		public static Logger Instance
		{
			get
			{
				lock (_lockObj)
				{
					return _instance ?? (_instance = new Logger());
				}
			}
		}

		#region private methods

		private void CreateFileIfNotExists(string fileName)
		{
			if (System.IO.File.Exists(fileName)) return;

			using (FileStream stream = System.IO.File.Create(fileName))
			{
				stream.Close();
			}
		}
		
		private string FormattedLogString(string message, string type)
		{			
			return String.Format("{0}<{1}> -> {2};", DateTime.Now.ToString("dd.MM hh:mm:ss"), type, message);
		}

		#endregion

		#region public methods

		public void LogTrace(string message)
		{
			using (StreamWriter writer = new StreamWriter(pathToCurrentLogFile, true))
			{
				writer.WriteLine(FormattedLogString(message, "Trace"));
				writer.Close();
			}
		}

		public void LogInfo(string message)
		{
			using (StreamWriter writer = new StreamWriter(pathToCurrentLogFile, true))
			{
				writer.WriteLine(FormattedLogString(message, "Info"));
				writer.Close();
			}
		}

		public void LogError(string message)
		{
			using (StreamWriter writer = new StreamWriter(pathToCurrentLogFile, true))
			{
				writer.WriteLine(FormattedLogString(message, "Error"));
				writer.Close();
			}
		}

		public void LogDebug(string message)
		{
			using (StreamWriter writer = new StreamWriter(pathToCurrentLogFile, true))
			{
				writer.WriteLine(FormattedLogString(message, "Debug"));
				writer.Close();
			}
		}	
		
		#endregion
	}
}
