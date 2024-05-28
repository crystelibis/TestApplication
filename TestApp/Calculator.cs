namespace TestApp
{
    internal class Calculator {
        static SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
        static List<Task> tasks = new List<Task>();
        
        internal static string GetText() {
            // return string.Join(';', dictionary);
            return string.Join(';', dictionary.OrderBy(k => k.Value).ToDictionary(x => x.Key, x => x.Value).Values) + $"\r\nTotal:{dictionary["Total"]}";
        }
        internal static string GetCurrentText()
        {
            return string.Join(';', dictionary.OrderBy(k => k.Value).ToDictionary(x => x.Key, x => x.Value).Values) + $"\r\nTotal:{dictionary["Total"]}";
            
        }

#if RELEASE
        internal static void Calculate() {
            dictionary.Clear();
            dictionary.Add("Total", "0");
            if (Debugger.IsAttached) {
                for (int i = 0; i < 100; i++) {
                    dictionary.Add(i.ToString(), i.ToString());
                    dictionary["Total"] = (int.Parse(dictionary["Total"]) + i).ToString();
                }
            }
            var rand = new Random();
            foreach (string fileName in Directory.GetFiles("C:\Users\cryst\TestApp\TestApp\Files")) {
                tasks.Add(Task.Factory.StartNew(() => {
                    string text = File.ReadAllText(fileName);
                    Thread.Sleep(rand.Next(5000));
                    dictionary.Add(fileName, text);
                    dictionary["Total"] = (int.Parse(dictionary["Total"]) + int.Parse(text)).ToString();
                }));
            }
        }
#else
        internal static async Task Calculate(int count,TextBox total) {
            dictionary.Clear();
            dictionary.Add("Total", 0);
            for (int i = 0; i < count; i++) {
                dictionary.Add(i.ToString(), i);
                dictionary["Total"] = ((dictionary["Total"]) + i);
                total.Text = dictionary["Total"].ToString();
                await Task.Delay(500);
            }
        }
#endif
    }
}
