﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_api.CustomServices
{
    public class CustomService
    {
		public class SingletonService
		{
			public int Counter;
		}

		public class ScopedService
		{
			public int Counter;
		}

		public class TransientService
		{
			public int Counter;
		}
	}
}
