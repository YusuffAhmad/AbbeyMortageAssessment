﻿namespace AbbeyMortageAssessment.Services.JSON
{
    using System.Collections.Generic;

    public interface IJsonService<T>
    {
        IEnumerable<T> GetObjects(string json);

        string SerializeObjects(List<T> objects);
    }
}
