using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Newtonsoft.Json;
using tccxamarin.Models;
using Xamarin.Forms;

namespace tccxamarin
{
    public partial class Benchmark : ContentPage
    {
        public Benchmark()
        {
            InitializeComponent();
        }

        async void iniciarTeste(System.Object sender, System.EventArgs e)
        {
            var stopwatch = new Stopwatch();
            var client = new HttpClient();
            var uri = "https://firestore.googleapis.com/v1/projects/names-database-448b8/databases/(default)/documents/names/tcc/";
            var result = await client.GetStringAsync(uri);
            var decodedJson = JsonConvert.DeserializeObject<BenchmarkTest>(result);
            var arr = decodedJson.fields.names.arrayValue.values;

            stopwatch.Start();
            for(int j = 0; j < 100000; j++)
            {
                string a;
                for(int i = arr.Count; i-- > 0;)
                {
                    a = arr[i].stringValue;
                }
                foreach(UserBenchmark b in arr)
                {
                    a = b.stringValue;
                }
            }
            resultBenchmark.Text = $"Tempo passado: {stopwatch.Elapsed}";
            stopwatch.Stop();
        }
    }
}
