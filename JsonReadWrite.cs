using System.Text.Json;

namespace WinFormsApp1
{
    public class JsonReadWrite
    {
        public List<Pet> Read()
        {
            string json = File.ReadAllText("pets.json");
            List<Pet> pets= JsonSerializer.Deserialize<List<Pet>>(json);
            return pets;
        }

        public void Write(List<Pet> pets)
        {
            string path = "pets.json";
            string json = JsonSerializer.Serialize(pets, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }

    }
}
