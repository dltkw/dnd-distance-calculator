using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnd_distance_calculator
{
    class DataImport
    {
        public static List<string> Places { get { return _places; } set { _places = value; } }

        private static List<string> _places = new List<string>();

        public static Dictionary<string, int> ExcelImport()
        {
            //var table = new DataTable();
            //var rows = new List<string>();
            var distances = new Dictionary<string, int>();
            var path = "";
            var distance = 0;

            ISheet sheet;
            using (var stream = new FileStream("test.xlsx", FileMode.Open))
            {
                stream.Position = 0;
                var workbook = new XSSFWorkbook(stream);
                sheet = workbook.GetSheetAt(0);

                for (int r = 1; r <= sheet.LastRowNum; r++)
                {
                    var row = sheet.GetRow(r);
                    var from = row.GetCell(0).ToString();
                    var to = row.GetCell(1).ToString();

                    path = $"{from} %% {to}";
                    distance = int.Parse(row.GetCell(2).ToString());
                    distances.Add(path, distance);

                    if (!Places.Contains(from)) Places.Add(from);
                    if (!Places.Contains(to)) Places.Add(to);
                }
            }

            return distances;
        }
    }
}
