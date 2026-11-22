using System;
using System.Collections.Generic;
using System.Text;

namespace Healthcare.Domain.Enums;

public enum RequestStatus
{
    Pending = 1,
    Accepted = 2,
    OnTheWay = 3,
    InProgress = 4,
    Completed = 5,
    Cancelled = 6
}