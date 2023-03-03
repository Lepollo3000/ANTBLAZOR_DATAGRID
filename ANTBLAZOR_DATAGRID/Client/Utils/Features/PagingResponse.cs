﻿using ANTBLAZOR_DATAGRID.Shared.RequestFeatures;

namespace ANTBLAZOR_DATAGRID.Client.Utils.Features
{
    public class PagingResponse<T> where T : class
    {
        public List<T> Items { get; set; } = null!;
        public MetaData MetaData { get; set; } = null!;
    }
}
