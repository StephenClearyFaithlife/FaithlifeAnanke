using System;
using System.Collections.Generic;
using System.Text;
using Faithlife.Ananke.Services;

namespace Faithlife.Ananke.Tests.Util
{
	public sealed class StubSignalService : ISignalService
	{
		public void Invoke(string signalName)
		{
			m_handler?.Invoke(signalName);
		}

		public void AddHandler(Action<string> handler)
		{
			m_handler += handler;
		}

		private Action<string> m_handler;
	}
}
