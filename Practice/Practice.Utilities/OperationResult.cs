﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.SL
{
  public class OperationResult
  {
    public bool Success { get; set; }
    public string ValidationMessage { get; set; }

    public OperationResult()
    {
      ValidationMessage = "";
      Success = false;
    }

  }
}
