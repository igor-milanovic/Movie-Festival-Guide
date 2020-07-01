﻿using MFG.Application.DataTransfer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MFG.Application.Queries
{
    public interface IGetLocationQuery : IQuery<int, LocationQueryDto>
    {
    }
}