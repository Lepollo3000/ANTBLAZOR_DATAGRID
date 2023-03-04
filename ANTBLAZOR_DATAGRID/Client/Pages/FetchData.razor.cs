using AntDesign.TableModels;
using AntDesign;
using System.ComponentModel;
using System.Net.Http.Json;
using ANTBLAZOR_DATAGRID.Shared.Models;
using System.Net.Http.Headers;
using ANTBLAZOR_DATAGRID.Shared.RequestFeatures;
using ANTBLAZOR_DATAGRID.Client.Utils.Features;
using Microsoft.AspNetCore.WebUtilities;
using System.Text.Json;
using Microsoft.AspNetCore.Components;

namespace ANTBLAZOR_DATAGRID.Client.Pages
{
    public partial class FetchData
    {
        [Inject]
        public HttpClient _client { get; set; }
        private readonly JsonSerializerOptions _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        Func<PaginationTotalContext, string> _showTotal = ctx => $"Desde {ctx.Range.from} hasta {ctx.Range.to}. Total: {ctx.Total} productos.";
        private readonly int[] _pageSizeOptions = new int[] { 5, 10, 15, 20 };

        private bool _showLoading = false;
        private int _pageSize = 5;
        private int _total = 0;

        private ProductParameters productParameters = new ProductParameters();
        private IEnumerable<Product> _data = new List<Product>();
        /*private IEnumerable<TableFilter<string>> _genderFilters = new List<TableFilter<string>>()
        {
            new TableFilter<string> { Text = "Male", Value = "male" },
            new TableFilter<string> { Text = "Female", Value = "female" }
        };*/

        async Task HandleTableChange(QueryModel<Product> queryModel)
        {
            _showLoading = true;

            PagingResponse<Product> data = new PagingResponse<Product>();

            using (var response = await _client.GetAsync(GetRandomuserParams(queryModel)))
            {
                if (response.IsSuccessStatusCode)
                {
                    MetaData? metaData = JsonSerializer
                        .Deserialize<MetaData>(response.Headers.GetValues("X-Pagination").First(), _options);

                    Stream stream = await response.Content.ReadAsStreamAsync();

                    var pagingResponse = new PagingResponse<Product>
                    {
                        Items = await JsonSerializer.DeserializeAsync<List<Product>>(stream, _options) ?? null!,
                        MetaData = metaData!
                    };

                    data = pagingResponse;
                }
                else
                {
                    var nullPagingResponse = new PagingResponse<Product>
                    {
                        Items = null!,
                        MetaData = null!
                    };

                    data = nullPagingResponse;
                }
            }

            _showLoading = false;
            _data = data!.Items;
            _total = data!.MetaData.TotalCount;
        }

        string GetRandomuserParams(QueryModel<Product> queryModel)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = queryModel.PageIndex.ToString(),
                ["pageSize"] = queryModel.PageSize.ToString(),
                //["searchTerm"] = productParameters.SearchTerm ?? "",
                //["orderBy"] = productParameters.OrderBy ?? ""
            };

            queryModel.SortModel.ForEach(x =>
            {
                queryStringParam.Add("orderBy", x.FieldName.ToLower() ?? "");
                queryStringParam.Add("orderDirection", x.Sort.ToLower() ?? "");
                //query.Add($"orderBy={x.FieldName.ToLower()}");
                //query.Add($"orderDirection={x.Sort}");
            });

            /*queryModel.FilterModel.ForEach(filter =>
			{
				filter.SelectedValues.ForEach(value =>
				{
					queryStringParam.Add(filter.FieldName.ToLower(), value);
					//query.Add($"{filter.FieldName.ToLower()}={value}");
				});
			});*/

            string apiQuery = QueryHelpers.AddQueryString("api/employee", queryStringParam);

            //return string.Join('&', query);
            return apiQuery;
        }
    }
}
