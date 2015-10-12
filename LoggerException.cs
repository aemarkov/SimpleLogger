using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogger
{
	/// <summary>
	/// Исключение, если логгер уже настроен
	/// </summary>
	class LoggerAlreadySetupException : Exception
	{
		public LoggerAlreadySetupException(): base("Логгер уже создан или настроен")
		{
			
		}

		public LoggerAlreadySetupException(string message) : base(message)
		{

		}
	}
}
