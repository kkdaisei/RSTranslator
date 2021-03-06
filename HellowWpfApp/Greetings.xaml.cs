﻿using System;
using System.Windows;
using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Collections.Generic;

using CsvHelper;


namespace HellowWpfApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        IEnumerable<RakutenCSV> importRakuten(Stream stream)
        {
            IEnumerable<RakutenCSV> records;
            StreamReader fileReader = new StreamReader(stream, Encoding.GetEncoding(932));
            CsvReader rakutenCSV = new CsvReader(fileReader);
            rakutenCSV.Configuration.RegisterClassMap<RakutenCSVMapper>();
            records = rakutenCSV.GetRecords<RakutenCSV>();
            
            return records;
        }

        void exportSagawa(String outPath, List<SagawaCVS> sagawa)
        {
            using (StreamWriter textWriter = new StreamWriter(outPath, false, Encoding.GetEncoding(932)))
            using (CsvWriter csvWriter = new CsvWriter(textWriter))
            {
                csvWriter.Configuration.RegisterClassMap<SagawaCSVMapper>();
                csvWriter.Configuration.HasHeaderRecord = false;
                csvWriter.Configuration.Encoding = Encoding.GetEncoding(932);
                csvWriter.WriteRecords(sagawa);
            }
        }

        void exchangeRakutenToSagawa(string path)
        {
            using(FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                var dir = Path.GetDirectoryName(path);
                IEnumerable<RakutenCSV> records;
                try
                {
                    records = importRakuten(fileStream);
                }
                catch
                {
                    MessageBox.Show("読み込みに失敗しました。");
                    return;
                }

                int errorNum = 0;

                List<SagawaCVS> list = new List<SagawaCVS>();

                foreach (var record in records)
                {
                    var t = new Translator(record);
                    list.Add(t.toSagawa());
                }

                try
                {
                    var record = list[0];
                    var name = record.clientName1;
                    var newPath = Path.Combine(dir, name);
                    newPath = Path.ChangeExtension(newPath, "csv");
                    exportSagawa(newPath, list);
                }
                catch
                {
                    errorNum += 1;
                }

                if (errorNum != 0)
                {
                    MessageBox.Show(String.Format("{0}件の書き込みに失敗しました。", errorNum));
                    return;
                }
                else
                {
                    MessageBox.Show(String.Format("変換を終了しました。"));
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "CSVファイル(*.csv)|*.csv",
                Title = "開くファイルを選択してください"
            };
            if (ofd.ShowDialog() == true)
            {
                exchangeRakutenToSagawa(ofd.FileName);
            }
        }
    }
}
