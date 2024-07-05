using ConsoleClient.Model;
using Newtonsoft.Json;
using System.Text;

namespace ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetAndDisplayClassrooms();
            GetAndDisplayClassroom(2);
            Console.ReadLine();
        }

        public async static void GetAndDisplayClassrooms()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                HttpResponseMessage response = await client.GetAsync("https://localhost:10000/classroom");

                string message = await response.Content.ReadAsStringAsync();

                //Console.WriteLine(message);

                List<Classroom>? classrooms = JsonConvert.DeserializeObject<List<Classroom>>(message);

                foreach (var classroom in classrooms)
                {
                    Console.WriteLine($"{classroom.ClassroomID} - {classroom.Name}");
                }
            };
        }

        public async static void GetAndDisplayClassroom(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                HttpResponseMessage response = await client.GetAsync($"https://localhost:10000/classroom/{id}");

                string message = await response.Content.ReadAsStringAsync();

                //Console.WriteLine(message);

                Classroom? classroom = JsonConvert.DeserializeObject<Classroom>(message);

                if (classroom != null)
                    Console.WriteLine($"{classroom.ClassroomID} - {classroom.Name}");
            };
        }

        public async static void PostClassroom(Classroom classroom)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                string classroomInJson = JsonConvert.SerializeObject(classroom);
                StringContent httpContent = new StringContent(classroomInJson, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync($"https://localhost:10000/classroom/", httpContent);
                if (response.IsSuccessStatusCode)
                {
                    string message = await response.Content.ReadAsStringAsync();

                    Classroom? classroomResult = JsonConvert.DeserializeObject<Classroom>(message);

                    if (classroom != null)
                        Console.WriteLine($"{classroomResult.ClassroomID} - {classroomResult.Name}");
                }
                else
                {
                    Console.WriteLine("erreur dans l'ajout");
                }
            }
        }

        public async static void DeleteAndDisplayClassroom(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Accept", "application/json");

                HttpResponseMessage response = await client.DeleteAsync($"https://localhost:10000/classroom/{id}");

                string message = await response.Content.ReadAsStringAsync();

                //Console.WriteLine(message);

                Classroom? classroom = JsonConvert.DeserializeObject<Classroom>(message);

                if (classroom != null)
                    Console.WriteLine($"{classroom.ClassroomID} - {classroom.Name}");
            };
        }

        public async static void PutClassroom(int id, Classroom classroom)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();

                string classroomInJson = JsonConvert.SerializeObject(classroom);
                StringContent httpContent = new StringContent(classroomInJson, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync($"https://localhost:10000/classroom/{classroom.ClassroomID}", httpContent);

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("la mise a jour a été faite");
                }
                else
                {
                    Console.WriteLine("erreur de la mise a jour");
                }
            }
        }
    }
}
