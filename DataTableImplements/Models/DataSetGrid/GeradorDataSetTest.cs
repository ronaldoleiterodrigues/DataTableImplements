using System.Data;

namespace DataTableImplements.Models.DataSetGrid
{
    public class GeradorDataSetTest
    {
        public DataSet Converter<T>(List<T> dados, string nomeTabela) where T : class
        {
            var dataset = new DataSet();

            dataset.Tables.Add(nomeTabela);

            var colunas = dados[0]
                .GetType()
                .GetProperties()
                .Where(p => p.CanRead)
                .Select(p => new DataColumn
                {
                    ColumnName = p.Name,
                })
                .ToArray();

            dataset.Tables[nomeTabela]?.Columns.AddRange(colunas);

            foreach (var dado in dados.Skip(1))
            {
                var linha = dado
                    .GetType()
                    .GetProperties()
                    .Where(p => p.CanRead)
                    .Select(p => p.GetValue(dado)?.ToString() ?? "")
                    .ToArray();

                dataset.Tables[nomeTabela]?.Rows.Add(linha);
            }

            return dataset;
        }

    }
}
