﻿using System;

namespace SharedMolecules.Entities
{
    public interface ITrackable
    {
        DateTime CreatedAt { get; set; }
        string CreatedBy { get; set; }
        DateTime LastUpdatedAt { get; set; }
        string LastUpdatedBy { get; set; }
    }
}
