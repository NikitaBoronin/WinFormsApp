using System.Xml.Serialization;


namespace WinFormsApp1
{
    public class XmlReadWrite
    {

        public void Write(List<Pet> pets)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Pet>));
            using (FileStream fs =  new FileStream("pets.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, pets);
            }
        }

        public List<Pet> Read()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Pet>));
            using (FileStream fs = new FileStream("pets.xml", FileMode.Open))
            {
                List<Pet> pets = (List<Pet>)serializer.Deserialize(fs);
                return pets;
            }
        }


    }
}
